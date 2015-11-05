#pragma once
#include "Thing.h"

class Tree : public Thing
{
public:
	Tree(
		float2 pfLocationRatio,
		float2 pfDimensions,
		bool bIsVisible,
		ID3D11Texture2D * treeData) :
		Thing(
			pfLocationRatio,
			pfDimensions,
			true,
			false,
			true,
			treeData)
	{

	}

protected:

private:
};