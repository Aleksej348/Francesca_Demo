using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityTools;

public class MainAchievement : MonoBehaviour
{

	public AchievementsBox achbox;
    public TextMeshProUGUI tmpName;
    public Gradient backGradient,frontGradient;
    public Image mainImage;

    private AudioSource auSource;
    private AudioSource AuSource=>auSource??=GetComponent<AudioSource>();
	private GameManager gm => GameManager.gm;


    private void OnEnable()
    {
        StartCoroutine(ShowAchieve());
    }

    private IEnumerator ShowAchieve()
    {
		AuSource.volume=1f;
        AuSource.Play();
        yield return StartCoroutine(Tools.ChangeAnchoredPositionInTime((RectTransform)transform,new Vector2(0,1000f),Vector2.zero,1f));
        yield return new WaitForSecondsRealtime(4f);
        yield return StartCoroutine(Tools.ChangeAnchoredPositionInTime((RectTransform)transform,Vector2.zero,new Vector2(0,1000f),1f));
        gameObject.SetActive(false);
    }

	private IEnumerator DecreaseVolume()
	{
		for(float i=1f;i>0;i-=0.01f)
		{
			AuSource.volume=i;
			yield return new WaitForSecondsRealtime(0.01f);
		}
	}


	public void ChangeAchieve(string name)
    {
        Achievement ach=achbox.Achievements[name];
        tmpName.text=ach.Name[gm.language];
        mainImage.sprite=ach.achieveImg.sprite;
        backGradient.StartColor=ach.startColor;
        backGradient.EndColor=ach.endColor;
        frontGradient.StartColor=ach.startColor;
        frontGradient.EndColor=ach.endColor;
    }
}
