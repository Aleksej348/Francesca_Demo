using UnityEngine;
using TMPro;
using UnityTools;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;

public class AchievementsBox : MonoBehaviour
{
	private GameManager gm => GameManager.gm;	
	[SerializeField] private TextMeshProUGUI nameInfo,helpInfo,descriptionInfo,nullAchInfo;
    [SerializeField] private Achievement AchieveInfo;
    private Achievement[] _achievements;
	private Achievement[] achievements=>_achievements??=Tools.GetArrayChildsOfType<Achievement>(transform.GetChild(0));
	private Dictionary<string, Achievement> _Achievements;
	public Dictionary<string, Achievement> Achievements => _Achievements??=achievements.ToDictionary(x => x.PlayerPrefsName, y => y);

	private Achievement selectedAchieve;
    public Achievement SelectedAchieve
    {
        get=>selectedAchieve;
        set{selectedAchieve=value;ChangeAchieveInfo();}
    }	

    private void OnEnable()
    {
        SetInfoNull();
        CheckAll();
    }

    public void ChangeAchieveInfo()
    {
        AchieveInfo.transform.gameObject.SetActive(true);
        AchieveInfo.achieveImg.sprite=selectedAchieve.achieveImg.sprite;
		AchieveInfo.frontImg.sprite=selectedAchieve.frontImg.sprite;
		AchieveInfo.frontImg.color=selectedAchieve.frontImg.color;		
        AchieveInfo.blackImg.color=selectedAchieve.blackImg.color;
        nullAchInfo.text="";
        nameInfo.text=selectedAchieve.Name[gm.language];
        helpInfo.text=selectedAchieve.help[gm.language];
        descriptionInfo.text=selectedAchieve.done==0? string.Concat(Enumerable.Repeat("?",Random.Range(2,11))) : selectedAchieve.description[gm.language];
        AchieveInfo.ChangeFrameColor(selectedAchieve.startColor,selectedAchieve.endColor);
        LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)AchieveInfo.transform.parent);
        AchieveInfo.gameObject.SetActive(false);AchieveInfo.gameObject.SetActive(true);
        Tools.SetPreferredMaxHeight((RectTransform)nameInfo.transform,200f);
        Tools.SetPreferredMaxHeight((RectTransform)helpInfo.transform,200f);
    }



    public void SetInfoNull()
    {
        AchieveInfo.transform.gameObject.SetActive(false);
        nullAchInfo.text=GameManager.gm.language==1?"Выберите достижение, чтобы увидеть его описание.": "Select an achievement to see its description.";
        nameInfo.text="";
        helpInfo.text="";
        descriptionInfo.text="";
    }

    public void CheckAll()
    {
        foreach(Achievement ach in achievements)
        ach.CheckAchieve();
    }




}
