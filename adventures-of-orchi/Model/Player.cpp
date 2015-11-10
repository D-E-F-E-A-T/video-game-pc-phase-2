#include "pch.h"
#include "Player.h"
#include "..\Constants.h"
#include "..\ScreenUtils.h"


void Player::MoveNorth(int nCollisionState, float fVelocity)
{
	if (nCollisionState == COLLISION && m_nPreviousMoveDirection == NORTH)
	{
	}
	else
	{
		float prospectiveVerticalRatio =
			m_fLocationRatio.y -= fVelocity;

		// Don't go above the top of the screen. 
		//	Later this will be the trigger to move to the next screen.
		if (prospectiveVerticalRatio >= 0.f)
			m_fLocationRatio.y = prospectiveVerticalRatio;
		else
			m_fLocationRatio.y = 0.0f;
	}

	m_nPreviousMoveDirection = NORTH;
}

void Player::MoveEast(int nCollisionState, float fVelocity)
{
	if (nCollisionState == COLLISION && m_nPreviousMoveDirection == EAST)
	{
	}
	else
	{
		float prospectiveHorizontalRatio =
			m_fLocationRatio.x += fVelocity;

		if (prospectiveHorizontalRatio <= 1.0f)
		{
			m_fLocationRatio.x = prospectiveHorizontalRatio;
		}
		else
		{
			m_fLocationRatio.x = 1.0f;
		}
	}

	m_nPreviousMoveDirection = EAST;
}

void Player::MoveSouth(int nCollisionState, float fVelocity)
{
	if (nCollisionState == COLLISION && m_nPreviousMoveDirection == SOUTH)
	{
	}
	else
	{
		float prospectiveVerticalOffset =
			m_fLocationRatio.y += fVelocity;

		// Don't go above the top of the screen. 
		//	Later this will be the trigger to move to the next screen.
		if (prospectiveVerticalOffset <= 1.0f)
			m_fLocationRatio.y = prospectiveVerticalOffset;
		else
			m_fLocationRatio.y = 1.0f;
	}

	m_nPreviousMoveDirection = SOUTH;
}

void Player::MoveWest(int nCollisionState, float fVelocity)
{
	if (nCollisionState == COLLISION && m_nPreviousMoveDirection == WEST)
	{
	}
	else
	{
		float prospectiveHorizontalOffset =
			m_fLocationRatio.x -= fVelocity;

		if (prospectiveHorizontalOffset >= 0.f)
		{
			m_fLocationRatio.x = prospectiveHorizontalOffset;
		}
		else
		{
			m_fLocationRatio.x = 0.f;
		}
	}

	m_nPreviousMoveDirection = WEST;
}


void Player::SkipNorth()
{
	m_fLocationRatio = float2{ m_fLocationRatio.x , 0.90f };
}

void Player::SkipEast()
{
	m_fLocationRatio = float2{ LEFT_MARGIN_RATIO + 0.1f, m_fLocationRatio.y };
}

void Player::SkipSouth()
{
	m_fLocationRatio = float2{ m_fLocationRatio.x, 0.1f };
}

void Player::SkipWest()
{
	m_fLocationRatio = float2{ 1.0f - RIGHT_MARGIN_RATIO - 0.1f, m_fLocationRatio.y };
}
