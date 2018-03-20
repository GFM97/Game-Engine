using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// This is a reference to the Rigidbody component called "rb"
	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;

	// We marked this as "Fixed"Update because we 
	// are using it to mess with physics.
	void FixedUpdate ()
	{
		// Add a forward force
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

		if(Input.GetKey(KeyCode.D))
		{
			rb.AddForce (sidewaysForce * Time.deltaTime, 0, 0);
		}

		if(Input.GetKey(KeyCode.A))
		{
			rb.AddForce (-sidewaysForce * Time.deltaTime, 0, 0);
		}
	}
}
