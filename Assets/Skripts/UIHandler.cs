using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public GameObject uiObjektPC;
    public GameObject uiObjektAndroid;
    public GameObject Player;
    public Slider uiSlider;
    public UIHandler handle;
#if UNITY_STANDALONE
    
    void Start()
    {
        uiObjektPC.SetActive(true);
    }

#endif

#if UNITY_ANDROID
    void Start()
    {
        uiObjektPC.SetActive(false);
    }
#endif
}
