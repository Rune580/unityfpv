using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AxisOut : MonoBehaviour {

	public Text axisVal;

	public string axis = "Vertical";


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
    axisVal.text = Input.GetAxis(axis).ToString();
  }
}
