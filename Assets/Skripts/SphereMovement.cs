using UnityEngine;
using System.Collections;

public class SphereMovement : MonoBehaviour
{
    Vector3D UpdatePosition;
    MotherCollider colliders;
    Vector3D StartVector;

    [SerializeField]
    public float fallingSpeed;
    [SerializeField]
    public float speed;
    public float timer;

    // Use this for initialization
    void Start()
    {
        StartVector = new Vector3D(0, 2, -5);
        colliders = GetComponent<MotherCollider>();
        gameObject.transform.position = StartVector;
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (StarCountDown.play)
        {
            if (!colliders.grounded)
            {
                timer += Time.deltaTime;
                if (timer > 0.14f)
                {
                    this.gameObject.transform.position = Vector3D.Falling(this.gameObject, fallingSpeed);
                }
            }
            if (colliders.grounded)
            {
                timer = 0f;
            }
            UpdatePosition = Vector3D.Position(this.gameObject);
            this.transform.position = StartVector.Translate(new Vector3D(UpdatePosition.x, UpdatePosition.y, (this.gameObject.transform.position.z + speed * Time.deltaTime)));
        }
    }


}
