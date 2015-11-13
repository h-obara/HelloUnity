using UnityEngine;
using System;
using System.Collections;
using UnityEngine.CrashLog;

public class OptionController : MonoBehaviour
{
	void Awake()
	{
		CrashReporting.Init("89876679-8146-4AD6-9E52-2E8A55D7F6E9", "0.0");
	}

	public void OnPressError()
	{
		throw new Exception("OnPressError(): Happen something @ Option");
	}
}
