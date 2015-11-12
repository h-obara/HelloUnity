using System;
using UnityEngine;
using UnityEngine.CrashLog;
using System.Collections;

public class ThrowMeAnException : MonoBehaviour 
{

    void Awake()
    {
		CrashReporting.Init("1c0b4e3e-2eea-4f7b-9cad-39b696015edf");
    }

	public void CrashForMe()
	{
		throw new Exception("Button press exception");
	}

}
