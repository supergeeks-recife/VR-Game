using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class RayCastPointer2 : MonoBehaviour
{
    public Button button;
    public Image circleProgress;
    public float totalTime = 3;

    private bool gvrStatus;
    private float gvrTime;//tempo de contagem

    public UnityEvent GvrClick;

    void Update()
    {
        if(gvrStatus == true)
        {
            gvrTime += Time.deltaTime;
            circleProgress.fillAmount = gvrTime / totalTime;
        }
        else
        {
            gvrTime = 0;
            circleProgress.fillAmount = 0;
        }
    }

    public void GvrOnButton()
    {
        gvrStatus = true;
    }

    public void GvrOffButton()
    {
        gvrStatus = false;
    }
}
