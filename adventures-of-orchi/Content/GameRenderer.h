#pragma once

#include "..\Common\DeviceResources.h"
#include "ShaderStructures.h"
#include "..\Common\StepTimer.h"
#include "Grid.h"
#include "ScreenBuilder.h"

using namespace Windows::UI::Core;

namespace adventures_of_orchi
{
	// This sample renderer instantiates a basic rendering pipeline.
	class GameRenderer
	{
	public:
		GameRenderer(const std::shared_ptr<DX::DeviceResources>& deviceResources, CoreWindow ^ window);
		void CreateDeviceDependentResources();
		void CreateWindowSizeDependentResources();
		void ReleaseDeviceDependentResources();
		void Update(DX::StepTimer const& timer);
		void Render();
		void StartTracking();
		void TrackingUpdate(float positionX);
		void StopTracking();
		bool IsTracking() { return m_tracking; }

		Grid grid;
		ScreenBuilder * m_screenBuilder;

	private:
		//BasicSprites::SpriteBatch ^ m_spriteBatch;
		void Rotate(float radians);

		CoreWindow ^ m_window;

		// Cached pointer to device resources.
		std::shared_ptr<DX::DeviceResources> m_deviceResources;

		// Direct3D resources for cube geometry.
		Microsoft::WRL::ComPtr<ID3D11InputLayout>	m_inputLayout;
		Microsoft::WRL::ComPtr<ID3D11Buffer>		m_vertexBuffer;
		Microsoft::WRL::ComPtr<ID3D11Buffer>		m_indexBuffer;
		Microsoft::WRL::ComPtr<ID3D11VertexShader>	m_vertexShader;
		Microsoft::WRL::ComPtr<ID3D11PixelShader>	m_pixelShader;
		Microsoft::WRL::ComPtr<ID3D11Buffer>		m_constantBuffer;

		// System resources for cube geometry.
		ModelViewProjectionConstantBuffer	m_constantBufferData;
		uint32	m_indexCount;

		// Variables used with the rendering loop.
		bool	m_loadingComplete;
		float	m_degreesPerSecond;
		bool	m_tracking;

		std::vector<BaseSpriteData *> * m_pTreeData;
		std::vector<BaseSpriteData> m_rockData;
		std::vector<BaseSpriteData> m_waterData;
		std::vector<BaseSpriteData> m_stoneWallData;
		std::vector<BaseSpriteData> m_grassData;

		//ComPtr<ID3D11Texture2D> m_tree;
		//ComPtr<ID3D11Texture2D> m_rock;
		//ComPtr<ID3D11Texture2D> m_water;
		//ComPtr<ID3D11Texture2D> m_stoneWall;
		//ComPtr<ID3D11Texture2D> m_grass;
		//ComPtr<ID3D11Texture2D> m_orchi;

		void DrawSprites();
		void BuildScreen();
	};
}

