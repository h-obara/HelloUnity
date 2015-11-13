using UnityEngine;
using System;
using System.Collections;
using UnityEngine.CrashLog;


public class HelloController : MonoBehaviour
{
	void Awake()
	{
		CrashReporting.Init("1c0b4e3e-2eea-4f7b-9cad-39b696015edf", "0.0");
	}

	public void OnPressError()
	{
		throw new Exception("OnPressError(): Happen something @ Hello");
	}

	public void OnPressNext()
	{
		Application.LoadLevel("Option");
	}
}