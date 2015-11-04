#pragma once


	struct Portal
	{
		Portal(int nX, int nY, int nDirection, int nDestination)
		{
			m_nX = nX;
			m_nY = nY;

			m_nDirection = nDirection;
			m_nDestination = nDestination;
		}

		int m_nDirection;
		int m_nDestination;
		int m_nX;
		int m_nY;
	};