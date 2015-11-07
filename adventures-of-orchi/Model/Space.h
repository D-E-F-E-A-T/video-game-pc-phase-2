#pragma once
#include "..\pch.h"
#include "..\Constants.h"
#include "..\Common\DeviceResources.h"

using namespace BasicSprites;
using namespace std;

class Space
{
public:
	Space() {};

	Space::Space(
		float2 fLocationRatio,
		float2 fDimensions,
		bool bIsVisible,
		bool bIsActionable,
		bool bIsCollidable,
		const shared_ptr<DeviceResources>& deviceResources)
	{
		m_deviceResources = deviceResources;

		//		m_pSprite = spriteData;
		m_fLocationRatio = fLocationRatio;
		m_fDimensions = fDimensions;

		m_bIsVisible = bIsVisible;
		m_bIsActionable = bIsActionable;
		m_bIsCollidable = bIsCollidable;

		m_spriteBatch = ref new BasicSprites::SpriteBatch();
		unsigned int capacity = SampleSettings::Performance::ParticleCountMax +
			SampleSettings::NumTrees + 1;

		m_spriteBatch->Initialize(
			m_deviceResources->GetD3DDevice(),
			capacity);

		BasicLoader ^ loader =
			ref new BasicLoader(
				m_deviceResources->GetD3DDevice(),
				m_deviceResources->GetWicImagingFactory());

		loader->LoadTexture(
			"tree.dds",
			&m_tree,
			nullptr);

		m_spriteBatch->AddTexture(m_tree.Get());

		loader->LoadTexture(
			"rock.dds",
			&m_rock,
			nullptr);

		m_spriteBatch->AddTexture(m_rock.Get());

		loader->LoadTexture(
			"water.dds",
			&m_water,
			nullptr);

		m_spriteBatch->AddTexture(m_water.Get());

		loader->LoadTexture(
			"grass.dds",
			&m_grass,
			nullptr);

		m_spriteBatch->AddTexture(m_grass.Get());

		loader->LoadTexture(
			"stonewall.dds",
			&m_stoneWall,
			nullptr);

		m_spriteBatch->AddTexture(m_stoneWall.Get());

		loader->LoadTexture(
			"link.dds",
			//		"test.dds",
			&m_orchi,
			nullptr);

		m_spriteBatch->AddTexture(m_orchi.Get());

		loader->LoadTexture(
			"heart.dds",
			&m_heart,
			nullptr);

		m_spriteBatch->AddTexture(m_heart.Get());
	}

	void Space::Render(float2 fWindowDimensions, float2 fScaleDimensions, float dpi)
	{
		ComPtr<ID3D11RenderTargetView> renderTargetView;

		m_deviceResources->GetD3DDeviceContext()->OMGetRenderTargets(
			1,
			&renderTargetView,
			nullptr
			);

		m_spriteBatch->Begin(renderTargetView.Get(), dpi);

		//ID3D11Texture2D * pTextureInterface = NULL;

		//std::vector<Space *>::const_iterator iterator;

		//float fColumnWidth = grid.GetColumnWidth();
		//float fRowHeight = grid.GetRowHeight();

		float2 fPosition = 
			GetLocationRatio() * float2(fWindowDimensions.x, fWindowDimensions.y);

		float2 fDimensions = float2{ 100.f, 100.f };

		m_spriteBatch->Draw(
			m_tree.Get(),
			fPosition,
			BasicSprites::PositionUnits::DIPs,
			m_fDimensions * fScaleDimensions,
			BasicSprites::SizeUnits::DIPs,
			float4(0.8f, 0.8f, 1.0f, 1.0f),
			0.0f);

		//for (iterator = m_pTreeData->begin(); iterator != m_pTreeData->end(); iterator++)
		//{
		//	float fColumnWidth = grid.GetColumnWidth();
		//	float fRowHeight = grid.GetRowHeight();

		//	m_spriteBatch->Draw(
		//		m_tree.Get(),
		//		(*iterator)->pos,
		//		BasicSprites::PositionUnits::DIPs,
		//		float2(fColumnWidth, fRowHeight),
		//		BasicSprites::SizeUnits::DIPs,
		//		float4(0.8f, 0.8f, 1.0f, 1.0f),
		//		(*iterator)->rot
		//		);
		//}
		//	m_spriteBatch->Begin(m_d3dOffscreenRenderTargetView);

		//(*iterator)->GetSpriteTexture(),
		//(*iterator)->GetLocationRatio() * float2(m_fWindowWidth, m_fWindowHeight),
		//BasicSprites::PositionUnits::DIPs,
		//float2(fColumnWidth, fRowHeight),
		//BasicSprites::SizeUnits::DIPs,
		//float4(0.8f, 0.8f, 1.0f, 1.0f),
		//0.f);

		m_spriteBatch->End();
	}

	float2 Space::GetLocationRatio()
	{
		return m_fLocationRatio;
	}


	ID3D11Texture2D * Space::GetSpriteTexture()
	{
		return m_pSprite;
	}

protected:
	float2 m_fLocationRatio;
	float2 m_fDimensions;
	bool m_bIsVisible;
	bool m_bIsActionable;
	bool m_bIsCollidable;

	SpriteBatch ^ m_spriteBatch;

//	SpaceInfo * m_pInfo;
	ID3D11Texture2D * m_pSprite;
	// Sprite * m_pSprite

	ComPtr<ID3D11Texture2D> m_tree;
	ComPtr<ID3D11Texture2D> m_rock;
	ComPtr<ID3D11Texture2D> m_water;
	ComPtr<ID3D11Texture2D> m_stoneWall;
	ComPtr<ID3D11Texture2D> m_grass;
	ComPtr<ID3D11Texture2D> m_orchi;
	ComPtr<ID3D11Texture2D> m_heart;
	
private:

	shared_ptr<DeviceResources> m_deviceResources;
};