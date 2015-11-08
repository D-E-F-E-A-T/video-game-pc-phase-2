#include "pch.h"
#include "Stack.h"

Stack::Stack()
{

}

void Stack::Add(int depth, Space * space)
{
	Plane * plane = m_planes[depth];

	if (plane == nullptr)
	{
		m_planes[depth] = new Plane();
	}

	m_planes[depth]->Add(space);
}

Plane * Stack::Get(int depth)
{
	return m_planes[depth];
}