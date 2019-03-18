using UnityEngine;
using System.Collections;

public class moveClass : MonoBehaviour
{
	public float speed = 0.1f;
	public void FixedUpdate()
	{
		if(Input.GetKey(KeyCode.D))
		{
			transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
		}
		if(Input.GetKey(KeyCode.A))
		{
			transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
		}
		if(Input.GetKey(KeyCode.S))
		{
			transform.position = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z);
		}
		if(Input.GetKey(KeyCode.W))
		{
			transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
		}
	}
}