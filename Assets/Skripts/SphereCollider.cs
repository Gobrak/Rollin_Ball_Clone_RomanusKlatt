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
        //closest Point to sphere center
        distanceX = Mathf.Max(other.smallestX, Mathf.Min(this.SphereCenter.x, other.biggestX));
        distanceY = Mathf.Max(other.smallestY, Mathf.Min(this.SphereCenter.y, other.biggestY));
        distanceZ = Mathf.Max(other.smallestZ, Mathf.Min(this.SphereCenter.z, other.biggestZ));

        float distance = Mathf.Sqrt((distanceX - this.SphereCenter.x) * (distanceX - this.SphereCenter.x) + (distanceY - this.SphereCenter.y) * (distanceY - this.SphereCenter.y) + (distanceZ - this.SphereCenter.z) * (distanceZ - this.SphereCenter.z));

        if (distance < this.SphereRadius && this.SphereCenter.y > other.BoxCenter.y)
        {
            grounded = true;
        }
        else
            grounded = false;

        if (  distance < this.SphereRadius && this.SphereCenter.y < other.BoxCenter.y||   distance < this.SphereRadius && this.SphereCenter.x < other.BoxCenter.x ||  distance < this.SphereRadius && this.SphereCenter.x > other.BoxCenter.x ||  distance < this.SphereRadius && this.SphereCenter.z < other.BoxCenter.z || distance < this.SphereRadius && this.SphereCenter.z > other.BoxCenter.z )
        {
            Destroy(this);
        }
    }
}
