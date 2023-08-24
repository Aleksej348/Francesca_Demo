using System.Collections.Generic;
using UnityEngine;
using UnityTools;

public class Story : MonoBehaviour
{
	public GameManager gm => GameManager.gm;
	public Storyteller st => GameManager.gm.st;
	public Actions act => GameManager.gm.act;
	public float speed => GameManager.gm.st.speed;
	public int? _language = null;
	public int language => _language??=PlayerPrefs.GetInt("Language");

	public void GetAchieve(string name,bool check = true)
	{
		if(PlayerPrefs.GetInt(name)==0&&check==true)
		{
			//PlayerPrefs.SetInt(name,1);
			gm.mainAchievement.ChangeAchieve(name);
			gm.mainAchievement.gameObject.SetActive(true);
		}
	}

	public string RichText(string text,Color col)
	{		
		return $"<color=#{ColorUtility.ToHtmlStringRGBA(col)}>{text}</color>";
	}

	public string RichText(string text,string col)
	{		
		return $"<color=#{col}>{text}</color>";
	}

	public void DeactivateAllHeroes()
	{ Tools.DeactivateChilds(gm.personBox); }
	public void SetAllButtons(bool value)
	{ gm.tb.gameObject.SetActive(value); gm.mbox.gameObject.SetActive(value); gm.statsBox.gameObject.SetActive(value); }

	public void NextCoroutine(string label,int istory = -1,int _step = 0)
	{ st.NextCoroutine(label,istory,_step); }

	public void Mirror(string _name,Vector3 from,Vector3 where)
	{ act.StartCoroutine(routine: act.Mirror(_name,from,where)); }
	public void Mirror(string _name,Vector3 where)
	{ act.StartCoroutine(routine: act.Mirror(_name,where)); }

	public void Item(int a)
	{
		gm.items[a].gameObject.SetActive(true);
		if(a==3)
			st.timemachineAnimator.SetFloat("Speed",speed);
	}

	public void CloseItem(int a)
	{ gm.items[a].gameObject.SetActive(false); }

	public void GunFire(int times,float delay)
	{ gm.items[14].gameObject.SetActive(true); StartCoroutine(gm.items[14].GetComponent<GunFire>().Fire(times,delay)); }

	public void TimeTravel(string text,int scene,int music,int item = 3)
	{ StartCoroutine(act.timeTravel(text,scene,music,item)); }

	public void Thrill(string _name)
	{ act.StartCoroutine(routine: act.Thrill(_name)); }

	public void Shake()
	{ act.StartCoroutine("Shaker"); }

	public void LongShaker(float time = 1f,float power = 1f)
	{ act.StartCoroutine(routine: act.LongShaker(time,power)); }

	public void Messenger(int a = 0,int b = 0)
	{ act.Messenger(a,b); }

	public void Scene(int i,bool alone = true,bool aspect = false)
	{ act.Scene(i,alone,aspect); }

	public void SecondScene(int i)
	{ act.SecondScene(i); }

	public void SetStats(Dictionary<string,int> stats)
	{ act.SetStats(stats); }

	public void SandInfoMessage(string info)
	{ act.SandInfoMessage(info); }

	public void ChoiceList(string[] texts,int[] istories,string[] labels,int[] steps,bool[] musts = null,string[] comments = null)
	{ act.ChoiceList(texts,istories,labels,steps,musts,comments); }

	public void Fade(float pause = 2f,string _text = "")
	{ act.Fade(pause,_text); }

	public void ColorFade(Color col,float pause)
	{ StartCoroutine(act.ColorFade(col,pause)); }

	public void Begin()
	{ act.Begin(); }

	public void Dissolve(string name,int emotion)
	{ act.Dissolve(name,emotion); }

	public void StartDissolve(string name,int emotion)
	{ act.StartDissolve(name,emotion); }
	public void StartDissolveWithColor(string name,int emotion,Color col)
	{ act.StartDissolve(name,emotion,col); }

	public void EndDissolve(string name)
	{ act.EndDissolve(name); }

	public void Show(string name,string direction,Vector3 _scale = new Vector3(),Vector3 offset = new Vector3())
	{ act.Show(name,direction,_scale,offset); }
	public void Hide(string name)
	{ gm.HeroesGameobjects[act.ConvertReduction(name)].gameObject.SetActive(false); }
	public void HideSecondScene()
	{ gm.secondBackground.gameObject.SetActive(false); }

	public void Zoom(string name,Vector3 from,Vector3 where,float time)
	{ act.Zoom(name,from,where,time); }

	public void Zoom(string name,Vector3 where,float time)
	{ act.Zoom(name,where,time); }
	public void ZoomBackground(Vector3 where,float time)
	{ StartCoroutine(act.zoom(gm.background.transform,where,time)); }
	public void BackgroundColoring(Color color,float time)
	{ act.BackgroundColoring(color,time); }
	public void BackgroundUncoloring(float time)
	{ act.BackgroundUncoloring(time); }

	public void Move(string name,string from,string where,float time = 1f,Vector2 offsetfrom = default(Vector2),Vector2 offsetwhere = default(Vector2))
	{ act.Move(name,from,where,time,offsetfrom,offsetwhere); }

	public void Move(string name,string where,float time = 1f,Vector2 offset = default(Vector2))
	{ act.Move(name,where,time,offset); }
	public void Text(string txt)
	{ gm.tw.Text(txt); }

	public void Say(string name,string content,bool punch = false,bool converse = false,bool instantly = false)
	{ act.Say(name,content,punch,instantly: instantly); }

	public void Think(string content,bool instantly = false)
	{ gm.tb.Think(content,instantly); }

	public void PlayMusic(int number,bool after = false)
	{ gm.au.PlayMusic(number,after); }

	public void PlayMusic(int number,float _pitch,bool after = false)
	{ gm.au.PlayMusic(number,after,_pitch); }

	public void StopMusic()
	{ gm.au.StopMusic(); }
	public void PlaySound(int number,float _pitch = 1f,bool after = false)
	{ gm.au.PlaySound(number,_pitch,after); }
	public void PlaySound2(int number,float _pitch = 1f)
	{ gm.au.PlaySound2(number,_pitch); }
	public void PlaySoundMultTimes(int num,int times)
	{ StartCoroutine(gm.au.PlaySoundMultTimes(num,times)); }
	public void PlaySound2MultTimes(int num,int times)
	{ StartCoroutine(gm.au.PlaySound2MultTimes(num,times)); }
}
