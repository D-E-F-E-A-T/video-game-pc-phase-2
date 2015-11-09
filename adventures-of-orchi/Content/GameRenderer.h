#pragma once

#include "..\Common\DeviceResources.h"
#include "ShaderStructures.h"
#include "..\Common\StepTimer.h"
#include "Grid.h"
#include "ScreenBuilder.h"
#include "Model\Player.h"
#include "BroadCollisionStrategy.h"
#include "NarrowCollisionStrategy.h"
#include "Model\Stack.h"
#include "..\PortalCollisionStrategy.h"

using namespace Windows::UI::Core;
using namespace std;
using namespace Microsoft::WRL;
using namespace DX;

namespace adventures_of_orchi
{
	// This sample renderer instantiates a basic rendering pipeline.
	class GameRenderer
	{
	public:
		GameRenderer(const std::shared_ptr<DeviceResources>& deviceResources, CoreWindow ^ window);
		void CreateDeviceDependentResources();
		void CreateWindowSizeDependentResources();
		void ReleaseDeviceDependentResources();
		int Update(DX::StepTimer const& timer);
		void Render();
		void StartTracking();
		void TrackingUpdate(float positionX);
		void StopTracking();
		bool IsTracking() { return m_tracking; }

		void OnKeyDown(KeyEventArgs ^ args);
		void OnSizeChanged(WindowSizeChangedEventArgs ^ args);

		Grid grid;
		ScreenBuilder * m_screenBuilder;

		void CreateLifeText();
		void CreateMapText();
		void CreateButtonsText();
		void CreateInventoryText();
		void CreatePackText();

		void DrawLifeText();
		void DrawMapText();
		void DrawButtonsText();
		void DrawInventoryText();
		void DrawPackText();

		void DrawLeftMargin();
		void DrawRightMargin();

	private:
		void Rotate(float radians);

		Platform::Agile<CoreWindow> m_window;

		// Cached pointer to device resources.
		std::shared_ptr<DeviceResources> m_deviceResources;

		// Direct3D resources for cube geometry.
		ComPtr<ID3D11InputLayout>	m_inputLayout;
		ComPtr<ID3D11Buffer>		m_vertexBuffer;
		ComPtr<ID3D11Buffer>		m_indexBuffer;
		ComPtr<ID3D11VertexShader>	m_vertexShader;
		ComPtr<ID3D11PixelShader>	m_pixelShader;
		ComPtr<ID3D11Buffer>		m_constantBuffer;

		// System resources for cube geometry.
		ModelViewProjectionConstantBuffer	m_constantBufferData;
		uint32	m_indexCount;

		// Variables used with the rendering loop.
		bool	m_loadingComplete;
		float	m_degreesPerSecond;
		bool	m_tracking;

		Stack * m_pStack;
		Stack m_stack;

		ComPtr<IDWriteTextLayout1> m_textLayoutLife;
		ComPtr<IDWriteTextLayout1> m_textLayoutButtons;
		ComPtr<IDWriteTextLayout1> m_textLayoutMap;
		ComPtr<IDWriteTextLayout1> m_textLayoutInventory;
		ComPtr<IDWriteTextLayout1> m_textLayoutPack;

		void RenderSpaces2D();
		void RenderSpaces3D();
		void BuildScreen();

		Player * m_pPlayer;

		float m_fWindowWidth;
		float m_fWindowHeight;
		
		// Input related members
		bool                    m_isControllerConnected;  // Do we have a controller connected
		XINPUT_CAPABILITIES     m_xinputCaps;             // Capabilites of the controller
		XINPUT_STATE            m_xinputState;            // The current state of the controller
		uint64                  m_lastEnumTime;           // Last time a new controller connection was checked

		void FetchControllerInput();
		void MovePlayer(uint16 buttons, short horizontal, short vertical);
		void HandleLeftThumbStick(short horizontal, short vertical);

		void DrawSpriteIntersection();
		int m_nCollisionState;

		int m_nCollidedSpriteColumn;
		int m_nCollidedSpriteRow;

		bool m_bSpriteCollisionDetected;

		BroadCollisionStrategy * m_broadCollisionDetectionStrategy;
		NarrowCollisionStrategy * m_pNarrowCollisionDetectionStrategy;
		PortalCollisionStrategy * m_pPortalCollisionDetectionStrategy;

		list<Space *> * m_pCollided;
		void HighlightRegion(int column, int row, ComPtr<ID2D1SolidColorBrush> brush);
		void HighlightRegion(int * pLocation, ComPtr<ID2D1SolidColorBrush> brush);

		DWRITE_TEXT_RANGE m_textRange;
		ComPtr<IDWriteTextFormat>                       m_textFormat;

#ifdef RENDER_DIAGNOSTICS
		vector<D2D1_RECT_F> m_collidedRects;
		vector<int> m_collidedRectStatuses;
#endif // RENDER_DIAGNOSTICS
	};
}

