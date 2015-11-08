#pragma once
#include "Space.h"

using namespace std;

class Plane
{
public:
	Plane() { m_spaces = new vector<Space *>(); }
	void Add(Space * space) { m_spaces->push_back(space); }
	vector<Space *> * GetSpaces() { return m_spaces; }

protected:

private:
	vector<Space *> * m_spaces;
};
