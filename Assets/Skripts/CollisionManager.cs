using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class CollisionManager: MonoBehaviour
{
    public List<MotherCollider> Collisionboxes = new List<MotherCollider>();

    public void CheckNewBoxes()
    {
        GameObject[] AllCollisionBoxes = GameObject.FindGameObjectsWithTag("collision");
        for (int i = 0; i < AllCollisionBoxes.GetLength(0); i++)
        {
            Collisionboxes.Add(AllCollisionBoxes[i].GetComponent<MotherCollider>());
        }
    }

    void update()
    {

    }

    public void Collisiondetektion()
    {
        foreach (var ColliderA in Collisionboxes)
        {
            foreach (var ColliderB in Collisionboxes)
            {
                if (ColliderA != ColliderB)
                {
                    ColliderA.transform.GetComponent<BoxCollider>().Collision( ColliderB);
                } 
            }
        }

    }
}
