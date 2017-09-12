using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineMovement : MonoBehaviour {

    public Vector3 direction = Vector3.right;
    public float moveSpeed = 3.5f;
    public float moveTime = 3f;
    public Rigidbody rb;
    private float time;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate () {
        time += Time.deltaTime;
        if(time > moveTime)
        {
            time = 0;
            direction = direction * -1;
        }
        transform.position += direction * Time.deltaTime * moveSpeed;
        //rb.MovePosition(direction * Time.deltaTime * moveSpeed);	
	}
}
