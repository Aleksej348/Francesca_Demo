using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stair : MonoBehaviour
{
    private float speed=2f;
    public float timefall;

    private void OnEnable()
    {

        transform.localScale=StartPos(timefall);
        StartCoroutine("falling");
    }

    private IEnumerator falling()
    {

        while(transform.localScale.x<3.5f)
        {
            transform.localScale+=new Vector3(transform.localScale.x*0.01f,transform.localScale.y*0.01f,0)*speed;
            yield return new WaitForSecondsRealtime(0.01f);
        }

        timefall=0;
        gameObject.SetActive(false);
    }

    public Vector3 StartPos(float times)
    {
        Vector3 pos=new Vector3((float)0.002991848,(float)0.002991848,0);

        for(float i=0;i<times;i+=0.01f)
        {
            pos+=new Vector3(pos.x*0.01f,pos.y*0.01f,0)*speed;
        }

        return pos;
    }
}
