using UnityEngine;
using System.Collections;

public class CameraZoom : MonoBehaviour
{
	public int zoom = 20;
	public int normal = 60;
	float smooth = 5;
	private bool isZoomed = false;
	float m_FieldOfView;
	public Vector3 camoriginposition;
	public float speed = 0.1f;

	void Start() {

		camoriginposition = Camera.main.transform.position;
	}
	void Update ()
	{
		Camera.main.fieldOfView = m_FieldOfView;

		if (Input.GetMouseButtonDown (1)) {
			isZoomed = !isZoomed;

		}
		if (isZoomed) {
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
			m_FieldOfView = Mathf.Lerp (m_FieldOfView, zoom, Time.deltaTime * smooth);
		} else {
			m_FieldOfView = Mathf.Lerp (m_FieldOfView, normal, Time.deltaTime * smooth);
			Camera.main.transform.position = camoriginposition ;

		}
	}
}