using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IneractableObjects : MonoBehaviour {

    [SerializeField]
    WasteTypes type;

	void Update ()
    {
	    	
	}
}
public enum WasteTypes
{
    Green,
    Blue,
    Red,
    White
}
