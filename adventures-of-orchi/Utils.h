#pragma once
#include "pch.h"
#include "Grid.h"
#include "Constants.h"

static void ConvertRatioToGridLocations(Grid grid, float2 fLocationRatio, int * column, int * row)
{
	int horizontalUnits =
		(int)(1.0f / (float)grid.GetNumColumns() * (float)TOTAL_GRID_DIVISIONS);

	int verticalUnits =
		(int)(1.0f / (float)grid.GetNumRows() * (float)TOTAL_GRID_DIVISIONS);

	int nHorizontalLocation =
		(int)(fLocationRatio.x * TOTAL_GRID_DIVISIONS) / horizontalUnits;

	int nVerticalLocation =
		(int)(fLocationRatio.y * TOTAL_GRID_DIVISIONS) / verticalUnits;

	*column = nHorizontalLocation;
	*row = nVerticalLocation;
}
