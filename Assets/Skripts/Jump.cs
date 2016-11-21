using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour
{
    MotherCollider collider;
    Vector3D UpdatePosition;
    float jumpHeight;
    // Use this for initialization
    void Start()
    {
        collider.GetComponent<MotherCollider>();
        collider.Collision += Jump_Collision;
        jumpHeight = 120.0f;
    }

    private void Jump_Collision(MotherCollider obj)
    {
        if (obj.gameObject.tag== "Player")
        {
            obj.transform.Translate(new Vector3D(UpdatePosition.x, obj.gameObject.transform.position.y + jumpHeight * Time.deltaTime, UpdatePosition.z));
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}


