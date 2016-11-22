using UnityEngine;
using System.Collections;

public class SpeedUp : MonoBehaviour
{
    public MotherCollider collider;

	// Use this for initialization
	void Start ()
    {
        collider = GetComponent<MotherCollider>();
        collider.Collision += SpeedUP_Collision;
	}

    private void SpeedUP_Collision(MotherCollider obj)
    {
        if (obj.gameObject.tag=="Player")
        {
            obj.GetComponent<Movement>().speed = 0.5f;
        }
    }

    // Update is called once per frame
    void Update ()
    {
	
	}
}
