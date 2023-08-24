using UnityEngine;
using UnityEngine.UI;

public class Achievement : MonoBehaviour
{
    public AchievementsBox achBox;
	public string[] Name, help, description;
	public string PlayerPrefsName;
    public Image achieveImg,frontImg,blackImg;
    public Gradient backGradient,frontGradient;
    public Color startColor,endColor;
    [HideInInspector] public int done;

    public void Awake()
    {
        ChangeFrameColor(startColor,endColor);
    }

    public void ChangeFrameColor(Color col1,Color col2)
    {
        backGradient.StartColor=col1;
        backGradient.EndColor=col2;
        frontGradient.StartColor=col1;
        frontGradient.EndColor=col2;
    }

    public void CheckAchieve()
    {
		//done=1;return;
        done=PlayerPrefs.GetInt(PlayerPrefsName);
        blackImg.color=done==0?new Color(0,0,0,0.7f):new Color(0,0,0,0);
		frontImg.color=done==0 ? new Color(1,1,1,0) : new Color(1,1,1,1);

    }

    public void ClickToAchieve()=>achBox.SelectedAchieve=this;

}
