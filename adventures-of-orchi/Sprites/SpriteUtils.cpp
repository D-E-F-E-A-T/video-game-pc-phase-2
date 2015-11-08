#include "pch.h"
#include "SpriteUtils.h"
#include "..\Constants.h"

uint8_t * SpriteUtils::ReadPixels(
	ID3D11DeviceContext2 * context,
	ID3D11Device2 * device,
	ID3D11Texture2D * texture,
	int * dimensions)
{
	HBITMAP	hBitmapTexture = NULL;

	ID3D11Texture2D* d3dtex = (ID3D11Texture2D*)texture;
	D3D11_TEXTURE2D_DESC desc;
	d3dtex->GetDesc(&desc);

	ID3D11Texture2D* pNewTexture = NULL;
	D3D11_TEXTURE2D_DESC description;
	d3dtex->GetDesc(&description);

	description.BindFlags = 0;

	description.CPUAccessFlags = D3D11_CPU_ACCESS_READ | D3D11_CPU_ACCESS_WRITE;
	description.Usage = D3D11_USAGE_STAGING;
	HRESULT hr = device->CreateTexture2D(&description, NULL, &pNewTexture);

	ID3D11DeviceContext* ctx = NULL;
	device->GetImmediateContext(&ctx);

	ctx->CopyResource(pNewTexture, d3dtex);

	D3D11_MAPPED_SUBRESOURCE resource;
	UINT subresource = D3D11CalcSubresource(0, 0, 0);
	ctx->Map(pNewTexture, subresource, D3D11_MAP_READ_WRITE, 0, &resource);

	// COPY from texture to bitmap buffer
	uint8_t* sptr = reinterpret_cast<uint8_t*>(resource.pData);
	uint8_t* dptr = new uint8_t[desc.Width * desc.Height * 4];

	for (size_t h = 0; h < desc.Height; ++h)
	{
		size_t msize = std::min<size_t>(desc.Width * 4, resource.RowPitch);
		memcpy_s(dptr, desc.Width * 4, sptr, msize);
		sptr += resource.RowPitch;
		dptr += desc.Width * 4;
	}

	dptr -= desc.Width*desc.Height * 4;

	ctx->Unmap(pNewTexture, subresource);

	// SWAP BGR to RGB bitmap
	// Notice the capital "P". dptr vs dPtr.
	uint32_t * dPtr = reinterpret_cast<uint32_t*>(dptr);

	*(dimensions + WIDTH_INDEX) = desc.Width;
	*(dimensions + HEIGHT_INDEX) = desc.Height;

	return dptr;
}