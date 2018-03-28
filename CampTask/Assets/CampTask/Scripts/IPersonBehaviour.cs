using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IPersonBehaviour {


	void AddPerson (Person person);
	
	// void OnActionStart ();
	// void OnActionEnd ();
	void UpdateAction (UInt64 subAction);
}
