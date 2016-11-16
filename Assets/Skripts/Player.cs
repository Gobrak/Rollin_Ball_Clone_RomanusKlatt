using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    MotherCollider collider;

	// Use this for initialization
	void Start ()
    {
        collider = GetComponent<MotherCollider>();
        collider.Collision += Player_Collision;
    }

    private void Player_Collision(MotherCollider obj)
    {
        if (obj.gameObject.layer == 8)
        {
            collider.grounded = true;
        }
        else
            collider.enabled = false;
        //throw new System.NotImplementedException();
    }

    // Update is called once per frame
    void Update ()
    {
	
	}
}
