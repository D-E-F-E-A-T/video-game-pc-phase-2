#include "pch.h"
#include "GameRenderer.h"

#include "..\Common\DirectXHelper.h"
#include "ScreenUtils.h"
#include "LeftMargin.h"
#include "RightMargin.h"
#include "LifePanel.h"
#include "..\Model\Portal.h"
#include "Utils.h"

using namespace adventures_of_orchi;

using namespace DirectX;
using namespace Windows::Foundation;

using namespace std;


// Loads vertex and pixel shaders from files and instantiates the cube geometry.
GameRenderer::GameRenderer(const shared_ptr<DX::DeviceResources>& deviceResources, CoreWindow ^ window) :
	m_loadingComplete(false),
	m_degreesPerSecond(45),
	m_indexCount(0),
	m_tracking(false),
	m_deviceResources(deviceResources),
	m_isControllerConnected(false)
{
	CreateDeviceDependentResources();
	CreateWindowSizeDependentResources();

	m_window = window;

	m_pSpaces = new vector<Space *>;

	m_fWindowWidth = m_window->Bounds.Width;
	m_fWindowHeight = m_window->Bounds.Height;

	grid.SetWindowWidth(m_window->Bounds.Width);
	grid.SetWindowHeight(m_window->Bounds.Height);
	grid.SetNumColumns(NUM_GRID_COLUMNS);
	grid.SetNumRows(NUM_GRID_ROWS);

	BuildScreen();
	this->m_pPlayer = new Player();
	m_pCollided = new list<Space *>;
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

	// TODO: Create panels for each of these.
	//CreateLifeText();
	//CreateButtonsText();

	//CreateMapText();
	//CreateInventoryText();
	//CreatePackText();
}

// Called once per frame, rotates the cube and calculates the model and view matrices.
void GameRenderer::Update(DX::StepTimer const& timer)
{
	// DO NOT USE m_window HERE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

	if (!m_tracking)
	{
		// Convert degrees to radians, then convert seconds to rotation angle
		//float radiansPerSecond = XMConvertToRadians(m_degreesPerSecond);
		//double totalRotation = timer.GetTotalSeconds() * radiansPerSecond;
		//float radians = static_cast<float>(fmod(totalRotation, XM_2PI));

		//Rotate(radians);

		FetchControllerInput();


		float2 playerSize = m_deviceResources->m_spriteBatch->GetSpriteSize(
			m_deviceResources->m_orchi.Get());
		float2 spriteSize = m_deviceResources->m_spriteBatch->GetSpriteSize(
			m_deviceResources->m_tree.Get());

		float playerLocation[2];

		// These are within the range of screen pixel size.
		playerLocation[0] = (m_fWindowWidth -
			(m_fWindowWidth * LEFT_MARGIN_RATIO) -
			(m_fWindowWidth * RIGHT_MARGIN_RATIO)) *
			m_pPlayer->GetLocationRatio().x +
			(m_fWindowWidth * LEFT_MARGIN_RATIO);

		playerLocation[1] = m_pPlayer->GetLocationRatio().y * m_fWindowHeight;

		m_broadCollisionDetectionStrategy->Detect(
			grid,
			m_pCollided,
			playerSize,
			spriteSize,
			m_pPlayer,
			m_pSpaces,
			m_fWindowWidth,
			m_fWindowHeight,
			playerLocation);

		m_nCollisionState = m_pNarrowCollisionDetectionStrategy->Detect(
			DEVICE_CONTEXT_3D,
			DEVICE_3D,
			m_deviceResources->m_orchi.Get(),
			m_deviceResources->m_tree.Get(),
			m_pPlayer,
			m_pCollided,
			playerLocation,
			&grid,
			intersectRect,
			float2(m_fWindowWidth, m_fWindowHeight));


		// if the gamepad is not connected, check the keyboard.
		if (m_isControllerConnected)
		{
			// This would actually, detect a collision one interation
			//	too late.  Consider detection earlier since
			//	this could lead to weird behavior, depending
			//	on how fast the sprites are moving.
			//	For example, if sprites are moving very quickly,
			//	collision would occur when the sprites 
			//	have deeply intersected each other.
			//  For slow moving sprites, this would not be 
			//	much of a problem.
			MovePlayer(
				m_xinputState.Gamepad.wButtons,
				m_xinputState.Gamepad.sThumbLX,
				m_xinputState.Gamepad.sThumbLY);
		}

		UpdatePlayer();
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

	D2D1_SIZE_F renderTargetSize = DEVICE_CONTEXT_2D->GetSize();

	DEVICE_CONTEXT_2D->BeginDraw();

	DEVICE_CONTEXT_2D->Clear(D2D1::ColorF(D2D1::ColorF::CornflowerBlue));
	DEVICE_CONTEXT_2D->SetTransform(D2D1::Matrix3x2F::Identity());

	DrawLeftMargin();
	DrawRightMargin();

	//DrawLifeText();
	//DrawButtonsText();

	//DrawMapText();
	//DrawInventoryText();
	//DrawPackText();

	grid.SetVisibility(true);

	grid.Draw(DEVICE_CONTEXT_2D, m_deviceResources->m_blackBrush);

	auto context = DEVICE_CONTEXT_3D;



#ifdef RENDER_DIAGNOSTICS

	std::list<Space *>::const_iterator iterator;

	for (iterator = m_pCollided->begin(); iterator != m_pCollided->end(); iterator++)
	{
		int column = 0;
		int row = 0;

		::ConvertRatioToGridLocations(grid, (*iterator)->GetLocationRatio(), &column, &row);

		HighlightSprite(
			column, 
			row, 
			m_deviceResources->m_redBrush);
	}

	if (m_nCollisionState == INTERSECTION ||
		m_nCollisionState == COLLISION)
		DrawSpriteIntersection();
#endif // RENDER_DIAGNOSTICS

	HRESULT hr = DEVICE_CONTEXT_2D->EndDraw();



	ID3D11RenderTargetView * renderTargets = m_deviceResources->m_d3dRenderTargetView.Get();


	DEVICE_CONTEXT_3D->OMSetRenderTargets(
		1,
		&renderTargets,
		NULL);// m_deviceResources->m_d3dDepthStencilView.Get());

	// Without this, the player renders on top of the trees.
	//DEVICE_CONTEXT_3D->ClearDepthStencilView(
	//	m_deviceResources->m_d3dDepthStencilView.Get(),
	//	D3D11_CLEAR_DEPTH | D3D11_CLEAR_STENCIL,
	//	1.0f,
	//	0);


	
	DrawSprites();

	m_pCollided->clear();
}

void GameRenderer::CreateDeviceDependentResources()
{
	// Load shaders asynchronously.
	auto loadVSTask = DX::ReadDataAsync(L"SampleVertexShader.cso");
	auto loadPSTask = DX::ReadDataAsync(L"SamplePixelShader.cso");

	// After the vertex shader file is loaded, create the shader and input layout.
	auto createVSTask = loadVSTask.then([this](const std::vector<byte>& fileData) {
		DX::ThrowIfFailed(
			DEVICE_3D->CreateVertexShader(
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
			DEVICE_3D->CreateInputLayout(
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
			DEVICE_3D->CreatePixelShader(
				&fileData[0],
				fileData.size(),
				nullptr,
				&m_pixelShader
				)
			);

		CD3D11_BUFFER_DESC constantBufferDesc(sizeof(ModelViewProjectionConstantBuffer) , D3D11_BIND_CONSTANT_BUFFER);
		DX::ThrowIfFailed(
			DEVICE_3D->CreateBuffer(
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
			DEVICE_3D->CreateBuffer(
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
			DEVICE_3D->CreateBuffer(
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
	m_screenBuilder->BuildScreen1(
		m_pSpaces,
		m_deviceResources->m_tree.Get());

	LifePanel lifePanel(
		m_window->Bounds.Width - m_window->Bounds.Width * RIGHT_MARGIN_RATIO,
		m_window->Bounds.Height * HEART_PANEL_HEIGHT_RATIO,
		m_window->Bounds.Width * RIGHT_MARGIN_RATIO,
		HEART_PANEL_HEIGHT);

//	lifePanel.BuildPanel(&m_heartData);
}


void GameRenderer::DrawSprites()
{
	ComPtr<ID3D11RenderTargetView> renderTargetView;

	// Get the target associated with the back buffer.
	// Select the scratch buffer for drawing sprites.
	DEVICE_CONTEXT_3D->OMGetRenderTargets(
		1,
		&renderTargetView,
		nullptr
		);

	m_deviceResources->m_spriteBatch->Begin(renderTargetView, m_deviceResources->m_dpi);


	// @see: http://www.gamedev.net/topic/603359-c-dx11-how-to-get-texture-size/


	ID3D11Texture2D * pTextureInterface = NULL;

	std::vector<Space *>::const_iterator iterator;

	// This is a sprite run.
	for (iterator = m_pSpaces->begin(); iterator != m_pSpaces->end(); iterator++)
	{
		float fColumnWidth = grid.GetColumnWidth();
		float fRowHeight = grid.GetRowHeight();

		m_deviceResources->m_spriteBatch->Draw(
			(*iterator)->GetSpriteTexture(),
			(*iterator)->GetLocationRatio() * float2(m_fWindowWidth, m_fWindowHeight),
			BasicSprites::PositionUnits::DIPs,
			float2(fColumnWidth, fRowHeight),
			BasicSprites::SizeUnits::DIPs,
			float4(0.8f, 0.8f, 1.0f, 1.0f),
			0.f
			);
	}

	//m_deviceResources->m_heart.Get()->QueryInterface<ID3D11Texture2D>(&pTextureInterface);
	//D3D11_TEXTURE2D_DESC heartDesc;
	//pTextureInterface->GetDesc(&heartDesc);

	//// This is a sprite run.
	//for (auto heart = m_heartData.begin(); heart != m_heartData.end(); heart++)
	//{
	//	m_deviceResources->m_spriteBatch->Draw(
	//		m_deviceResources->m_heart.Get(),
	//		heart->pos,
	//		BasicSprites::PositionUnits::DIPs,
	//		float2(
	//			((m_fWindowWidth - m_fWindowWidth * RIGHT_MARGIN_RATIO) / NUM_HEART_COLUMNS) / heartDesc.Width / 2.0f * 0.85f,
	//			(HEART_PANEL_HEIGHT / NUM_HEART_ROWS) / heartDesc.Height) * 0.85f,
	//		BasicSprites::SizeUnits::Normalized,
	//		float4(0.8f, 0.8f, 1.0f, 1.0f),
	//		heart->rot
	//		);
	//}

	float fCurrentX = m_pPlayer->GetLocationRatio().x;

	float fBoardWidth = m_fWindowWidth - (m_fWindowWidth * LEFT_MARGIN_RATIO) - (m_fWindowWidth * RIGHT_MARGIN_RATIO);
	float fBoardLocation = fCurrentX * fBoardWidth;
	float fX = fBoardLocation + (m_fWindowWidth * LEFT_MARGIN_RATIO);

	m_deviceResources->m_spriteBatch->Draw(
		m_deviceResources->m_orchi.Get(),
		float2(fX, m_pPlayer->GetLocationRatio().y * m_fWindowHeight),
		BasicSprites::PositionUnits::DIPs,
		float2(grid.GetColumnWidth(), grid.GetRowHeight()),	// This will stretch or shrink orchi.
		BasicSprites::SizeUnits::DIPs,
		float4(0.8f, 0.8f, 1.0f, 1.0f),
		0.f
		);

	m_deviceResources->m_spriteBatch->End();

	// Copy from the scratch buffer to the back buffer.
	// Create a bitmap and copy??? http://xboxforums.create.msdn.com/forums/p/84925/511738.aspx
}


// DO NOT USE m_window in the Update/Render loop as
//	it causes the loop to stall.
void GameRenderer::UpdatePlayer()
{
	float x = 0.0f;
	float y = 0.0f;

	// Want player to move with same speed when
	//	moving vertically or horizontally.
	//	Thus, don't consider the side margins when
	//	multiplying by the player's location ratios.
	float fBoundsWidth = m_fWindowWidth; // m_window->Bounds.Width;
	float fBoundsHeight = m_fWindowHeight;	// m_window->Bounds.Height;

	float fPlayerHRatio = m_pPlayer->GetLocationRatio().x;
	float fPlayerVRatio = m_pPlayer->GetLocationRatio().y;

	//m_pPlayer->GetGridLocation() *= {5.f, 5.f};

	//m_pPlayer->GetLocationRatio().x = ((fBoundsWidth -
	//	fBoundsWidth * LEFT_MARGIN_RATIO -
	//	fBoundsWidth * RIGHT_MARGIN_RATIO) *
	//	fPlayerHRatio) +
	//	(fBoundsWidth * LEFT_MARGIN_RATIO) / this->m_fWindowWidth;

	//m_orchiData.pos.y = fBoundsHeight * fPlayerVRatio;

	//float tempRot = 0.0f;
	//float tempMag = 0.0f;
	//m_orchiData.vel.x = tempMag * cosf(tempRot);
	//m_orchiData.vel.y = tempMag * sinf(tempRot);
	//m_orchiData.rot = 0.0f;
	//m_orchiData.scale = 1.0f;
	//m_orchiData.rotVel = 0.0f;
}


void GameRenderer::FetchControllerInput()
{
	if (!m_isControllerConnected)
	{
		//
		// Enumerating for XInput devices takes 'time' on the order of milliseconds.
		// Any time a device is not currently known as connected (not yet called XInput, or calling
		// an XInput function after a failure) ennumeration happens.
		// An app should avoid repeatedly calling XInput functions if there are no known devices connected
		// as this can slow down application performance.
		// This sample takes the simple approach of not calling XInput functions after failure
		// until a specified timeout has passed.
		//
		uint64 currentTime = ::GetTickCount64();
		if (currentTime - m_lastEnumTime < XINPUT_ENUM_TIMEOUT_MS)
		{
			return;
		}
		m_lastEnumTime = currentTime;

		// Check for controller connection by trying to get the capabilties
		uint32 capsResult = XInputGetCapabilities(0, XINPUT_FLAG_GAMEPAD, &m_xinputCaps);
		if (capsResult != ERROR_SUCCESS)
		{
			return;
		}

		// Device is connected
		m_isControllerConnected = true;
	}

	uint32 stateResult = XInputGetState(0, &m_xinputState);
	if (stateResult != ERROR_SUCCESS)
	{
		// Device is no longer connected
		m_isControllerConnected = false;
		m_lastEnumTime = ::GetTickCount64();
	}
}

void GameRenderer::MovePlayer(uint16 buttons, short horizontal, short vertical)
{
	if (buttons & XINPUT_GAMEPAD_DPAD_UP)
	{
		m_pPlayer->MoveNorth(m_nCollisionState, PLAYER_MOVE_VELOCITY);
	}
	else if (buttons & XINPUT_GAMEPAD_DPAD_DOWN)
	{
		m_pPlayer->MoveSouth(m_nCollisionState, PLAYER_MOVE_VELOCITY);
	}
	else if (buttons & XINPUT_GAMEPAD_DPAD_LEFT)
	{
		m_pPlayer->MoveWest(m_nCollisionState, PLAYER_MOVE_VELOCITY);
	}
	else if (buttons & XINPUT_GAMEPAD_DPAD_RIGHT)
	{
		m_pPlayer->MoveEast(m_nCollisionState, PLAYER_MOVE_VELOCITY);
	}
	else
	{
		HandleLeftThumbStick(horizontal, vertical);
	}
}

void GameRenderer::HandleLeftThumbStick(short horizontal, short vertical)
{
	float radius = (float)(sqrt((double)horizontal * (double)horizontal + (double)vertical * (double)vertical));
	float velocity = 0.f;

	if (radius < WALKING_THRESHOLD)
		return;
	if (radius >= WALKING_THRESHOLD && radius < RUNNING_THRESHOLD)
		velocity = PLAYER_MOVE_VELOCITY;
	else if (radius >= RUNNING_THRESHOLD)
		velocity = PLAYER_MOVE_VELOCITY * 2.0f;

	if (horizontal == 0)
	{
		if (vertical > 0)
		{
			m_pPlayer->MoveNorth(m_nCollisionState, velocity);
		}
		else if (vertical < 0)
		{
			m_pPlayer->MoveSouth(m_nCollisionState, velocity);
		}
	}
	else if (vertical == 0)
	{
		if (horizontal > 0)
		{
			m_pPlayer->MoveEast(m_nCollisionState, velocity);
		}
		else if (horizontal < 0)
		{
			m_pPlayer->MoveWest(m_nCollisionState, velocity);
		}
	}
	else
	{
		float param = (float)vertical / (float)horizontal;
		float theta = (float)(atan(param) * 180.0f / PI);

		if (horizontal > 0 && vertical > 0)
		{
			// Upper-right quadrant.
			if (theta <= 45.f)
				m_pPlayer->MoveEast(m_nCollisionState, velocity);
			else
				m_pPlayer->MoveNorth(m_nCollisionState, velocity);
		}
		else if (horizontal > 0 && vertical < 0)
		{
			// Lower-right quadrant.
			if (theta >= -45.f)
				m_pPlayer->MoveEast(m_nCollisionState, velocity);
			else
				m_pPlayer->MoveSouth(m_nCollisionState, velocity);
		}
		else if (horizontal < 0 && vertical > 0)
		{
			// Upper-left quadrant.
			if (theta >= -45.f)
				m_pPlayer->MoveWest(m_nCollisionState, velocity);
			else
				m_pPlayer->MoveNorth(m_nCollisionState, velocity);
		}
		else // (horizontal < 0 && vertical < 0)
		{
			// Lower-left quadrant.
			if (theta <= 45.f)
				m_pPlayer->MoveWest(m_nCollisionState, velocity);
			else
				m_pPlayer->MoveSouth(m_nCollisionState, velocity);
		}
	}
}


void GameRenderer::DrawSpriteIntersection()
{
	D2D1_RECT_F rect
	{
		(float)intersectRect[0],
		(float)intersectRect[2],
		(float)intersectRect[1],
		(float)intersectRect[3]
	};


	if (m_nCollisionState == INTERSECTION)
	{
		m_deviceResources->GetD2DDeviceContext()->FillRectangle(
			rect,
			m_deviceResources->m_yellowBrush.Get());
	}
	else if (m_nCollisionState == COLLISION)
	{
		m_deviceResources->GetD2DDeviceContext()->FillRectangle(
			rect,
			m_deviceResources->m_greenBrush.Get());
	}
}

void GameRenderer::HighlightSprite(int * pLocation, ComPtr<ID2D1SolidColorBrush> brush)
{
	if (pLocation)
		HighlightSprite(
			pLocation[HORIZONTAL_AXIS],
			pLocation[VERTICAL_AXIS], brush);
}

/*
Highlight the sprite that is being collided with.
*/
void GameRenderer::HighlightSprite(int column, int row, ComPtr<ID2D1SolidColorBrush> brush)
{
	float x = 0.0f;
	float y = 0.0f;

	ScreenUtils::CalculateSquareCenter(
		m_fWindowWidth,
		m_fWindowHeight,
		column,
		row,
		&x,
		&y);

	x *= m_fWindowWidth;
	y *= m_fWindowHeight;
	
	float gameAreaWidth =
		m_fWindowWidth -
		(m_fWindowWidth * LEFT_MARGIN_RATIO) -
		(m_fWindowWidth * RIGHT_MARGIN_RATIO);

	float gameAreaHeight = m_fWindowHeight;

	D2D1_RECT_F rect
	{
		x - (gameAreaWidth / (float)NUM_GRID_COLUMNS) / 2.0f,
		y - m_fWindowHeight / (float)NUM_GRID_ROWS / 2.0f,
		x + (gameAreaWidth / (float)NUM_GRID_COLUMNS) / 2.0f,
		y + m_fWindowHeight / (float)NUM_GRID_ROWS / 2.0f
	};


	m_deviceResources->GetD2DDeviceContext()->FillRectangle(
		rect,
		brush.Get());
}

void GameRenderer::OnKeyDown(Windows::UI::Core::KeyEventArgs^ args)
{
	if (args->VirtualKey == Windows::System::VirtualKey::P)       // Pause
	{
	}

	if (args->VirtualKey == Windows::System::VirtualKey::Left)
	{
		m_pPlayer->MoveWest(m_nCollisionState, PLAYER_MOVE_VELOCITY);
	}
	else if (args->VirtualKey == Windows::System::VirtualKey::Down)
	{
		m_pPlayer->MoveSouth(m_nCollisionState, PLAYER_MOVE_VELOCITY);
	}
	else if (args->VirtualKey == Windows::System::VirtualKey::Right)
	{
		m_pPlayer->MoveEast(m_nCollisionState, PLAYER_MOVE_VELOCITY);
	}
	else if (args->VirtualKey == Windows::System::VirtualKey::Up)
	{
		m_pPlayer->MoveNorth(m_nCollisionState, PLAYER_MOVE_VELOCITY);
	}
}


void GameRenderer::OnSizeChanged(WindowSizeChangedEventArgs^ args)
{
	//UpdateForWindowSizeChange();

	//grid.SetWindowWidth(m_window->Bounds.Width);
	//grid.SetWindowHeight(m_window->Bounds.Height);

	//BuildScreen();
}


void GameRenderer::DrawLeftMargin()
{
	LeftMargin leftMargin;

	D2D1_RECT_F rect
	{
		0.0f,
		0.0f,
		m_fWindowWidth * LEFT_MARGIN_RATIO,
		m_fWindowHeight
	};

	leftMargin.Draw(
		DEVICE_CONTEXT_2D,
		m_deviceResources->m_blackBrush.Get(),
		rect);
}

void GameRenderer::DrawRightMargin()
{
	RightMargin rightMargin;

	D2D1_RECT_F rect
	{
		m_fWindowWidth - (m_fWindowWidth * RIGHT_MARGIN_RATIO),
		0.0f,
		m_fWindowWidth,
		m_fWindowHeight
	};

	rightMargin.Draw(
		DEVICE_CONTEXT_2D,
		m_deviceResources->m_blackBrush.Get(),
		rect);
}

void GameRenderer::DrawLifeText()
{
	D2D1_SIZE_F size = DEVICE_CONTEXT_2D->GetSize();

	float fTop = size.height * 0.01f;
	float fLeft = size.width - (size.width * RIGHT_MARGIN_RATIO);

	DEVICE_CONTEXT_2D->DrawTextLayout(
		D2D1::Point2F(fLeft, fTop),
		m_textLayoutLife.Get(),
		m_deviceResources->m_whiteBrush.Get()
		);
}

void GameRenderer::DrawButtonsText()
{
	D2D1_SIZE_F size = DEVICE_CONTEXT_2D->GetSize();

	float fTop = size.height / 3.0f;
	float fLeft = size.width - (size.width * RIGHT_MARGIN_RATIO);

	DEVICE_CONTEXT_2D->DrawTextLayout(
		D2D1::Point2F(fLeft, fTop),
		m_textLayoutButtons.Get(),
		m_deviceResources->m_whiteBrush.Get()
		);
}

void GameRenderer::DrawMapText()
{
	D2D1_SIZE_F size = DEVICE_CONTEXT_2D->GetSize();

	float fTop = size.height * 0.01f;
	float fLeft = 0.0f;// size.width - (size.width * LEFT_MARGIN_RATIO);

	DEVICE_CONTEXT_2D->DrawTextLayout(
		D2D1::Point2F(fLeft, fTop),
		m_textLayoutMap.Get(),
		m_deviceResources->m_whiteBrush.Get()
		);
}
void GameRenderer::DrawInventoryText()
{
	D2D1_SIZE_F size = DEVICE_CONTEXT_2D->GetSize();

	float fTop = size.height / 3.0f;
	float fLeft = 0.0f;

	DEVICE_CONTEXT_2D->DrawTextLayout(
		D2D1::Point2F(fLeft, fTop),
		m_textLayoutInventory.Get(),
		m_deviceResources->m_whiteBrush.Get()
		);
}

void GameRenderer::DrawPackText()
{
	D2D1_SIZE_F size = DEVICE_CONTEXT_2D->GetSize();

	float fTop = size.height / 3.0f * 2.0f;
	float fLeft = 0.0f; // size.width - (size.width * LEFT_MARGIN_RATIO);

	DEVICE_CONTEXT_2D->DrawTextLayout(
		D2D1::Point2F(fLeft, fTop),
		m_textLayoutPack.Get(),
		m_deviceResources->m_whiteBrush.Get()
		);
}

void GameRenderer::CreateLifeText()
{
	Platform::String ^ text = "Life";

	D2D1_SIZE_F size = DEVICE_CONTEXT_2D->GetSize();
	size.height = size.height / 3.0f;
	size.width = size.width * RIGHT_MARGIN_RATIO;

	ComPtr<IDWriteTextLayout> textLayout;

	DX::ThrowIfFailed(
		m_deviceResources->m_dwriteFactory->CreateTextLayout(
			text->Data(),
			text->Length(),
			m_textFormat.Get(),
			size.width,
			size.height,
			&textLayout
			)
		);

	textLayout.As(&m_textLayoutLife);

	m_textRange.startPosition = 0;
	m_textRange.length = text->Length();
	m_textLayoutLife->SetFontSize(SECTION_HEADER_FONT_SIZE, m_textRange);
	m_textLayoutLife->SetCharacterSpacing(0.5f, 0.5f, 0, m_textRange);
	m_textLayoutLife->SetTextAlignment(DWRITE_TEXT_ALIGNMENT_CENTER);
}


void GameRenderer::CreateMapText()
{
	Platform::String ^ text = "Map";

	D2D1_SIZE_F size = DEVICE_CONTEXT_2D->GetSize();
	size.height = size.height / 3.0f;
	size.width = size.width * LEFT_MARGIN_RATIO;

	ComPtr<IDWriteTextLayout> textLayout;

	DX::ThrowIfFailed(
		m_deviceResources->m_dwriteFactory->CreateTextLayout(
			text->Data(),
			text->Length(),
			m_textFormat.Get(),
			size.width,
			size.height,
			&textLayout
			)
		);

	textLayout.As(&m_textLayoutMap);

	m_textRange.startPosition = 0;
	m_textRange.length = text->Length();
	m_textLayoutMap->SetFontSize(SECTION_HEADER_FONT_SIZE, m_textRange);
	m_textLayoutMap->SetCharacterSpacing(0.5f, 0.5f, 0, m_textRange);
	m_textLayoutMap->SetTextAlignment(DWRITE_TEXT_ALIGNMENT_CENTER);
}

void GameRenderer::CreateButtonsText()
{
	Platform::String ^ text = "Buttons";

	D2D1_SIZE_F size = DEVICE_CONTEXT_2D->GetSize();
	size.height = size.height / 3.0f;
	size.width = size.width * RIGHT_MARGIN_RATIO;

	ComPtr<IDWriteTextLayout> textLayout;

	DX::ThrowIfFailed(
		m_deviceResources->m_dwriteFactory->CreateTextLayout(
			text->Data(),
			text->Length(),
			m_textFormat.Get(),
			size.width,
			size.height,
			&textLayout
			)
		);

	textLayout.As(&m_textLayoutButtons);

	m_textRange.startPosition = 0;
	m_textRange.length = text->Length();
	m_textLayoutButtons->SetFontSize(SECTION_HEADER_FONT_SIZE, m_textRange);
	m_textLayoutButtons->SetCharacterSpacing(0.5f, 0.5f, 0, m_textRange);
	m_textLayoutButtons->SetTextAlignment(DWRITE_TEXT_ALIGNMENT_CENTER);
}

void GameRenderer::CreateInventoryText()
{
	Platform::String ^ text = "Inventory";

	D2D1_SIZE_F size = DEVICE_CONTEXT_2D->GetSize();
	size.height = size.height / 3.0f;
	size.width = size.width * LEFT_MARGIN_RATIO;

	ComPtr<IDWriteTextLayout> textLayout;

	DX::ThrowIfFailed(
		m_deviceResources->m_dwriteFactory->CreateTextLayout(
			text->Data(),
			text->Length(),
			m_textFormat.Get(),
			size.width,
			size.height,
			&textLayout
			)
		);

	textLayout.As(&m_textLayoutInventory);

	m_textRange.startPosition = 0;
	m_textRange.length = text->Length();
	m_textLayoutInventory->SetFontSize(SECTION_HEADER_FONT_SIZE, m_textRange);
	m_textLayoutInventory->SetCharacterSpacing(0.5f, 0.5f, 0, m_textRange);
	m_textLayoutInventory->SetTextAlignment(DWRITE_TEXT_ALIGNMENT_CENTER);
}

void GameRenderer::CreatePackText()
{
	Platform::String ^ text = "Pack";

	D2D1_SIZE_F size = DEVICE_CONTEXT_2D->GetSize();
	size.height = size.height / 3.0f;
	size.width = size.width * RIGHT_MARGIN_RATIO;

	ComPtr<IDWriteTextLayout> textLayout;

	DX::ThrowIfFailed(
		m_deviceResources->m_dwriteFactory->CreateTextLayout(
			text->Data(),
			text->Length(),
			m_textFormat.Get(),
			size.width,
			size.height,
			&textLayout
			)
		);

	textLayout.As(&m_textLayoutPack);

	m_textRange.startPosition = 0;
	m_textRange.length = text->Length();
	m_textLayoutPack->SetFontSize(SECTION_HEADER_FONT_SIZE, m_textRange);
	m_textLayoutPack->SetCharacterSpacing(0.5f, 0.5f, 0, m_textRange);
	m_textLayoutPack->SetTextAlignment(DWRITE_TEXT_ALIGNMENT_CENTER);
}

