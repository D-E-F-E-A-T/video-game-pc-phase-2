#pragma once
#include "pch.h"


// TODO: This will be merged into the Space class.
class BaseSpriteData
{
public:
	int row;
	int column;
	float2 pos;
	float2 vel;
	float rot;
	float rotVel;
	float scale;
	bool bCollidable;

	BaseSpriteData(int column, int row, float x, float y)
	{
		this->column = column;
		this->row = row;
		this->pos.x = x;
		this->pos.y = y;

		this->rot = 0.0f;
		this->scale = 1.0f;
		this->rotVel = 0.0f;
	}

protected:

private:

};