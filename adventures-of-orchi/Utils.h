#pragma once
#include "pch.h"
#include "Grid.h"
#include "Constants.h"

using namespace std;

static void ConvertRatioToGridLocations(Grid grid, float2 fLocationRatio, int * column, int * row)
{
	float fHorizontalUnits =
		(float)TOTAL_GRID_DIVISIONS / (float)grid.GetNumColumns();

	float fVerticalUnits =
		(float)TOTAL_GRID_DIVISIONS / (float)grid.GetNumRows();

	int nHorizontalLocation =
		(int)(fLocationRatio.x * (float)TOTAL_GRID_DIVISIONS) / fHorizontalUnits;

	int nVerticalLocation =
		(int)(fLocationRatio.y * (float)TOTAL_GRID_DIVISIONS) / fVerticalUnits;

	*column = nHorizontalLocation;
	*row = nVerticalLocation;
}

static void InsertionSortI(int values[], int length)
{
	int j, temp;

	for (int i = 0; i < length; i++)
	{
		j = i;

		while (j > 0 && values[j] < values[j - 1])
		{
			temp = values[j];
			values[j] = values[j - 1];
			values[j - 1] = temp;
			j--;
		}
	}
}

static void InsertionSortF(float values[], int length)
{
	int j, temp;

	for (int i = 0; i < length; i++)
	{
		j = i;

		while (j > 0 && values[j] < values[j - 1])
		{
			temp = values[j];
			values[j] = values[j - 1];
			values[j - 1] = temp;
			j--;
		}
	}
}

static float GetMaxValue(vector<float> values, int * index)
{
	float retVal = -99999999.f;

	vector<float>::const_iterator iterator;
	int counter = 0;

	for (iterator = values.begin(); iterator != values.end(); iterator++)
	{
		if ((*iterator) > retVal)
		{
			retVal = *iterator;
			*index = counter;
		}

		counter++;
	}

	return retVal;
}
