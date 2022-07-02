using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MyScript : MonoBehaviour
{

	public enum CollectibleTypes { NoType, Type1, Type2, Type3, Type4, Type5 }; // you can replace this with your own labels for the types of collectibles in your game!

	public CollectibleTypes CollectibleType; // this gameObject's type

	public bool rotate; // do you want it to rotate?

	public float rotationSpeed;

	public AudioClip collectSound;

	public GameObject collectEffect;
	float f = 0.1f;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		
		if (transform.position.x < -4)
        {
			f = 0.1f;
        }
		if (transform.position.x > 4)
		{
			f = -0.1f;
		}
		transform.Translate(0, 0, f);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Collect();
		}
	}

	public void Collect()
	{
		if (collectSound)
			AudioSource.PlayClipAtPoint(collectSound, transform.position);
		if (collectEffect)
			Instantiate(collectEffect, transform.position, Quaternion.identity);

		//Below is space to add in your code for what happens based on the collectible type

		if (CollectibleType == CollectibleTypes.NoType)
		{

			//Add in code here;

			Debug.Log("Do NoType Command");
		}
		if (CollectibleType == CollectibleTypes.Type1)
		{

			//Add in code here;

			Debug.Log("Do NoType Command");
		}
		if (CollectibleType == CollectibleTypes.Type2)
		{

			//Add in code here;

			Debug.Log("Do NoType Command");
		}
		if (CollectibleType == CollectibleTypes.Type3)
		{

			//Add in code here;

			Debug.Log("Do NoType Command");
		}
		if (CollectibleType == CollectibleTypes.Type4)
		{

			//Add in code here;

			Debug.Log("Do NoType Command");
		}
		if (CollectibleType == CollectibleTypes.Type5)
		{

			//Add in code here;

			Debug.Log("Do NoType Command");
		}

		Destroy(gameObject);
	}
}
