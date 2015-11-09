#include "pch.h"
#include "ScreenBuilder.h"
#include "ScreenUtils.h"
#include "Constants.h"
#include "Model\Tree.h"
#include "Model\Player.h"
#include "Model\Stack.h"

using namespace std;

ScreenBuilder::ScreenBuilder(float screenWidth, float screenHeight)
{
	m_fScreenWidth = screenWidth;
	m_fScreenHeight = screenHeight;
}

// TODO: Remove deviceResources from this function.
void ScreenBuilder::BuildScreen1(
	Stack * stack,
	const shared_ptr<DeviceResources>& deviceResources)
{
	float x = 0.0f;
	float y = 0.0f;

	stack->Clear();

	for (int i = 0; i < 4; i++)
	{
		for (int j = 0; j < 7; j++)
		{
			ScreenUtils::CalculateSquareCenter(
				m_fScreenWidth,
				m_fScreenHeight,
				j, i, &x, &y);

			stack->Add(LAYER_COLLIDABLES, new Tree(
				float2(x, y),
				float2(1.f, 1.f),
				true,
				deviceResources));
		}
	}

	for (int i = 0; i < 4; i++)
	{
		for (int j = 11; j < 17; j++)
		{
			ScreenUtils::CalculateSquareCenter(
				m_fScreenWidth,
				m_fScreenHeight,
				j, i, &x, &y);

			stack->Add(LAYER_COLLIDABLES, new Tree(
				float2(x, y),
				float2(1.f, 1.f),
				true,
				deviceResources));
		}
	}

	for (int i = 0; i < 5; i++)
	{
		ScreenUtils::CalculateSquareCenter(
			m_fScreenWidth,
			m_fScreenHeight, 
			i, 4, &x, &y);
		
		stack->Add(LAYER_COLLIDABLES, new Tree(
			float2(x, y),
			float2(1.f, 1.f),
			true,
			deviceResources));
	}

	for (int i = 0; i < 4; i++)
	{
		ScreenUtils::CalculateSquareCenter(
			m_fScreenWidth,
			m_fScreenHeight, 
			i, 5, &x, &y);

		stack->Add(LAYER_COLLIDABLES, new Tree(
			float2(x, y),
			float2(1.f, 1.f),
			true,
			deviceResources));
	}

	for (int i = 0; i < 3; i++)
	{
		ScreenUtils::CalculateSquareCenter(
			m_fScreenWidth,
			m_fScreenHeight, 
			i, 6, &x, &y);
		
		stack->Add(LAYER_COLLIDABLES, new Tree(
			float2(x, y),
			float2(1.f, 1.f),
			true,
			deviceResources));
	}


	for (int i = 12; i < 17; i++)
	{
		ScreenUtils::CalculateSquareCenter(
			m_fScreenWidth,
			m_fScreenHeight, 
			i, 4, &x, &y);

		stack->Add(LAYER_COLLIDABLES, new Tree(
			float2(x, y),
			float2(1.f, 1.f),
			true,
			deviceResources));
	}


	for (int i = 12; i < 17; i++)
	{
		ScreenUtils::CalculateSquareCenter(
			m_fScreenWidth,
			m_fScreenHeight, 
			i, 9, &x, &y);

		stack->Add(LAYER_COLLIDABLES, new Tree(
			float2(x, y),
			float2(1.f, 1.f),
			true,
			deviceResources));
	}

	
	for (int i = 0; i < 6; i++)
	{
		ScreenUtils::CalculateSquareCenter(
			m_fScreenWidth,
			m_fScreenHeight, 
			i, 10, &x, &y);

		stack->Add(LAYER_COLLIDABLES, new Tree(
			float2(x, y),
			float2(1.f, 1.f),
			true,
			deviceResources));
	}


	for (int i = 11; i < 17; i++)
	{
		ScreenUtils::CalculateSquareCenter(
			m_fScreenWidth,
			m_fScreenHeight, 
			i, 10, &x, &y);

		stack->Add(LAYER_COLLIDABLES, new Tree(
			float2(x, y),
			float2(1.f, 1.f),
			true,
			deviceResources));
	}


	for (int i = 11; i < 17; i++)
	{
		for (int j = 11; j < 15; j++)
		{
			ScreenUtils::CalculateSquareCenter(
				m_fScreenWidth,
				m_fScreenHeight,
				i, j, &x, &y);

			stack->Add(LAYER_COLLIDABLES, new Tree(
				float2(x, y),
				float2(1.f, 1.f),
				true,
				deviceResources));
		}
	}


	for (int i = 0; i < 7; i++)
	{
		ScreenUtils::CalculateSquareCenter(
			m_fScreenWidth,
			m_fScreenHeight, 
			i, 11, &x, &y);

		stack->Add(LAYER_COLLIDABLES, new Tree(
			float2(x, y),
			float2(1.f, 1.f),
			true,
			deviceResources));
	}

	for (int i = 0; i < 8; i++)
	{
		for (int j = 12; j < 15; j++)
		{
			ScreenUtils::CalculateSquareCenter(
				m_fScreenWidth,
				m_fScreenHeight,
				i, j, &x, &y);

			stack->Add(LAYER_COLLIDABLES, new Tree(
				float2(x, y),
				float2(1.f, 1.f),
				true,
				deviceResources));
		}
	}


	for (int i = 0; i < 3; i++)
	{
		ScreenUtils::CalculateSquareCenter(
			m_fScreenWidth,
			m_fScreenHeight,
			0, 7 + i, &x, &y);

		stack->Add(LAYER_2D, new Portal(
			float2(x, y),
			float2(1.f, 1.f),
			WEST,
			2,
			deviceResources));
	}

	for (int i = 0; i < 4; i++)
	{
		ScreenUtils::CalculateSquareCenter(
			m_fScreenWidth,
			m_fScreenHeight,
			7 + i, 0, &x, &y);

		stack->Add(LAYER_2D, new Portal(
			float2(x, y),
			float2(1.f, 1.f),
			NORTH,
			3,
			deviceResources));
	}

	for (int i = 0; i < 4; i++)
	{
		ScreenUtils::CalculateSquareCenter(
			m_fScreenWidth,
			m_fScreenHeight,
			16, 5 + i, &x, &y);

		stack->Add(LAYER_2D, new Portal(
			float2(x, y),
			float2(1.f, 1.f),
			EAST,
			4,
			deviceResources));
	}

	for (int i = 0; i < 3; i++)
	{
		ScreenUtils::CalculateSquareCenter(
			m_fScreenWidth,
			m_fScreenHeight,
			8 + i, 14, &x, &y);

		stack->Add(LAYER_2D, new Portal(
			float2(x, y),
			float2(1.f, 1.f),
			SOUTH,
			5,
			deviceResources));
	}
}

void ScreenBuilder::BuildScreen2(
	Stack * stack,
	const shared_ptr<DeviceResources>& deviceResources)
{
	float x = 0.0f;
	float y = 0.0f;

	stack->Clear();

	for (int i = 0; i < 4; i++)
	{
		for (int j = 0; j < 7; j++)
		{
			ScreenUtils::CalculateSquareCenter(
				m_fScreenWidth,
				m_fScreenHeight,
				j, i, &x, &y);

			stack->Add(LAYER_COLLIDABLES, new Tree(
				float2(x, y),
				float2(1.f, 1.f),
				true,
				deviceResources));
		}
	}


}