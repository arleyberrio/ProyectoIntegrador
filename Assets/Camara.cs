using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    // Start is called before the first frame update

    public Camera FPSCamera;


    public float horizontalSpeed;
    public float verticalSpeed;

    float horizontal;
    float vertical;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		horizontal = horizontalSpeed * Input.GetAxis("Mouse X");
		vertical = verticalSpeed * Input.GetAxis("Mouse Y");

		transform.Rotate(0, horizontal, 0);
		FPSCamera.transform.Rotate(-vertical, 0, 0);

		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(0, 0, 0.1f);
		}
		else
		{
			if (Input.GetKey(KeyCode.S))
			{
				transform.Translate(0, 0, -0.1f);
			}
			else
			{
				if (Input.GetKey(KeyCode.A))
				{
					transform.Translate(-0.1f, 0, 0);
				}
				else
				{
					if (Input.GetKey(KeyCode.D))
					{
						transform.Translate(0.1f, 0, 0);
					}
				}
			}
		}
	}
}
