using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{
    public Text textObjekt;
    public GameObject menueObjekt;
    private float timer;

    // Use this for initialization
    void Start()
    {
        menueObjekt.SetActive(true);
        textObjekt.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
            timer += Time.deltaTime;
            textObjekt.text = ((int)timer).ToString();               
    }
}
