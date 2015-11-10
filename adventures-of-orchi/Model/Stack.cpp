#include "pch.h"
#include "Stack.h"
#include "..\Constants.h"

Stack::Stack()
{
	for (int i = 0; i < NUM_LAYERS; i++)
	{
		m_layers[i] = new Layer();
	}
}

void Stack::Add(int depth, Space * space)
{
	if (depth == LAYER_PLAYERS)
	{
		if (m_layers[depth]->GetSpaces()->size() > 0)
		{
			return;
		}
	}

	Layer * layer = m_layers[depth];

	m_layers[depth]->Add(space);
}

Layer * Stack::Get(int depth)
{
	return m_layers[depth];
}

void Stack::Clear()
{
	for (int i = LAYER_MOVABLES; i < NUM_LAYERS; i++)
	{
		m_layers[i]->Clear();
	}
}