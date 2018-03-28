using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputManager : MonoBehaviour {

	int m_upperbit = 54;

	static InputManager _InputManager =null;

	public static InputManager GetInstance(){
		return _InputManager;
	} 
	// 基本action 下位 54bit
	public enum PersonAction{
		Run,

		Walk,

		Move,

		Squat,

		Lie
	}


	// 上位10bit 
	public enum Direction {
		Right,
		Left,
		Fowford,
		Back,


	}


	//m_personAction = 1 << Run;
	UInt64     m_personAction;
	UInt32     m_personActionIndex;

	UInt64 GetPersonAction(){ return m_personAction; }

	//PlayerInfo GetPersonnfo(){ return ; }
	UInt32 GetAction()
	{
		UInt32 ret = 0;
		//if()

		return ret;
	}


	//
	void Awake()
	{
		_InputManager = this;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.LeftShift))
		{

			m_personAction = (int)PersonAction.Run;
			if( Input.GetKey(KeyCode.UpArrow))
			{
				m_personAction = m_personAction | ( (int)Direction.Fowford << 54 );
			}
			if( Input.GetKey(KeyCode.RightArrow) )
			{
				m_personAction = m_personAction | ( (int)Direction.Right << 54);
			}
			if(Input.GetKey(KeyCode.LeftArrow))
			{
				m_personAction = m_personAction | ( (int)Direction.Left << 54);
			}
			if(Input.GetKey(KeyCode.DownArrow))
			{
				m_personAction = m_personAction | ( (int)Direction.Back << 54);
			}	

		}
		else 
		{
			
			if( Input.GetKey(KeyCode.UpArrow))
			{
				m_personAction = (int)PersonAction.Walk;
				m_personAction = m_personAction | ( (int)Direction.Fowford << 54);
			}
			if( Input.GetKey(KeyCode.RightArrow) )
			{
				m_personAction = (int)PersonAction.Walk;
				m_personAction = m_personAction |  ( (int)Direction.Right << 54);
			}
			if(Input.GetKey(KeyCode.LeftArrow))
			{
				m_personAction = (int)PersonAction.Walk;
				m_personAction = m_personAction |  ( (int)Direction.Left << 54);
			}
			if(Input.GetKey(KeyCode.DownArrow))
			{
				m_personAction = (int)PersonAction.Walk;
				m_personAction = m_personAction |  ( (int)Direction.Back << 54);
			}	
		}
		
		if( Input.GetKeyDown(KeyCode.C))
		{
			m_personAction = (int)PersonAction.Squat;
		}
		if( Input.GetKeyDown(KeyCode.Z) )
		{
			m_personAction = (int)PersonAction.Lie;
		}
	}
}
