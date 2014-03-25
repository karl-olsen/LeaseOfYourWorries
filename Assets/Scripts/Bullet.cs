﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	public float bulletlife = .5f;
	float dis = 500f;
	float bspeed = 0;
	float starttime = 0f;
	int dmg = 0;
	float angle;
	void Start()
	{

		starttime = Time.time;
	}
	private void OnCollisionEnter(Collision c){
		if(c.gameObject.tag == "enemy"){
			GameObject.Destroy (gameObject);
		}


	}
	void FixedUpdated(){
	}
	void Update () {
		//Debug.Log((Time.time-starttime)*bspeed);
		if((Time.time-starttime)*bspeed >= dis){
			GameObject.Destroy (gameObject);
		}

		
	}
	public void setdis(float a, float b){
		dis = a;
		bspeed = b;
	}
	public void setdmg(int a){
		dmg = a;
	}

}
