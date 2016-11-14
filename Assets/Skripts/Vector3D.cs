using UnityEngine;
using System.Collections;

public class Vector3D
{
    public float x, y, z;

    public Vector3D(float x,float y,float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public Vector3D Translate(Vector3D end)
    {
        return new Vector3D(end.x,end.y,end.z);        
    }
    public static implicit operator Vector3(Vector3D m)
    {
        return new Vector3(m.x, m.y, m.z);
    }
    public static Vector3D ConvertToVector3D(Vector3 m)
    {
        return new Vector3D(m.x, m.y, m.z);
    }

    public static Vector3D Position(GameObject m)
    {
        return new Vector3D(m.transform.position.x, m.transform.position.y, m.transform.position.z);
    }

    public static Vector3D Falling(GameObject m,float fallingSpeed)
    {
 
        return new Vector3D(m.transform.position.x, m.transform.position.y-fallingSpeed, m.transform.position.z);
    }

}

