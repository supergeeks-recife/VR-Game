using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class RayCastPointer : MonoBehaviour
{
    public Button button;
    public Image circleProgress;
    public float totalTime = 3;

    private bool gvrStatus;//está olhando o botão ou não
    private float gvrTimer;//tempo que está olhando

    public UnityEvent GvrClick;

    void Update()
    {
        if(gvrStatus == true)
        {
            gvrTimer += Time.deltaTime;
            circleProgress.fillAmount = gvrTimer / totalTime;

            if(gvrTimer >= totalTime)
            {
                GvrClick.Invoke();
            }
        }
        else
        {
            gvrTimer = 0;
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
