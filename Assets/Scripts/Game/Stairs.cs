using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stairs : MonoBehaviour
{
    public List<SpriteRenderer> imgs,queue;
    private float delay=1.7f;

    private void Awake()
    {

    }

    private void OnEnable()
    {
        StartCoroutine("falling");
    }

    private IEnumerator falling()
    {
		foreach(SpriteRenderer img in imgs)
			img.gameObject.SetActive(false);
        int num=10;
		float time=6f;
		for(int i = 0;i<imgs.Count;i++)
		{
			imgs[i].sortingOrder=num++;
			if(time>0)
			{
				imgs[i].transform.GetComponent<Stair>().timefall=time;
				imgs[i].transform.gameObject.SetActive(true);
				time-=1f/delay;
			}
		}
		yield return new WaitForSecondsRealtime(1f/delay); 
		while(true)
        {
            for(int i=0;i<imgs.Count;i++)
            {
                imgs[i].sortingOrder=num++;
                imgs[i].transform.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1f/delay);
            }
        }
    }

}
