using UnityEngine;
using System.Collections;

public class SphereCollider : MotherCollider
{
    Vector3D SphereCenter;
    float SphereRadius;


    SphereCollider()
    {
        
        BoundingSphere SphereBounds = this.gameObject.GetComponent<BoundingSphere>();
        SphereCenter = Vector3D.ConvertToVector3D(SphereBounds.position);
        SphereRadius = SphereBounds.radius;
    }
    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public override void Collision(MotherCollider other)
    {
        distanceX = other.smallestX - this.SphereCenter.x;

        if (true)
        {

        }
    }
}
