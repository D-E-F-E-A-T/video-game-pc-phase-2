#pragma once

#include "Common\StepTimer.h"
#include "Common\DeviceResources.h"
#include "Content\Sample3DSceneRenderer.h"
#include "Content\SampleFpsTextRenderer.h"
#include "Content\GameRenderer.h"

// Renders Direct2D and 3D content on the screen.
namespace adventures_of_orchi
{
	class adventures_of_orchiMain : public DX::IDeviceNotify
	{
	public:
		adventures_of_orchiMain(
			const std::shared_ptr<DX::DeviceResources>& deviceResources, CoreWindow ^ window);
		~adventures_of_orchiMain();
		void CreateWindowSizeDependentResources();
		void StartTracking() 
		{ 
			m_sceneRenderer->StartTracking(); 
			m_gameRenderer->StartTracking();

		}

		void TrackingUpdate(float positionX) { m_pointerLocationX = positionX; }
		void StopTracking() 
		{ 
			m_sceneRenderer->StopTracking(); 
			m_gameRenderer->StopTracking();
		}
		bool IsTracking() 
		{ 
			return /* m_sceneRenderer->IsTracking() && */ m_gameRenderer->IsTracking(); 
		}
		void StartRenderLoop();
		void StopRenderLoop();
		Concurrency::critical_section& GetCriticalSection() { return m_criticalSection; }

		// IDeviceNotify
		virtual void OnDeviceLost();
		virtual void OnDeviceRestored();

	private:
		void ProcessInput();
		void Update();
		bool Render();

		// Cached pointer to device resources.
		std::shared_ptr<DX::DeviceResources> m_deviceResources;

		// TODO: Replace with your own content renderers.
		std::unique_ptr<Sample3DSceneRenderer> m_sceneRenderer;
		std::unique_ptr<SampleFpsTextRenderer> m_fpsTextRenderer;
		std::unique_ptr<GameRenderer> m_gameRenderer;

		Windows::Foundation::IAsyncAction^ m_renderLoopWorker;
		Concurrency::critical_section m_criticalSection;

		// Rendering loop timer.
		DX::StepTimer m_timer;

		// Track current input pointer position.
		float m_pointerLocationX;
	};
}