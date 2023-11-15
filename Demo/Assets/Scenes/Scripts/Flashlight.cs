using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Flashlight : MonoBehaviour
{

	public KeyCode control = KeyCode.F;

	public Light _light;

	public float min = 1;
	public float max = 8;

	



	void Start()
	{
		_light.enabled = false;
		_light.intensity = min;
	}

	void Update()
	{
		if (Input.GetKeyDown(control) && !_light.enabled)
		{
			_light.enabled = true;
		}
		else if (Input.GetKeyDown(control) && _light.enabled)
		{
			_light.enabled = false;
			_light.intensity = min;
		}
	}
}
