using UnityEngine;
using System.Collections;

public class BoxCollider : MotherCollider
{
    Vector3D BoxBottomLeftFront;
    Vector3D BoxBottomLeftBack;
    Vector3D BoxBottomRightFront;
    Vector3D BoxBottomRightBack;
    Vector3D BoxTopLeftFront;
    Vector3D BoxTopLeftBack;
    Vector3D BoxTopRightFront;
    Vector3D BoxTopRightBack;




    BoxCollider()
    {
        Bounds bounds = this.gameObject.GetComponent<Bounds>();
        BoxSize = Vector3D.ConvertToVector3D(bounds.size);
        BoxCenter = Vector3D.ConvertToVector3D(bounds.center);

        BoxBottomLeftFront = new Vector3D(BoxCenter.x - BoxSize.x / 2, BoxCenter.y - BoxSize.y / 2, BoxCenter.z - BoxSize.z / 2);
        BoxBottomLeftBack = new Vector3D(BoxCenter.x - BoxSize.x / 2, BoxCenter.y - BoxSize.y / 2, BoxCenter.z + BoxSize.z / 2);
        BoxBottomRightFront = new Vector3D(BoxCenter.x + BoxSize.x / 2, BoxCenter.y - BoxSize.y / 2, BoxCenter.z - BoxSize.z / 2);
        BoxBottomRightBack = new Vector3D(BoxCenter.x + BoxSize.x / 2, BoxCenter.y - BoxSize.y / 2, BoxCenter.z + BoxSize.z / 2);
        BoxTopLeftFront = new Vector3D(BoxCenter.x - BoxSize.x / 2, BoxCenter.y + BoxSize.y / 2, BoxCenter.z - BoxSize.z / 2);
        BoxTopLeftBack = new Vector3D(BoxCenter.x - BoxSize.x / 2, BoxCenter.y + BoxSize.y / 2, BoxCenter.z + BoxSize.z / 2);
        BoxTopRightFront = new Vector3D(BoxCenter.x + BoxSize.x / 2, BoxCenter.y + BoxSize.y / 2, BoxCenter.z - BoxSize.z / 2);
        BoxTopRightBack = new Vector3D(BoxCenter.x + BoxSize.x / 2, BoxCenter.y + BoxSize.y / 2, BoxCenter.z + BoxSize.z / 2);

        smallestX = BoxCenter.x - BoxSize.x / 2;
        smallestY = BoxCenter.y - BoxSize.y / 2;
        smallestZ = BoxCenter.z - BoxSize.z / 2;
        biggestX = BoxCenter.x + BoxSize.x / 2;
        biggestY = BoxCenter.y + BoxSize.y / 2;
        biggestZ = BoxCenter.z + BoxSize.z / 2;
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
   
    }

    public override void Collision( MotherCollider other) 
    {
    //    if (this.smallestX <= other.biggestX && this.biggestX >= other.smallestX && this.smallestY <= other.biggestY && this.biggestY >= other.smallestY && this.smallestZ <= other.biggestZ && this.biggestZ >= other.smallestZ)
    //    {
    //        if (this.BoxCenter.x<)
    //        {

    //        }
    //        else if (this.BoxCenter.x>)
    //        {

    //        }
    //        else if (this.BoxCenter.y<)
    //        {

    //        }
    //    }
    //    else
          
    }
}
