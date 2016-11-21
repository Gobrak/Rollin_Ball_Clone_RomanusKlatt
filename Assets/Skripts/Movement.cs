﻿using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    [SerializeField]
    public float speed;
    [SerializeField]
    public float fallingSpeed;
    [SerializeField]
    public float moveSpeedRight;
    [SerializeField]
    public float moveSpeedLeft;
    [SerializeField]
    public float jumpHeight;
    float timer;

    MotherCollider collider;
    Vector3D StartVector;
    Vector3D UpdatePosition;
    // Use this for initialization
    void Start()
    {
        StartVector = new Vector3D(0, 2, 0);
        collider = GetComponent<MotherCollider>();
        gameObject.transform.position = StartVector;    
        moveSpeedLeft = 0.1f;
        moveSpeedRight = 0.1f;      
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!collider.grounded)
        {
            timer += Time.deltaTime;
            if (timer > 0.14f)
            {
                this.gameObject.transform.position = Vector3D.Falling(this.gameObject, fallingSpeed);               
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            UpdatePosition = Vector3D.Position(this.gameObject);
            this.gameObject.transform.position = StartVector.Translate(new Vector3D(this.gameObject.transform.position.x + moveSpeedRight, UpdatePosition.y, UpdatePosition.z));
        }
        else if (Input.GetKey(KeyCode.A))
        {
            UpdatePosition = Vector3D.Position(this.gameObject);
            this.gameObject.transform.position = StartVector.Translate(new Vector3D(this.gameObject.transform.position.x - moveSpeedLeft, UpdatePosition.y, UpdatePosition.z));
        }
        if (Input.GetKey(KeyCode.Space) && collider.grounded)
        {
            UpdatePosition = Vector3D.Position(this.gameObject);
            this.gameObject.transform.position = StartVector.Translate(new Vector3D(UpdatePosition.x, this.gameObject.transform.position.y + jumpHeight * Time.deltaTime, UpdatePosition.z));
            timer = 0;
        }
        UpdatePosition = Vector3D.Position(this.gameObject);
        this.transform.position = StartVector.Translate(new Vector3D(UpdatePosition.x, UpdatePosition.y, this.gameObject.transform.position.z + speed));
    }


}
