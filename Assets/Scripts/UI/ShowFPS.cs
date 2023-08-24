using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowFPS : MonoBehaviour
{
    public TextMeshProUGUI tmpdelta;
    private float time;

    private void Update()
    {
        time+=Time.deltaTime;
        if(time>0.1f)
        {
            tmpdelta.text=""+(int)(1f/Time.deltaTime);
            time=0;
        }
    }
}
