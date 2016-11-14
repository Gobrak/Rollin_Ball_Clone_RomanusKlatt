using UnityEngine;
using System.Collections;

public class BoxCollider : MonoBehaviour
{
    Vector3D BoxBottomLeftFront;
    Vector3D BoxBottomLeftBack;
    Vector3D BoxBottomRightFront;
    Vector3D BoxBottomRightBack;
    Vector3D BoxTopLeftFront;
    Vector3D BoxTopLeftBack;
    Vector3D BoxTopRightFront;
    Vector3D BoxTopRightBack;

    float smallestX;
    float smallestY;
    float smallestZ;
    float biggestX;
    float biggestY;
    float biggestZ;

    BoxCollider()
    {
        Bounds bounds = this.gameObject.GetComponent<Bounds>();
        Vector3D BoxSize = Vector3D.ConvertToVector3D(bounds.size);
        Vector3D BoxCenter = Vector3D.ConvertToVector3D(bounds.center);

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
        
        RaycastHit hitactor = new RaycastHit();
        BoxCollider other = hitactor.transform.GetComponent<BoxCollider>();
        this.Collision(this, other);
    }

    public bool Collision(BoxCollider a, BoxCollider b)
    {
        if (a.smallestX <= b.biggestX && a.biggestX >= b.smallestX && a.smallestY <= b.biggestY && a.biggestY >= b.smallestY && a.smallestZ <= b.biggestZ && a.biggestZ >= b.smallestZ)
        {
            return true;
        }
        else
            return false;
    }
}
