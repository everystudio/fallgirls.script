using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPadTest : MonoBehaviour {

	public Vector2 touch;

	public void start()
	{
		Debug.Log("start");
	}

	public void touchpad(Vector2 _touch)
	{
		touch += _touch;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
