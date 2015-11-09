#include "pch.h"
#include "World.h"
#include "ScreenUtils.h"
#include "Model\Tree.h"
#include "Model\Portal.h"

using namespace Windows::Foundation::Collections;
using namespace std;

World::World()
{
	m_pStack = new Stack();
}

World::~World()
{

}

void World::Build(float2 fScreenDimensions, const shared_ptr<DeviceResources>& deviceResources)
{
	ServiceProxy::ServiceProxy ^ proxy = ref new ServiceProxy::ServiceProxy();

	IIterable<ServiceProxy::WorldBuilderCommand ^> ^ commands = proxy->Build();

	for each (ServiceProxy::WorldBuilderCommand ^ command in commands)
	{
		float x;
		float y;

		ScreenUtils::CalculateSquareCenter(
			fScreenDimensions.x,
			fScreenDimensions.y,
			command->X, 
			command->Y, 
			&x, 
			&y);

		if (command->Type == 1)
		{
			m_pStack->Add(LAYER_COLLIDABLES, new Tree(
				float2(x, y),
				float2(1.f, 1.f),
				true,
				deviceResources));
		}
		else if (command->Type == 0)
		{
			m_pStack->Add(LAYER_2D, new Portal(
				float2(x, y),
				float2(1.f, 1.f),
				((ServiceProxy::AddPortalCommand ^)command)->Direction,
				((ServiceProxy::AddPortalCommand ^)command)->Destination,
				deviceResources));
		}

	}
}

Stack * World::LoadScreen(int x, int y)
{
	return m_pStack;
}

void World::GetDimensions(int * x, int * y)
{

}