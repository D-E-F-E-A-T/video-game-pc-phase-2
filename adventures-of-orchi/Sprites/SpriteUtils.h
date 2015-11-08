#pragma once
#include "..\pch.h"

class SpriteUtils
{
public:
	static uint8_t * ReadPixels(
		ID3D11DeviceContext2 * context,
		ID3D11Device2 * device,
		ID3D11Texture2D * texture,
		int * dimensions);

protected:

private:
};
