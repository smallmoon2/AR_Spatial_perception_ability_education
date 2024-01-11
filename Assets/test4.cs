using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test4 : MonoBehaviour
{
	public GameObject bullet;
	public int num;
	public GameObject spot;

	// Start is called before the first frame update
	bool state = false;

	void OnMouseDown()
	{
		if (num <= 0){
			GetComponent<Animator>().SetTrigger("LOSS");
		}
        else
        {
			GameObject gameobject = Instantiate(bullet, transform.position, Quaternion.identity);
			gameobject.GetComponent<Rigidbody>().AddForce(transform.forward * 500);

			GetComponent<Animator>().SetTrigger("WIN");
			num--;
		}

	}
}
