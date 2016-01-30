﻿using UnityEngine;
using System.Collections;

public class BirdAi : MonoBehaviour {

	public float distMin;
	public float highMax;
	public float maxFar;
	Vector3 startPos;
	Vector3 middPos;
	Vector3 middPos2;
	Vector3 endPos;
	Transform playerPos;
	float dist;
	float speed;

	enum flyingState
	{
		FLYING,
		MIDDLE,
		MIDDLE2,
		LANDED
	};

	flyingState state;

	// Use this for initialization
	void Start () {
		state = flyingState.LANDED;
		speed = 0.1f;
		startPos = this.gameObject.transform.position;
		playerPos = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		dist = Vector3.Distance (this.gameObject.transform.position, playerPos.position);
		if (dist < distMin && state == flyingState.LANDED)
		{
			state = flyingState.FLYING;
			endPos.x = Random.Range(-maxFar, maxFar);
			endPos.y = 0.5f;
			endPos.z = Random.Range(-maxFar, maxFar);

			middPos.x = startPos.x + endPos.x;
			float rndRange = highMax/10;
			middPos.y = highMax + Random.Range(-rndRange, rndRange);
			middPos.z = startPos.z + endPos.z;

			middPos2 = middPos;
			middPos2.x = middPos.x + endPos.x;
			middPos2.z = middPos.z + endPos.z;
		}
		if (state == flyingState.FLYING)
		{
			transform.position = Vector3.MoveTowards(transform.position, middPos, 0.2f);
			if (transform.position == middPos)
			{
				state = flyingState.MIDDLE;
			}
		}
		if (state == flyingState.MIDDLE)
		{
			transform.position = Vector3.MoveTowards(transform.position, middPos2, 0.2f);
			if (transform.position == middPos2)
			{
				state = flyingState.MIDDLE2;
			}
		}
		if (state == flyingState.MIDDLE2)
		{
			transform.position = Vector3.MoveTowards(transform.position, endPos, 0.1f);
			if (transform.position == endPos)
			{
				state = flyingState.LANDED;
			}
		}
	}
}
