#include "pch.h"
#include "World.h"
#include "ScreenUtils.h"
#include "Model\Tree.h"
#include "Model\Portal.h"
#include "Model\Water.h"

using namespace Windows::Foundation::Collections;
using namespace std;

World::World()
{
	m_lpStacks = nullptr;
	m_nCurrentStackIndex = 0;
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


		if (command->Type == DECLARE_WORLD_COMMAND)
		{
			int nWidth = ((ServiceProxy::DeclareWorldCommand ^)command)->Width;
			int nHeight = ((ServiceProxy::DeclareWorldCommand ^)command)->Height;

			m_lpStacks = new Stack[nWidth * nHeight];

			m_lpnDimensions[WIDTH_INDEX] = nWidth;
			m_lpnDimensions[HEIGHT_INDEX] = nHeight;

		}
		else if (command->Type == DECLARE_SCREEN_COMMAND)
		{
			int x = ((ServiceProxy::DeclareScreenCommand ^)command)->X;
			int y = ((ServiceProxy::DeclareScreenCommand ^)command)->Y;

			m_nCurrentStackIndex = y * m_lpnDimensions[WIDTH_INDEX] + x;
		}
		if (command->Type == ADD_TREE_COMMAND)
		{
			ScreenUtils::CalculateSquareCenter(
				fScreenDimensions.x,
				fScreenDimensions.y,
				((ServiceProxy::AddTreeCommand ^)command)->X,
				((ServiceProxy::AddTreeCommand ^)command)->Y,
				&x,
				&y);

			(m_lpStacks + m_nCurrentStackIndex)->Add(LAYER_COLLIDABLES, new Tree(
				float2(x, y),
				float2(1.f, 1.f),
				true,
				deviceResources));
		}
		else if (command->Type == ADD_PORTAL_COMMAND)
		{
			ScreenUtils::CalculateSquareCenter(
				fScreenDimensions.x,
				fScreenDimensions.y,
				((ServiceProxy::AddPortalCommand ^)command)->X,
				((ServiceProxy::AddPortalCommand ^)command)->Y,
				&x,
				&y);

			(m_lpStacks + m_nCurrentStackIndex)->Add(LAYER_2D, new Portal(
				float2(x, y),
				float2(0.2f, 0.2f),
				((ServiceProxy::AddPortalCommand ^)command)->Direction,
				((ServiceProxy::AddPortalCommand ^)command)->Destination,
				deviceResources));
		}
		if (command->Type == ADD_WATER_COMMAND)
		{
			ScreenUtils::CalculateSquareCenter(
				fScreenDimensions.x,
				fScreenDimensions.y,
				((ServiceProxy::AddWaterCommand ^)command)->X,
				((ServiceProxy::AddWaterCommand ^)command)->Y,
				&x,
				&y);

			(m_lpStacks + m_nCurrentStackIndex)->Add(LAYER_COLLIDABLES, new Water(
				float2(x, y),
				float2(1.f, 1.f),
				true,
				deviceResources));
		}
	}
}

void World::SetScreen(int x, int y)
{
	m_nCurrentStackIndex = y * m_lpnDimensions[WIDTH_INDEX] + x;
}

Stack * World::LoadScreen(int x, int y)
{
	return m_lpStacks + (y * m_lpnDimensions[WIDTH_INDEX] + x);
}

Stack * World::Move(int nDirection)
{
	int nColumn = m_nCurrentStackIndex % m_lpnDimensions[WIDTH_INDEX];
	int nRow = m_nCurrentStackIndex / m_lpnDimensions[WIDTH_INDEX];

	if (nDirection == NORTH)
	{
		nRow -= 1;
	}
	else if (nDirection == EAST)
	{
		nColumn += 1;
	}
	else if (nDirection == SOUTH)
	{
		nRow += 1;
	}
	else if (nDirection == WEST)
	{
		nColumn -= 1;
	}

	return LoadScreen(nColumn, nRow);
}