#pragma once
#include "Plane.h"

class Stack
{
public:
	Stack();

	void Add(int depth, Space * space);
	Plane * Get(int depth);
	int GetNumPlanes() { return m_planes.size(); }


protected:

private:
	map<int, Plane *> m_planes;
};
