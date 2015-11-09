#pragma once
#include "Space.h"

using namespace std;

class Layer
{
public:
	Layer() { m_spaces = new vector<Space *>(); }
	void Add(Space * space) { m_spaces->push_back(space); }
	vector<Space *> * GetSpaces() { return m_spaces; }
	void Clear() { m_spaces->clear(); }

protected:

private:
	vector<Space *> * m_spaces;
};
