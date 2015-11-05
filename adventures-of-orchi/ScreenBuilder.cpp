#include "pch.h"
#include "ScreenBuilder.h"
#include "ScreenUtils.h"
#include "Constants.h"
#include "Model\Tree.h"

using namespace std;

ScreenBuilder::ScreenBuilder(float screenWidth, float screenHeight)
{
	m_fScreenWidth = screenWidth;
	m_fScreenHeight = screenHeight;
}

void ScreenBuilder::BuildScreen1(vector<Space *> * spaces, ID3D11Texture2D * tree)
{
	spaces->clear();

	float x = 0.0f;
	float y = 0.0f;

	for (int i = 0; i < 4; i++)
	{
		for (int j = 0; j < 7; j++)
		{
			ScreenUtils::CalculateSquareCenter(
				m_fScreenWidth,
				m_fScreenHeight,
				j, i, &x, &y);

			spaces->push_back(new Tree(
				float2(x, y),
				float2(0.f, 0.f),
				true,
				tree));
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

			spaces->push_back(new Tree(
				float2(x, y),
				float2(0.f, 0.f),
				true,
				tree));
		}
	}

	for (int i = 0; i < 5; i++)
	{
		ScreenUtils::CalculateSquareCenter(
			m_fScreenWidth,
			m_fScreenHeight, 
			i, 4, &x, &y);
		
		spaces->push_back(new Tree(
			float2(x, y),
			float2(0.f, 0.f),
			true,
			tree));
	}

	for (int i = 0; i < 4; i++)
	{
		ScreenUtils::CalculateSquareCenter(
			m_fScreenWidth,
			m_fScreenHeight, 
			i, 5, &x, &y);

		spaces->push_back(new Tree(
			float2(x, y),
			float2(0.f, 0.f),
			true,
			tree));
	}

	for (int i = 0; i < 3; i++)
	{
		ScreenUtils::CalculateSquareCenter(
			m_fScreenWidth,
			m_fScreenHeight, 
			i, 6, &x, &y);
		
		spaces->push_back(new Tree(
			float2(x, y),
			float2(0.f, 0.f),
			true,
			tree));
	}


	for (int i = 12; i < 17; i++)
	{
		ScreenUtils::CalculateSquareCenter(
			m_fScreenWidth,
			m_fScreenHeight, 
			i, 4, &x, &y);

		spaces->push_back(new Tree(
			float2(x, y),
			float2(0.f, 0.f),
			true,
			tree));
	}


	for (int i = 12; i < 17; i++)
	{
		ScreenUtils::CalculateSquareCenter(
			m_fScreenWidth,
			m_fScreenHeight, 
			i, 9, &x, &y);

		spaces->push_back(new Tree(
			float2(x, y),
			float2(0.f, 0.f),
			true,
			tree));
	}

	
	for (int i = 0; i < 6; i++)
	{
		ScreenUtils::CalculateSquareCenter(
			m_fScreenWidth,
			m_fScreenHeight, 
			i, 10, &x, &y);

		spaces->push_back(new Tree(
			float2(x, y),
			float2(0.f, 0.f),
			true,
			tree));
	}


	for (int i = 11; i < 17; i++)
	{
		ScreenUtils::CalculateSquareCenter(
			m_fScreenWidth,
			m_fScreenHeight, 
			i, 10, &x, &y);

		spaces->push_back(new Tree(
			float2(x, y),
			float2(0.f, 0.f),
			true,
			tree));
	}


	for (int i = 11; i < 17; i++)
	{
		for (int j = 11; j < 15; j++)
		{
			ScreenUtils::CalculateSquareCenter(
				m_fScreenWidth,
				m_fScreenHeight,
				i, j, &x, &y);

			spaces->push_back(new Tree(
				float2(x, y),
				float2(0.f, 0.f),
				true,
				tree));
		}
	}


	for (int i = 0; i < 7; i++)
	{
		ScreenUtils::CalculateSquareCenter(
			m_fScreenWidth,
			m_fScreenHeight, 
			i, 11, &x, &y);

		spaces->push_back(new Tree(
			float2(x, y),
			float2(0.f, 0.f),
			true,
			tree));
	}

	for (int i = 0; i < 8; i++)
	{
		for (int j = 12; j < 15; j++)
		{
			ScreenUtils::CalculateSquareCenter(
				m_fScreenWidth,
				m_fScreenHeight,
				i, j, &x, &y);

			spaces->push_back(new Tree(
				float2(x, y),
				float2(0.f, 0.f),
				true,
				tree));
		}
	}

	//spaces->push_back(new Portal(0, 7, WEST, 2));
	//portals->push_back(new Portal(0, 8, WEST, 2));
	//portals->push_back(new Portal(0, 9, WEST, 2));

	//portals->push_back(new Portal(7, 0, NORTH, 3));
	//portals->push_back(new Portal(8, 0, NORTH, 3));
	//portals->push_back(new Portal(9, 0, NORTH, 3));
	//portals->push_back(new Portal(10, 0, NORTH, 3));

	//portals->push_back(new Portal(16, 5, EAST, 4));
	//portals->push_back(new Portal(16, 6, EAST, 4));
	//portals->push_back(new Portal(16, 7, EAST, 4));
	//portals->push_back(new Portal(16, 8, EAST, 4));

	//portals->push_back(new Portal(8, 14, SOUTH, 5));
	//portals->push_back(new Portal(9, 14, SOUTH, 5));
	//portals->push_back(new Portal(10, 14, SOUTH, 5));

}