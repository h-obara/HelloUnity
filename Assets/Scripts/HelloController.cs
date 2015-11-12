using UnityEngine;
using System;
using System.Collections;
using UnityEngine.CrashLog;


public class HelloController : MonoBehaviour
{

	// Use this for initialization
	void Awake()
	{
		CrashReporting.Init("1c0b4e3e-2eea-4f7b-9cad-39b696015edf");
	}

	public void OnPressError()
	{
		throw new Exception("OnPressError(): Happen something.");
	}
}