using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.CrashLog;

public class OptionController : MonoBehaviour
{
	List<Box> Boxes = new List<Box>() { new Box() };

	void Awake()
	{
		//CrashReporting.Init("89876679-8146-4AD6-9E52-2E8A55D7F6E9", "0.0");
		StartCoroutine(Leaking());
	}

	IEnumerator Leaking()
	{
		while(true)
		{
			yield return new WaitForSeconds(0.25f);
			Boxes.Add(new Box());
		}
	}

	void OnGUI()
	{
		GUI.Label(new Rect(30, 30, Screen.width - 60, 30), "Box=" + Boxes.Count);
	}

	public void OnPressError()
	{
		throw new Exception("OnPressError(): Happen something @ Option");
	}

	/*
	 * 1Mのメモリを消費
	 */
	class Box
	{
		byte[] bytes = new byte[1024*1024];
	}
}
