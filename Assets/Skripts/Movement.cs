using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

    [SerializeField]
    public float fallingSpeed;
    [SerializeField]
    public float moveSpeedRight;
    [SerializeField]
    public float moveSpeedLeft;
    [SerializeField]
    public float jumpHeight;
    [SerializeField]
    public float touchspeed;


    MotherCollider colliders;
    Vector3D StartVector;
    Vector3D UpdatePosition;
    // Use this for initialization
    void Start()
    {
        StartVector = new Vector3D(0, 2, 0);
        gameObject.transform.position = StartVector;
        moveSpeedLeft = 0.1f;
        moveSpeedRight = 0.1f;
    }

#if UNITY_STANDALONE
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            UpdatePosition = Vector3D.Position(this.gameObject);
            this.gameObject.transform.position = StartVector.Translate(new Vector3D(this.gameObject.transform.position.x + moveSpeedRight, UpdatePosition.y, UpdatePosition.z));
        }
        else if (Input.GetKey(KeyCode.A))
        {
            UpdatePosition = Vector3D.Position(this.gameObject);
            this.gameObject.transform.position = StartVector.Translate(new Vector3D(this.gameObject.transform.position.x - moveSpeedLeft, UpdatePosition.y, UpdatePosition.z));
        }

    }
#endif
#if UNITY_ANDROID
    void Update() 
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(touchPosition.x * touchspeed, touchPosition.y * touchspeed, 0);
        }
    }

#endif
}
