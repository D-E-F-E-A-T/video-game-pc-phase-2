#include "pch.h"
#include "GameRenderer.h"

#include "..\Common\DirectXHelper.h"

using namespace adventures_of_orchi;

using namespace DirectX;
using namespace Windows::Foundation;

// Loads vertex and pixel shaders from files and instantiates the cube geometry.
GameRenderer::GameRenderer(const std::shared_ptr<DX::DeviceResources>& deviceResources, CoreWindow ^ window) :
	m_loadingComplete(false),
	m_degreesPerSecond(45),
	m_indexCount(0),
	m_tracking(false),
	m_deviceResources(deviceResources)
{
	CreateDeviceDependentResources();
	CreateWindowSizeDependentResources();

	m_window = window;

	m_pTreeData = new std::vector<BaseSpriteData *>;

	grid.SetWindowWidth(m_window->Bounds.Width);
	grid.SetWindowHeight(m_window->Bounds.Height);
	grid.SetNumColumns(NUM_GRID_COLUMNS);
	grid.SetNumRows(NUM_GRID_ROWS);

	BuildScreen();
//	this->m_pPlayer = new Player(&grid);
}

// Initializes view parameters when the window size changes.
void GameRenderer::CreateWindowSizeDependentResources()
{
	Size outputSize = m_deviceResources->GetOutputSize();
	float aspectRatio = outputSize.Width / outputSize.Height;
	float fovAngleY = 70.0f * XM_PI / 180.0f;

	// This is a simple example of change that can be made when the app is in
	// portrait or snapped view.
	if (aspectRatio < 1.0f)
	{
		fovAngleY *= 2.0f;
	}

	// Note that the OrientationTransform3D matrix is post-multiplied here
	// in order to correctly orient the scene to match the display orientation.
	// This post-multiplication step is required for any draw calls that are
	// made to the swap chain render target. For draw calls to other targets,
	// this transform should not be applied.

	// This sample makes use of a right-handed coordinate system using row-major matrices.
	XMMATRIX perspectiveMatrix = XMMatrixPerspectiveFovRH(
		fovAngleY,
		aspectRatio,
		0.01f,
		100.0f
		);

	XMFLOAT4X4 orientation = m_deviceResources->GetOrientationTransform3D();

	XMMATRIX orientationMatrix = XMLoadFloat4x4(&orientation);

	XMStoreFloat4x4(
		&m_constantBufferData.projection,
		XMMatrixTranspose(perspectiveMatrix * orientationMatrix)
		);

	// Eye is at (0,0.7,1.5), looking at point (0,-0.1,0) with the up-vector along the y-axis.
	static const XMVECTORF32 eye = { 0.0f, 0.7f, 1.5f, 0.0f };
	static const XMVECTORF32 at = { 0.0f, -0.1f, 0.0f, 0.0f };
	static const XMVECTORF32 up = { 0.0f, 1.0f, 0.0f, 0.0f };

	XMStoreFloat4x4(&m_constantBufferData.view, XMMatrixTranspose(XMMatrixLookAtRH(eye, at, up)));
}

// Called once per frame, rotates the cube and calculates the model and view matrices.
void GameRenderer::Update(DX::StepTimer const& timer)
{
	if (!m_tracking)
	{
		// Convert degrees to radians, then convert seconds to rotation angle
		float radiansPerSecond = XMConvertToRadians(m_degreesPerSecond);
		double totalRotation = timer.GetTotalSeconds() * radiansPerSecond;
		float radians = static_cast<float>(fmod(totalRotation, XM_2PI));

		Rotate(radians);
	}
}

// Rotate the 3D cube model a set amount of radians.
void GameRenderer::Rotate(float radians)
{
	// Prepare to pass the updated model matrix to the shader
	XMStoreFloat4x4(&m_constantBufferData.model, XMMatrixTranspose(XMMatrixRotationY(radians)));
}

void GameRenderer::StartTracking()
{
	m_tracking = true;
}

// When tracking, the 3D cube can be rotated around its Y axis by tracking pointer position relative to the output screen width.
void GameRenderer::TrackingUpdate(float positionX)
{
	if (m_tracking)
	{
		float radians = XM_2PI * 2.0f * positionX / m_deviceResources->GetOutputSize().Width;
		Rotate(radians);
	}
}

void GameRenderer::StopTracking()
{
	m_tracking = false;
}

// Renders one frame using the vertex and pixel shaders.
void GameRenderer::Render()
{
	// Loading is asynchronous. Only draw geometry after it's loaded.
	if (!m_loadingComplete)
	{
		return;
	}

/*
	auto context = m_deviceResources->GetD3DDeviceContext();

	// Prepare the constant buffer to send it to the graphics device.
	context->UpdateSubresource(
		m_constantBuffer.Get(),
		0,
		NULL,
		&m_constantBufferData,
		0,
		0
		);

	// Each vertex is one instance of the VertexPositionColor struct.
	UINT stride = sizeof(VertexPositionColor);
	UINT offset = 0;
	context->IASetVertexBuffers(
		0,
		1,
		m_vertexBuffer.GetAddressOf(),
		&stride,
		&offset
		);

	context->IASetIndexBuffer(
		m_indexBuffer.Get(),
		DXGI_FORMAT_R16_UINT, // Each index is one 16-bit unsigned integer (short).
		0
		);

	context->IASetPrimitiveTopology(D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST);

	context->IASetInputLayout(m_inputLayout.Get());

	// Attach our vertex shader.
	context->VSSetShader(
		m_vertexShader.Get(),
		nullptr,
		0
		);

	// Send the constant buffer to the graphics device.
	context->VSSetConstantBuffers(
		0,
		1,
		m_constantBuffer.GetAddressOf()
		);

	// Attach our pixel shader.
	context->PSSetShader(
		m_pixelShader.Get(),
		nullptr,
		0
		);

	// Draw the objects.
	context->DrawIndexed(
		m_indexCount,
		0,
		0
		);
*/

	ID3D11RenderTargetView * renderTargets[1] = { m_deviceResources->m_d3dRenderTargetView.Get() };

	//ID3D11RenderTargetView * renderTargets[1] = { m_d3dRenderTargetView.Get() };

	m_deviceResources->GetD3DDeviceContext()->OMSetRenderTargets(
		1,
		renderTargets,
		m_deviceResources->m_d3dDepthStencilView.Get());

	m_deviceResources->GetD3DDeviceContext()->ClearDepthStencilView(
		m_deviceResources->m_d3dDepthStencilView.Get(),
		D3D11_CLEAR_DEPTH | D3D11_CLEAR_STENCIL,
		1.0f,
		0);

	DrawSprites();
}

void GameRenderer::CreateDeviceDependentResources()
{
	// Load shaders asynchronously.
	auto loadVSTask = DX::ReadDataAsync(L"SampleVertexShader.cso");
	auto loadPSTask = DX::ReadDataAsync(L"SamplePixelShader.cso");

	// After the vertex shader file is loaded, create the shader and input layout.
	auto createVSTask = loadVSTask.then([this](const std::vector<byte>& fileData) {
		DX::ThrowIfFailed(
			m_deviceResources->GetD3DDevice()->CreateVertexShader(
				&fileData[0],
				fileData.size(),
				nullptr,
				&m_vertexShader
				)
			);

		static const D3D11_INPUT_ELEMENT_DESC vertexDesc [] =
		{
			{ "POSITION", 0, DXGI_FORMAT_R32G32B32_FLOAT, 0, 0, D3D11_INPUT_PER_VERTEX_DATA, 0 },
			{ "COLOR", 0, DXGI_FORMAT_R32G32B32_FLOAT, 0, 12, D3D11_INPUT_PER_VERTEX_DATA, 0 },
		};

		DX::ThrowIfFailed(
			m_deviceResources->GetD3DDevice()->CreateInputLayout(
				vertexDesc,
				ARRAYSIZE(vertexDesc),
				&fileData[0],
				fileData.size(),
				&m_inputLayout
				)
			);
	});

	// After the pixel shader file is loaded, create the shader and constant buffer.
	auto createPSTask = loadPSTask.then([this](const std::vector<byte>& fileData) {
		DX::ThrowIfFailed(
			m_deviceResources->GetD3DDevice()->CreatePixelShader(
				&fileData[0],
				fileData.size(),
				nullptr,
				&m_pixelShader
				)
			);

		CD3D11_BUFFER_DESC constantBufferDesc(sizeof(ModelViewProjectionConstantBuffer) , D3D11_BIND_CONSTANT_BUFFER);
		DX::ThrowIfFailed(
			m_deviceResources->GetD3DDevice()->CreateBuffer(
				&constantBufferDesc,
				nullptr,
				&m_constantBuffer
				)
			);
	});

	// Once both shaders are loaded, create the mesh.
	auto createCubeTask = (createPSTask && createVSTask).then([this] () {

		// Load mesh vertices. Each vertex has a position and a color.
		static const VertexPositionColor cubeVertices[] = 
		{
			{XMFLOAT3(-0.5f, -0.5f, -0.5f), XMFLOAT3(0.0f, 0.0f, 0.0f)},
			{XMFLOAT3(-0.5f, -0.5f,  0.5f), XMFLOAT3(0.0f, 0.0f, 1.0f)},
			{XMFLOAT3(-0.5f,  0.5f, -0.5f), XMFLOAT3(0.0f, 1.0f, 0.0f)},
			{XMFLOAT3(-0.5f,  0.5f,  0.5f), XMFLOAT3(0.0f, 1.0f, 1.0f)},
			{XMFLOAT3( 0.5f, -0.5f, -0.5f), XMFLOAT3(1.0f, 0.0f, 0.0f)},
			{XMFLOAT3( 0.5f, -0.5f,  0.5f), XMFLOAT3(1.0f, 0.0f, 1.0f)},
			{XMFLOAT3( 0.5f,  0.5f, -0.5f), XMFLOAT3(1.0f, 1.0f, 0.0f)},
			{XMFLOAT3( 0.5f,  0.5f,  0.5f), XMFLOAT3(1.0f, 1.0f, 1.0f)},
		};

		D3D11_SUBRESOURCE_DATA vertexBufferData = {0};
		vertexBufferData.pSysMem = cubeVertices;
		vertexBufferData.SysMemPitch = 0;
		vertexBufferData.SysMemSlicePitch = 0;
		CD3D11_BUFFER_DESC vertexBufferDesc(sizeof(cubeVertices), D3D11_BIND_VERTEX_BUFFER);
		DX::ThrowIfFailed(
			m_deviceResources->GetD3DDevice()->CreateBuffer(
				&vertexBufferDesc,
				&vertexBufferData,
				&m_vertexBuffer
				)
			);

		// Load mesh indices. Each trio of indices represents
		// a triangle to be rendered on the screen.
		// For example: 0,2,1 means that the vertices with indexes
		// 0, 2 and 1 from the vertex buffer compose the 
		// first triangle of this mesh.
		static const unsigned short cubeIndices [] =
		{
			0,2,1, // -x
			1,2,3,

			4,5,6, // +x
			5,7,6,

			0,1,5, // -y
			0,5,4,

			2,6,7, // +y
			2,7,3,

			0,4,6, // -z
			0,6,2,

			1,3,7, // +z
			1,7,5,
		};

		m_indexCount = ARRAYSIZE(cubeIndices);

		D3D11_SUBRESOURCE_DATA indexBufferData = {0};
		indexBufferData.pSysMem = cubeIndices;
		indexBufferData.SysMemPitch = 0;
		indexBufferData.SysMemSlicePitch = 0;
		CD3D11_BUFFER_DESC indexBufferDesc(sizeof(cubeIndices), D3D11_BIND_INDEX_BUFFER);
		DX::ThrowIfFailed(
			m_deviceResources->GetD3DDevice()->CreateBuffer(
				&indexBufferDesc,
				&indexBufferData,
				&m_indexBuffer
				)
			);
	});

	// Once the cube is loaded, the object is ready to be rendered.
	createCubeTask.then([this] () {
		m_loadingComplete = true;
	});
}

void GameRenderer::ReleaseDeviceDependentResources()
{
	m_loadingComplete = false;
	m_vertexShader.Reset();
	m_inputLayout.Reset();
	m_pixelShader.Reset();
	m_constantBuffer.Reset();
	m_vertexBuffer.Reset();
	m_indexBuffer.Reset();
}

void GameRenderer::BuildScreen()
{
	delete m_screenBuilder;

	m_screenBuilder =
		new ScreenBuilder(
			m_window->Bounds.Width,
			m_window->Bounds.Height);

	// Use chain-of-responsibility?
	m_screenBuilder->BuildScreen1(m_pTreeData);

	//LifePanel lifePanel(
	//	m_window->Bounds.Width - m_window->Bounds.Width * RIGHT_MARGIN_RATIO,
	//	m_window->Bounds.Height * HEART_PANEL_HEIGHT_RATIO,
	//	m_window->Bounds.Width * RIGHT_MARGIN_RATIO,
	//	HEART_PANEL_HEIGHT);

	//lifePanel.BuildPanel(&m_heartData);
}


void GameRenderer::DrawSprites()
{
	ComPtr<ID3D11RenderTargetView> renderTargetView;

	// Get the target associated with the back buffer.
	// Select the scratch buffer for drawing sprites.
	m_deviceResources->GetD3DDeviceContext()->OMGetRenderTargets(
		1,
		&renderTargetView,
		//		&m_d3dOffscreenRenderTargetView,
		nullptr
		);

	m_deviceResources->m_spriteBatch->Begin(renderTargetView, m_deviceResources->m_dpi);
	//	m_spriteBatch->Begin(m_d3dOffscreenRenderTargetView);

	// @see: http://www.gamedev.net/topic/603359-c-dx11-how-to-get-texture-size/


	ID3D11Texture2D * pTextureInterface = NULL;

	std::vector<BaseSpriteData *>::const_iterator iterator;

	// This is a sprite run.
	for (iterator = m_pTreeData->begin(); iterator != m_pTreeData->end(); iterator++)
	{
		float fColumnWidth = grid.GetColumnWidth();
		float fRowHeight = grid.GetRowHeight();

		m_deviceResources->m_spriteBatch->Draw(
			m_deviceResources->m_tree.Get(),
			(*iterator)->pos,
			BasicSprites::PositionUnits::DIPs,
			float2(fColumnWidth, fRowHeight),
			BasicSprites::SizeUnits::DIPs,
			float4(0.8f, 0.8f, 1.0f, 1.0f),
			(*iterator)->rot
			);
	}

	/*
	m_heart.Get()->QueryInterface<ID3D11Texture2D>(&pTextureInterface);
	D3D11_TEXTURE2D_DESC heartDesc;
	pTextureInterface->GetDesc(&heartDesc);

	// This is a sprite run.
	for (auto heart = m_heartData.begin(); heart != m_heartData.end(); heart++)
	{
	m_spriteBatch->Draw(
	m_heart.Get(),
	heart->pos,
	BasicSprites::PositionUnits::DIPs,
	float2(
	((m_window->Bounds.Width - m_window->Bounds.Width * RIGHT_MARGIN_RATIO) / NUM_HEART_COLUMNS) / heartDesc.Width / 2.0f * 0.85f,
	(HEART_PANEL_HEIGHT / NUM_HEART_ROWS) / heartDesc.Height) * 0.85f,
	BasicSprites::SizeUnits::Normalized,
	float4(0.8f, 0.8f, 1.0f, 1.0f),
	heart->rot
	);
	}
	*/
	// This is a sprite run.
	//m_spriteBatch->Draw(
	//	m_orchi.Get(),
	//	m_orchiData.pos,
	//	BasicSprites::PositionUnits::DIPs,
	//	float2(grid.GetColumnWidth(), grid.GetRowHeight()),	// This will stretch or shrink orchi.
	//	BasicSprites::SizeUnits::DIPs,
	//	float4(0.8f, 0.8f, 1.0f, 1.0f),
	//	m_orchiData.rot
	//	);

	m_deviceResources->m_spriteBatch->End();

	// Copy from the scratch buffer to the back buffer.
	// Create a bitmap and copy??? http://xboxforums.create.msdn.com/forums/p/84925/511738.aspx
	//	renderTargetView->

}