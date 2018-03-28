using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputManager : MonoBehaviour {

	int m_upperbit = 54;

	// 基本action 下位 54bit
	enum PersonAction{
		Run,

		Walk,

		Move,

		Squat,

		Lie
	}


	// 上位10bit 
	enum Direction {
		Right,
		Left,
		Fowford,
		Back,


	}


	//m_personAction = 1 << Run;
	UInt64     m_personAction;

	UInt64 GetPersonAction(){ return m_personAction; }

	//PlayerInfo GetPersonnfo(){ return ; }





	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.LeftShift))
		{

			m_personAction |= 1 << (int)PersonAction.Run;
			if( Input.GetKey(KeyCode.UpArrow))
			{
				m_personAction = m_personAction | 1 << ( (int)Direction.Fowford + 54);
			}
			if( Input.GetKey(KeyCode.RightArrow) )
			{
				m_personAction = m_personAction | 1 << ( (int)Direction.Right + 54);
			}
			if(Input.GetKey(KeyCode.LeftArrow))
			{
				m_personAction = m_personAction | 1 << ( (int)Direction.Left + 54);
			}
			if(Input.GetKey(KeyCode.DownArrow))
			{
				m_personAction = m_personAction | 1 << ( (int)Direction.Back + 54);
			}	

		}
		else 
		{
			
			if( Input.GetKey(KeyCode.UpArrow))
			{
				m_personAction |= 1 << (int)PersonAction.Walk;
				m_personAction = m_personAction | 1 << ( (int)Direction.Fowford + 54);
			}
			if( Input.GetKey(KeyCode.RightArrow) )
			{
				m_personAction |= 1 << (int)PersonAction.Walk;
				m_personAction = m_personAction | 1 << ( (int)Direction.Right + 54);
			}
			if(Input.GetKey(KeyCode.LeftArrow))
			{
				m_personAction |= 1 << (int)PersonAction.Walk;
				m_personAction = m_personAction | 1 << ( (int)Direction.Left + 54);
			}
			if(Input.GetKey(KeyCode.DownArrow))
			{
				m_personAction |= 1 << (int)PersonAction.Walk;
				m_personAction = m_personAction | 1 << ( (int)Direction.Back + 54);
			}	
		}
		
		if( Input.GetKeyDown(KeyCode.C))
		{
			m_personAction |= 1 << (int)PersonAction.Squat;
		}
		if( Input.GetKeyDown(KeyCode.Z) )
		{
			m_personAction |= 1<< (int)PersonAction.Lie;
		}
	}
}
