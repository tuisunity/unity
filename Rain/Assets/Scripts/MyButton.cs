using UnityEngine;
using System.Collections;

public class MyButton : MonoBehaviour
{

    public void OnClick()
    {
        Debug.Log("Button click!");
        // 非表示にする
        //gameObject.SetActive(false);

        MyCanvas.SetActive("LightRain", true);

    }
}