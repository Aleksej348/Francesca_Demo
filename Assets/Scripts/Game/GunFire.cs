using System.Collections;
using UnityEngine;

public class GunFire : MonoBehaviour
{
	public Sprite[] sprites;
	private SpriteRenderer[] _holes;
	private SpriteRenderer[] holes=>_holes??=UnityTools.Tools.GetArrayChildsOfType<SpriteRenderer>(transform);
	private float? _left;
	private float left => _left??=GameManager.gm.Directions["Лево"]-3f;
	private float? _right;
	private float right => _right??=GameManager.gm.Directions["Право"]+3f;	

	public IEnumerator Fire(int times,float delay)
	{
		UnityTools.Tools.DeactivateChilds(transform);
		for(int i=0;i<times;i++)
		{
			holes[i].sprite=sprites[Random.Range(0,3)];
			holes[i].transform.position=new Vector3(Random.Range(left,right),Random.Range(3f,-3f));
			holes[i].transform.rotation=new Quaternion(0,0,Random.Range(0,361),0);
			holes[i].transform.localScale=new Vector3(Random.Range(1f,1.2f),Random.Range(1f,1.2f));
			holes[i].gameObject.SetActive(true);
			GameManager.gm.au.PlaySound(31,Random.Range(0.9f,1.1f));			
			GameManager.gm.au.PlaySound2(24,Random.Range(0.9f,1.1f));
			yield return new WaitForSecondsRealtime(Random.Range(delay-delay/3f,delay+delay/3f));
		}
	}
}
