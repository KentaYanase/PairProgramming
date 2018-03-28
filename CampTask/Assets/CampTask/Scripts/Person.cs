using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Person : MonoBehaviour 
{
	private List<IPersonBehaviour> _behaviourList;

	public Rigidbody CacheRigidbody {get; private set;}

	void Start () {
		CacheRigidbody = GetComponent<Rigidbody>();

		_behaviourList = new List<IPersonBehaviour>(8);

		_behaviourList.Add(new RunBehaviour());
		_behaviourList.Add(new WalkBehaviour());
		_behaviourList.Add(new SquadBehaviour());
		_behaviourList.Add(new LieBehaviour());

		foreach(var behvaiour in _behaviourList) {
			behvaiour.AddPerson(this);
		}
	}
	
	void Update () {

		UInt64 action = InputManager.GetInstance().GetPersonAction();

		UInt64 baseAction = action & 0xffff;
		UInt64 subAction = action >> 54;

		_behaviourList[(int)baseAction].UpdateAction(subAction); 
	}
}
