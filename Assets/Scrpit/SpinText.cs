using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpinText : MonoBehaviour {

	public Text spinningText;

	private const int speed = 15;
	private const int top = 20;
	private const int bottem = 5;
	private int delay;
	private int val;
	private bool direction;

	// Use this for initialization
	void Start () {
		val = 5;
		spinningText.text = val.ToString();
		delay = speed;
		direction = true;
	}

	// Update is called once per frame
	void Update () {
		if (delay > 0)
		{
			delay = delay - 1;
		}
		else
		{
			if (direction)
			{
				val = val + 1;
			}
			else
			{
				val = val - 1;
			}
			spinningText.text = val.ToString();
			if (val >= top)
			{
				direction = false;
			}
			else if (val <= bottem)
			{
				direction = true;
			}
			delay = speed;
		}
	}
}
