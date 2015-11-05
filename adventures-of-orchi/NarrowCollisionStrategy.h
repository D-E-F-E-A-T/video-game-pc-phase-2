#pragma once
#include "pch.h"

#include "Model\Player.h"
#include "GridSpace.h"
#include <list>


class NarrowCollisionStrategy
{
public:
	NarrowCollisionStrategy();
	~NarrowCollisionStrategy();

	int Detect(
		ID3D11DeviceContext2 * context,
		ID3D11Device2 * device,
		ID3D11Texture2D * texture1,
		ID3D11Texture2D * texture2,
		Player * pPlayer,
		std::list<Space *> * sprites,
		float * playerLocation,
		Grid * grid,
		int * intersectRect,
		float2 screenDimensions);

protected:
private:

	uint8_t * readPixels(
		ID3D11DeviceContext2 * context,
		ID3D11Device2 * device,
		ID3D11Texture2D * texture,
		int * dimensions);

	bool IntersectRect(
		int * playerTopLeft,
		int * obstacleTopLeft,
		int width,
		int height,
		int * retVal);

	void InsertionSort(int values[], int length);

	void DumpPixels(int width, int height, uint8_t * data);
};