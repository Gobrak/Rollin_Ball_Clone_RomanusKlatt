using UnityEngine;
using System.Collections;

public abstract class MotherCollider: MonoBehaviour
{
    public float smallestX;
    public float smallestY;
    public float smallestZ;
    public float biggestX;
    public float biggestY;
    public float biggestZ;
    public float distanceX;
    public float distanceY;
    public float distanceZ;
    public bool grounded;

    public virtual void Collision(MotherCollider other)
    {
      
    }
}
