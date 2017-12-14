using UnityEngine;
public class CameraFollow : MonoBehaviour
{
	public Transform ObjectToFollow;
	public Vector3 Offset;

	public float moveSpeed = 10;
	//private zposition = 0;

	void LateUpdate ()
	{
//		if (ObjectToFollow != null)
//			transform.position = ObjectToFollow.position + Offset;
//		transform.LookAt (ObjectToFollow);

	
		//Moves Forward and back along z axis                           //Up/Down
		//zposition = 
		transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical")* moveSpeed);

		//if (zposition > -176f){
		//	transform.position (0f, 0f, 20);
		//}



		//Moves Left and right along x Axis                               //Left/Right
		transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal")* moveSpeed);


		if (Input.GetKey(KeyCode.A)) {
			transform.Rotate (new Vector3 (0f, -20f, 0f) * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.S)) {
			transform.Rotate (new Vector3 (0f, 20f, 0f) * Time.deltaTime);
		}


	}
}