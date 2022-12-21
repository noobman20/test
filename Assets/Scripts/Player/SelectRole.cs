using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRole : MonoBehaviour {

	public Animation animation;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float H = -ETCInput.GetAxis("xuanzeH");

        transform.Rotate(Vector3.up * H * 80 * Time.deltaTime);

    }

	public void jieshou()
    {
		animation.Play("Attack1");
		Invoke("fuwei", 2f);
	}
	public void jieshou2()
	{
		animation.Play("Run");
		Invoke("fuwei", 3f);
	}
	public void jieshou3()
	{
		animation.Play("Death");
		Invoke("fuwei", 3f);
	}

	public void fuwei()
    {
		animation.Play("Idle");
	}
}
