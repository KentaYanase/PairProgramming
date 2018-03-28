using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SquadBehaviour : IPersonBehaviour
{
	private Person _person;

	public void AddPerson (Person person) 
	{
		_person = person;
	}
    public void UpdateAction(UInt64 subAction)
    {
        throw new System.NotImplementedException();
    }
}