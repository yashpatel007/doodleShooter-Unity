using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {

	public Rigidbody2D rb;
	private bool isPressed = false;

	public float releaseTime = .15f; 
	public Rigidbody2D hook;
	public float maxDragDistance = 2f;

	void Update ()
	{
		if (isPressed)
		{

			Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (Vector3.Distance(mousepos,hook.position) > maxDragDistance){
				//
				rb.position =hook.position + (mousepos - hook.position).normalized * maxDragDistance;
			}
			
			else{
			rb.position = mousepos;}
		}
	}

	void OnMouseDown ()
	{
		isPressed = true;
		rb.isKinematic = true;
	}



	void OnMouseUp ()
	{
		isPressed = false;
		rb.isKinematic = false;
		StartCoroutine(Release());
	}

	IEnumerator Release(){

		yield return new WaitForSeconds(releaseTime) ;
		GetComponent<SpringJoint2D>().enabled = false;
		this.enabled = false;
	}

}

