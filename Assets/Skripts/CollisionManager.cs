using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class CollisionManager
{
    public List<BoxCollider> Collisionboxes = new List<BoxCollider>();




    // Update is called once per frame
    void Update()
    {

    }

    public void CheckBoxCollider()
    {
        Collisionboxes.FindAll(BoxCollider items).Add;
    }
}
