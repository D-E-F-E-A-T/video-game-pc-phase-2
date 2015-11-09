#include "pch.h"
#include "ScreenUtils.h"
#include "Constants.h"

// To easily allow for resizing, this should return ratios.
// The return values are relative to the entire screen.
//	Thus, 0.f = left edge of the screen.
//			1.f = right edge of the screen.
void ScreenUtils::CalculateSquareCenter(
	float screenWidth,
	float screenHeight,
	int column,
	int row,
	float * x,
	float * y)
{
	float gridWidth = screenWidth -
		(screenWidth * LEFT_MARGIN_RATIO) -
		(screenWidth * RIGHT_MARGIN_RATIO);

	float rowHeight = (screenHeight - 2.0f * MARGIN) / NUM_GRID_ROWS;
	float columnWidth = (gridWidth - 2.0f * MARGIN) / NUM_GRID_COLUMNS;

	*x = (screenWidth * LEFT_MARGIN_RATIO) + MARGIN + (columnWidth * column) + (columnWidth / 2.0f);
	*y = MARGIN + (rowHeight * row) + (rowHeight / 2.0f);

	*x /= screenWidth;
	*y /= screenHeight;
}

void ScreenUtils::ConvertGlobalToGridLocation(
	float2 globalPt,
	float * x,
	float * y)
{
	// globalPt.x is relative then entire width of the screen.
	//	Need to subtract the left margin before converting to 
	//	the correct Grid location.
	*x = (globalPt.x - LEFT_MARGIN_RATIO) / (1.0f - LEFT_MARGIN_RATIO - RIGHT_MARGIN_RATIO);
	*y = globalPt.y;
}