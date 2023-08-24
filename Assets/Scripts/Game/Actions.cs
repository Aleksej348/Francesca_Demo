  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Linq;
using UnityEngine.Events;
using Json.Net;
using UnityTools;

public class Actions : MonoBehaviour
{
    public int turn;
    public bool CanTap=true;

    private Scrollbar messengerScroll;
    private GameManager gm=>GameManager.gm;
	private Color colorwhite=Color.white;

	public IEnumerator Glitch(int scene,bool aspect = false)
	{
		turn++;
		CanTap=false;
		Material mat = gm.background.material;
		Story story = gm.st.stories[0];
		story.Think("");
		BackgroundColoring(Color.black,0.1f);
		yield return new WaitForSecondsRealtime(0.05f);
		story.HideSecondScene();
		story.PlaySound(22);
		yield return new WaitForSecondsRealtime(0.2f);
		BackgroundUncoloring(0.1f);
		yield return new WaitForSecondsRealtime(0.2f);
		BackgroundColoring(Color.black,0.1f);
		yield return new WaitForSecondsRealtime(0.3f);
		Scene(scene,true,aspect);
		BackgroundUncoloring(0.4f);
		yield return new WaitForSecondsRealtime(0.6f);
		gm.background.material=mat;
		turn--;
		if(turn==0&&gm.choiceList.gameObject.activeInHierarchy==false)
			CanTap=true;
	}
	public void BackgroundColoring(Color color,float time = 1f)
	{ gm.background.material=null; StartCoroutine(Tools.ChangeImageColorInTime(gm.background,gm.background.color,color,time)); }
	public void BackgroundUncoloring(float time)
	{ gm.background.material=null; StartCoroutine(Tools.ChangeImageColorInTime(gm.background,gm.background.color,new Color(1f,1f,1f,1f),time)); }

	public IEnumerator Mirror(string name,Vector3 from,Vector3 where)
    {
		Transform hero = gm.HeroesGameobjects[ConvertReduction(name)].transform;
		yield return StartCoroutine(Tools.ChangeScaleInTime(hero,from,where,0.2f));
		hero.localScale=where;
	}
	public IEnumerator Mirror(string name,Vector3 where)
	{
		Transform hero = gm.HeroesGameobjects[ConvertReduction(name)].transform;
		yield return StartCoroutine(Tools.ChangeScaleInTime(hero,hero.localScale,where,0.2f));
		hero.localScale=where;
	}
	public IEnumerator Thrill(string name)
    {
        name=ConvertReduction(name);

        Transform heroes=gm.HeroesGameobjects[name].transform;

        for(float i=0;i<0.2f;i+=0.01f)
        {
            if(i<=0.05f)
            heroes.rotation=Quaternion.Euler(0f,0f,heroes.rotation.eulerAngles.z-(2f/0.05f*0.01f));
            else if(i>0.05f&&i<=0.1f)
            heroes.rotation=Quaternion.Euler(0f,0f,heroes.rotation.eulerAngles.z+(4f/0.05f*0.01f));
            else if(i>0.1f&&i<=0.15f)
            heroes.rotation=Quaternion.Euler(0f,0f,heroes.rotation.eulerAngles.z-(4f/0.05f*0.01f));
            else if(i>0.15f&&i<=0.2f)
            heroes.rotation=Quaternion.Euler(0f,0f,heroes.rotation.eulerAngles.z+(2f/0.05f*0.01f));
            yield return new WaitForSeconds(0.01f);
        }

        heroes.rotation=Quaternion.Euler(0f,0f,0f);
    }

    private IEnumerator Shaker()
    {
        Transform _background=gm.background.transform;
        Transform heroes=gm.persons[0].transform.parent;

        for(float i=0;i<0.2f;i+=0.01f)
        {
            if(i<0.1f)
            {
                _background.localScale=new Vector3(_background.localScale.x+(0.3f/0.1f*0.01f),_background.localScale.y+(0.3f/0.1f*0.01f),0);
                if(i<0.05f){
                    _background.rotation=Quaternion.Euler(0f,0f,_background.rotation.eulerAngles.z+(5f/0.05f*0.01f));
                    heroes.rotation=Quaternion.Euler(0f,0f,heroes.rotation.eulerAngles.z-(2f/0.05f*0.01f));}
                else{
                    _background.rotation=Quaternion.Euler(0f,0f,_background.rotation.eulerAngles.z-(10f/0.05f*0.01f));
                    heroes.rotation=Quaternion.Euler(0f,0f,heroes.rotation.eulerAngles.z+(4f/0.05f*0.01f));}
            }
            else
            {
                _background.localScale=new Vector3(_background.localScale.x-(0.3f/0.1f*0.01f),_background.localScale.y-(0.3f/0.1f*0.01f),0);
                if(i<0.15f){
                    _background.rotation=Quaternion.Euler(0f,0f,_background.rotation.eulerAngles.z+(10f/0.05f*0.01f));
                    heroes.rotation=Quaternion.Euler(0f,0f,heroes.rotation.eulerAngles.z-(4f/0.05f*0.01f));}
                else{
                    _background.rotation=Quaternion.Euler(0f,0f,_background.rotation.eulerAngles.z-(5f/0.05f*0.01f));
                    heroes.rotation=Quaternion.Euler(0f,0f,heroes.rotation.eulerAngles.z+(2f/0.05f*0.01f));}
            }
            yield return new WaitForSeconds(0.01f);
        }
        _background.localScale=new Vector3(1f,1f,1f);
        _background.rotation=Quaternion.Euler(0f,0f,0f);
        heroes.rotation=Quaternion.Euler(0f,0f,0f);
    }

    public IEnumerator LongShaker(float time=1f,float power=1f)
    {
        turn++;CanTap=false;

        Transform _background=gm.background.transform;
        Transform heroes=gm.persons[0].transform.parent;

        for(float x=0;x<time;x+=0.2f)
        {
            _background.rotation=Quaternion.Euler(0f,0f,0f);
            heroes.rotation=Quaternion.Euler(0f,0f,0f);

            for(float i=0;i<0.2f;i+=0.01f)
            {
                if(i<0.1f)
                {
                    if(i<0.05f){
                        _background.rotation=Quaternion.Euler(0f,0f,_background.rotation.eulerAngles.z+(((5f*power)/0.05f)*0.01f));
                        heroes.rotation=Quaternion.Euler(0f,0f,heroes.rotation.eulerAngles.z-(((4f*power)/0.05f)*0.01f));}
                    else{
                        _background.rotation=Quaternion.Euler(0f,0f,_background.rotation.eulerAngles.z-(((10f*power)/0.05f)*0.01f));
                        heroes.rotation=Quaternion.Euler(0f,0f,heroes.rotation.eulerAngles.z+(((8f*power)/0.05f)*0.01f));}
                }
                else
                {
                    if(i<0.15f){
                        _background.rotation=Quaternion.Euler(0f,0f,_background.rotation.eulerAngles.z+(((10f*power)/0.05f)*0.01f));
                        heroes.rotation=Quaternion.Euler(0f,0f,heroes.rotation.eulerAngles.z-(((8f*power)/0.05f)*0.01f));}
                    else{
                        _background.rotation=Quaternion.Euler(0f,0f,_background.rotation.eulerAngles.z-(((5f*power)/0.05f)*0.01f));
                        heroes.rotation=Quaternion.Euler(0f,0f,heroes.rotation.eulerAngles.z+(((4f*power)/0.05f)*0.01f));}
                }
                yield return new WaitForSeconds(0.01f);
            }
        }

        _background.rotation=Quaternion.Euler(0f,0f,0f);
        heroes.rotation=Quaternion.Euler(0f,0f,0f);

        turn--;
        if(turn==0&&gm.choiceList.gameObject.activeInHierarchy==false)
        CanTap=true;
    }

    public void Messenger(int messenger,int message)
    {
        Transform monitor=gm.secondBackground.GetChild(0);
        Transform _messenger=monitor.GetChild(messenger);
        DeactiveChilds(monitor); _messenger.gameObject.SetActive(true);
        Transform messengerContent=_messenger.GetChild(0).GetChild(0);
        if(message==0) DeactiveChilds(messengerContent);
        messengerContent.GetChild(message).gameObject.SetActive(true);
        messengerScroll=_messenger.GetChild(1).GetComponent<Scrollbar>();
        Invoke("MessengerScroll",0.05f);
    }

    public void MessengerScroll()=>messengerScroll.value=0;

    public void SecondScene(int i)
    {
        gm.secondBackground.gameObject.SetActive(true);
        DeactiveChilds(gm.secondBackground);
        gm.secondBackground.GetChild(i).gameObject.SetActive(true);
        if(i==0) DeactiveChilds(gm.secondBackground.GetChild(0));
    }

    public void Scene(int i,bool alone=true,bool preserveAspect=false)
    {
        gm.background.sprite=gm.scenes[i];
		gm.background.preserveAspect=preserveAspect;
        if(alone==true)
        gm.background.transform.GetChild(0).gameObject.SetActive(false);
    }

    public void SetStats(Dictionary<string,int> _stats)
    {
        foreach(var Pair in _stats)
        {
            foreach(var stat in gm.Stats)
            {
                if(Pair.Key==stat.Key)
                {
                    gm.Stats[stat.Key]+=Pair.Value;
                    break;
                }
            }
        }
        SandStatsMessage(_stats);
    }

    private void SandStatsMessage(Dictionary<string,int> _stats)
    {
        gm.floatMessage.gameObject.SetActive(true);
        DeactiveChilds(gm.floatMessage);

        foreach(var stat in _stats)
        {
            if(stat.Key!="Root")
            {
                foreach(Transform child in gm.floatMessage)
                {
                    if(child.gameObject.activeInHierarchy==false)
                    {
                        string _color=stat.Key switch
                        {
                            "Саня" => "#E02C37",
                            "Женя" => "#FD9A00",
                            "Франческа" => "#6AEC49",
                            "Искренность" => "#A8FFFC",
                            "Безумие" => "#E83BEA",
                            "Эскапизм" => "#32E9AB",
                            _ => "#E5E5E5"
                        };
                        string _name = gm.language == 1 ? stat.Key : stat.Key switch
                        {
                            "Саня" => "Sanya",
                            "Женя" => "Shenya",
                            "Франческа" => "Francesca",
                            "Искренность" => "Sincerity",
                            "Безумие" => "Madness",
                            "Эскапизм" => "Escapism",
                            _ => stat.Key
                        };
                        child.GetComponent<TextMeshProUGUI>().text=stat.Value switch
                        {
                            >0 => $"<color={_color}>{_name}</color> +{stat.Value}",
                            <0 => $"<color={_color}>{_name}</color> {stat.Value}",
                            _ => $"<color={_color}>{_name}</color>"
                        };
                        child.gameObject.SetActive(true);
                        break;
                    }
                }
            }
        }
    }

    public void SandInfoMessage(string info)
    {
        gm.floatMessage.gameObject.SetActive(true);
        DeactiveChilds(gm.floatMessage);
        gm.floatMessage.GetChild(0).GetComponent<TextMeshProUGUI>().text=info;
        gm.floatMessage.GetChild(0).gameObject.SetActive(true);
    }

    public void ChoiceList(string[] texts, int[] istories, string[] labels, int[] steps, bool[] musts=null, string[] comments=null)
    {
        gm.st.skip=false;
        gm.st.skipButton.interactable=false;
        gm.st.FixPassedSteps();
        CanTap=false;
        gm.choiceList.gameObject.SetActive(true);
        DeactiveChilds(gm.choiceList);

        for(int i=0;i<texts.Length;i++)
        {
            ChoiceButton button=gm.choiceList.GetChild(i).GetComponent<ChoiceButton>();
            button.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text=texts[i];
            button.istory=istories[i];
            button._label=labels[i];
            button._step=steps[i];
            button.must=musts?[i]??true;
            button.comment=comments?[i]??"";
            button.gameObject.SetActive(true);
        }
    }

    public void Fade(float pause=2f,string _text="")
    {
        StartCoroutine(fade(pause,_text));
    }

    public void Begin()
    {
        StartCoroutine("begin");
    }

    private IEnumerator begin()
    {
        float unit=0.01f*gm.st.speed;
        turn++;CanTap=false;
        Image blackColor=gm.fade.GetComponent<Image>();
        TextMeshProUGUI _text_=gm.fade.GetChild(0).GetComponent<TextMeshProUGUI>();
        _text_.text=gm.language==1?"Андрей…": "Andrey…";
        blackColor.color=new Color(0,0,0,1f);
        gm.fade.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f/gm.st.speed);
        for(float i=1f;i>0;i-=unit)
        {
            blackColor.color=new Color(0,0,0,i);
            _text_.color=new Color(1f,1f,1f,i);
            yield return new WaitForSeconds(0.01f);
        }
        gm.fade.gameObject.SetActive(false);
        turn--;
        if(turn==0&&gm.choiceList.gameObject.activeInHierarchy==false)
        CanTap=true;
    }

    public IEnumerator fade(float pause=2f,string _text="")
    {
        float unit=0.01f*gm.st.speed;
        turn++;CanTap=false;
        Image blackColor=gm.fade.GetComponent<Image>();
        TextMeshProUGUI _text_=gm.fade.GetChild(0).GetComponent<TextMeshProUGUI>();
        _text_.text=_text;
        blackColor.color=new Color(0,0,0,0);
        gm.fade.gameObject.SetActive(true);
        for(float i=0;i<1f;i+=unit)
        {
            blackColor.color=new Color(0,0,0,i);
            _text_.color=new Color(1f,1f,1f,i);
            yield return new WaitForSeconds(0.01f);
        }
        blackColor.color=new Color(0,0,0,1f);
        _text_.color=new Color(1f,1f,1f,1f);
        yield return new WaitForSeconds(pause/gm.st.speed);
        for(float i=1f;i>0;i-=unit)
        {
            blackColor.color=new Color(0,0,0,i);
            _text_.color=new Color(1f,1f,1f,i);
            yield return new WaitForSeconds(0.01f);
        }
        gm.fade.gameObject.SetActive(false);
        turn--;
        if(turn==0&&gm.choiceList.gameObject.activeInHierarchy==false)
        CanTap=true;
    }

	public IEnumerator ColorFade(Color col,float pause)
	{
		turn++;
		CanTap=false;
		Image fadeImg = gm.fade.GetComponent<Image>();
		gm.fade.GetChild(0).GetComponent<TextMeshProUGUI>().text="";
		gm.fade.gameObject.SetActive(true);
		yield return StartCoroutine(Tools.ChangeImageColorInTime(fadeImg,new Color(col.r,col.g,col.b,0),col,1f));
		yield return new WaitForSecondsRealtime(pause);
		yield return StartCoroutine(Tools.ChangeImageColorInTime(fadeImg,col,new Color(col.r,col.g,col.b,0),1f));
		gm.fade.gameObject.SetActive(false);
		turn--;
		if(turn==0&&gm.choiceList.gameObject.activeInHierarchy==false)
			CanTap=true;
	}

	public IEnumerator SceneWithFade(int scene,float pause = 2f, string text = "",bool alone = true)
	{
		turn++;
		CanTap=false;
		float speed = gm.st.speed;
		float unit = 1f/speed;
		Image fadeimg = gm.fade.GetComponent<Image>();
		TextMeshProUGUI fadetext = gm.fade.GetChild(0).GetComponent<TextMeshProUGUI>();
		fadetext.text=text;
		StartCoroutine(Tools.ChangeTMPColorInTime(fadetext,new Color(0,0,0,0),new Color(1f,1f,1f,1f),unit));
		yield return StartCoroutine(Tools.ChangeImageColorInTime(fadeimg, new Color(0,0,0,0),new Color(0,0,0,1f),unit));
		fadeimg.color=new Color(0,0,0,1f);
		fadetext.color=new Color(1f,1f,1f,1f);
		Scene(scene,alone);
		yield return new WaitForSeconds(pause/speed);
		StartCoroutine(Tools.ChangeTMPColorInTime(fadetext,new Color(1f,1f,1f,1f),new Color(0,0,0,0),unit));
		yield return StartCoroutine(Tools.ChangeImageColorInTime(fadeimg,new Color(0,0,0,1f),new Color(0,0,0,0),unit));
		gm.fade.gameObject.SetActive(false);
		turn--;
		if(turn==0&&gm.choiceList.gameObject.activeInHierarchy==false)
			CanTap=true;
	}

	public IEnumerator FadeDown(string txt="",float pause=2f)
	{
		float unit = 0.01f;
		turn++;
		CanTap=false;
		Transform fade = gm.fade;
		Image blackColor = fade.GetComponent<Image>();
		TextMeshProUGUI _text = fade.GetChild(0).GetComponent<TextMeshProUGUI>();
		_text.text=txt;
		blackColor.color=new Color(0, 0, 0, 1f);
		fade.gameObject.SetActive(true);
		yield return new WaitForSecondsRealtime(pause);
		for(float i = 1f;i>0;i-=unit)
		{
			blackColor.color=new Color(0, 0, 0, i);
			_text.color=new Color(1f, 1f, 1f, i);
			yield return new WaitForSecondsRealtime(0.01f);
		}
		fade.gameObject.SetActive(false);
		turn--;
		if(turn==0&&gm.choiceList.gameObject.activeInHierarchy==false)
			CanTap=true;
	}


	public void Dissolve(string name,int emotion)
    {
        name=ConvertReduction(name);
        Transform hero=gm.HeroesGameobjects[name].transform;
        Transform sprites=hero.GetChild(0);
        SpriteRenderer oldimg=GetActiveChild(sprites)?.GetComponent<SpriteRenderer>()??sprites.GetChild(0).GetComponent<SpriteRenderer>();
        SpriteRenderer newimg=sprites.GetChild(emotion).GetComponent<SpriteRenderer>();

        if(gm.st.skip==false&&oldimg!=newimg) StartCoroutine(routine:dissolve(oldimg,newimg));
        else
        {
            oldimg.gameObject.SetActive(false);
            newimg.color=new Color(1f,1f,1f,1f);
            newimg.gameObject.SetActive(true);
        }
    }


    private IEnumerator dissolve(SpriteRenderer oldimg, SpriteRenderer newimg)
    {
        float unit=0.02f;
        turn++;CanTap=false;
        newimg.sortingOrder+=1;
        newimg.gameObject.SetActive(true);
        for(float i=0;i<1f;i+=unit)
        {
            oldimg.color=new Color(1f,1f,1f,1f-i*0.5f);
            newimg.color=new Color(1f,1f,1f,0.1f+i);
            yield return new WaitForSeconds(0.01f);
        }
        oldimg.gameObject.SetActive(false);
        newimg.color=new Color(1f,1f,1f,1f);
        newimg.sortingOrder-=1;
        turn--;
        if(turn==0&&gm.choiceList.gameObject.activeInHierarchy==false)
        CanTap=true;
    }

    public void StartDissolve(string name,int emotion,bool deactivate=true)
    {
        name=ConvertReduction(name);
        Transform hero=gm.HeroesGameobjects[name].transform;
        Transform sprites=hero.GetChild(0);
        if(deactivate==true) DeactiveChilds(sprites);
        hero.gameObject.SetActive(true);
        if(emotion>sprites.childCount-1) emotion=0;
        Transform _emotion=sprites.GetChild(emotion);
        StartCoroutine(routine:startDissolve(_emotion.GetComponent<SpriteRenderer>(),Color.white));
    }
	public void StartDissolve(string name,int emotion,Color color)
	{
		name=ConvertReduction(name);
		Transform hero = gm.HeroesGameobjects[name].transform;
		Transform sprites = hero.GetChild(0);
		DeactiveChilds(sprites);
		hero.gameObject.SetActive(true);
		if(emotion>sprites.childCount-1)
			emotion=0;
		Transform _emotion = sprites.GetChild(emotion);
		StartCoroutine(routine: startDissolve(_emotion.GetComponent<SpriteRenderer>(),color));
	}

	public void EndDissolve(string name,bool active=false)
    {
        name=ConvertReduction(name);
        Transform hero=gm.HeroesGameobjects[name].transform;
        Transform sprites=hero.GetChild(0);
        SpriteRenderer emotion=GetActiveChild(sprites)?.GetComponent<SpriteRenderer>()??sprites.GetChild(0).GetComponent<SpriteRenderer>();
        StartCoroutine(routine:endDissolve(emotion,active));
    }

    private IEnumerator startDissolve(SpriteRenderer img,Color col)
    {
        float speed=gm.st.speed;
        float unit=0.02f*speed;
        turn++;CanTap=false;

        img.gameObject.SetActive(true);
        for(float i=0;i<1f;i+=unit)
        {
            img.color=new Color(col.r,col.g,col.b,i);
            yield return new WaitForSeconds(0.01f);
        }
		img.color=new Color(col.r,col.g,col.b,1f);
		turn--;
        if(turn==0&&gm.choiceList.gameObject.activeInHierarchy==false)
        CanTap=true;
    }

    private IEnumerator endDissolve(SpriteRenderer img,bool active)
    {
        float speed=gm.st.speed;
        float unit=0.02f*speed;
        turn++;CanTap=false;
		Color col = img.color;
        for(float i=1f;i>0;i-=unit)
        {
            img.color=new Color(col.r,col.g,col.b,i);
            yield return new WaitForSeconds(0.01f);
        }
        img.gameObject.SetActive(false);
        img.transform.parent.parent.gameObject.SetActive(active);
        turn--;
        if(turn==0&&gm.choiceList.gameObject.activeInHierarchy==false)
        CanTap=true;
    }

    public void Show(string name,string direction,Vector3 _scale,Vector3 offset)
    {
        name=ConvertReduction(name);
        Transform hero=gm.HeroesGameobjects[name].transform;
        hero.localScale=_scale==Vector3.zero?new Vector3(1f,1f,0):_scale;
        hero.position=new Vector2(gm.Directions[direction]+offset.x,0+offset.y);

    }

	public IEnumerator timeTravel(string text,int scene,int music,int item=3)
	{
		Story story = new Story();
		float speed = gm.st.speed;
		turn++;
		CanTap=false;
		story.SetAllButtons(false);
		story.StopMusic();
		story.Item(item);
		story.PlaySound(11);
		yield return new WaitForSecondsRealtime(9f/speed);
		Fade(5f,text);
		yield return new WaitForSecondsRealtime(3f/speed);
		Scene(scene);
		story.PlayMusic(music,1f,true);
		story.st.SetMaterial(0,new Dictionary<string,float> { { "_WaveSpeed",2.5f },{ "_WaveAmplitude",0.003f } });
		turn--;
		if(turn==0&&gm.choiceList.gameObject.activeInHierarchy==false)
			CanTap=true;

	}

	public void Zoom(string name,Vector3 from,Vector3 where,float time)
    {
        name=ConvertReduction(name);
        StartCoroutine(routine:zoom(name,from,where,time));
    }

    public void Zoom(string name,Vector3 where,float time)
    {
        name=ConvertReduction(name);
        StartCoroutine(routine:zoom(name:name,where:where,time:time));
    }

	public IEnumerator zoom(Transform trans,Vector3 where,float time)
	{
		float speed = gm.st.speed;
		turn++;
		CanTap=false;
		yield return StartCoroutine(Tools.ChangeScaleInTime(trans,trans.localScale,where,time/speed));
		turn--;
		if(turn==0&&gm.choiceList.gameObject.activeInHierarchy==false)
			CanTap=true;
	}

    private IEnumerator zoom(string name,Vector3 from=default(Vector3),Vector3 where=default(Vector3),float time=1f)
    {
        float speed=gm.st.speed;
        turn++;CanTap=false;
        Transform hero=gm.HeroesGameobjects[name].transform;
        from=from==default(Vector3)?hero.localScale:from;
		yield return StartCoroutine(Tools.ChangeScaleInTime(hero,from,where,time/speed));
        turn--;
        if(turn==0&&gm.choiceList.gameObject.activeInHierarchy==false)
        CanTap=true;
    }

    public void Move(string name,string from,string where,float time=1f,Vector2 offsetfrom=default(Vector2),Vector2 offsetwhere=default(Vector2))
    {
        name=ConvertReduction(name);
        StartCoroutine(routine:move(name,from,where,time,offsetfrom,offsetwhere));
    }
	public void Move(string name, string where, float time = 1f, Vector2 offset = default(Vector2))
	{
		name=ConvertReduction(name);
		StartCoroutine(routine: move(name, where, time, offset));
	}


	private IEnumerator move(string name,string from,string where,float time=1f,Vector2 offsetfrom=default(Vector2),Vector2 offsetwhere=default(Vector2))
    {
        float speed=gm.st.speed;
        turn++;CanTap=false;
        Transform hero=gm.HeroesGameobjects[name].transform;
        Vector2 fromvector=new Vector2(gm.Directions[from],0)+offsetfrom;
        Vector2 wherevector=new Vector2(gm.Directions[where],0)+offsetwhere;
		yield return StartCoroutine(Tools.ChangePositionInTime(hero,fromvector,wherevector,time/speed));
        turn--;
        if(turn==0&&gm.choiceList.gameObject.activeInHierarchy==false)
        CanTap=true;

    }

	private IEnumerator move(string name, string where, float time = 1f, Vector2 offset = default(Vector2))
	{
		float speed = gm.st.speed;
		turn++;
		CanTap=false;
		Transform hero = gm.HeroesGameobjects[name].transform;
		Vector2 wherevector = new Vector2(gm.Directions[where], 0)+offset;
		yield return StartCoroutine(Tools.ChangePositionInTime(hero, hero.position, wherevector, time/speed));
		turn--;
		if(turn==0&&gm.choiceList.gameObject.activeInHierarchy==false)
			CanTap=true;

	}

    public void Say(string name,string content,bool punch=false,bool instantly=false)
    {
        name=ConvertReduction(name);
        if(punch==true)
        StartCoroutine(routine:Punch(gm.HeroesGameobjects[name].transform));

        if(gm.HeroesGameobjects.ContainsKey(name)==true) gm.tb.Say(gm.HeroesGameobjects[name], content, instantly);
        else gm.tb.Say(name,content,instantly);
    }

    private void Listen(string name)
    {
        SpriteRenderer emotion=GetActiveChild(gm.HeroesGameobjects[name].transform.GetChild(0))?.GetComponent<SpriteRenderer>()??
        gm.HeroesGameobjects[name].transform.GetChild(0).GetChild(0).GetComponent<SpriteRenderer>();
        if(emotion.color.r>=1f)
        StartCoroutine(routine:Blackout(emotion));
    }

    private IEnumerator Blackout(SpriteRenderer img)
    {
        float speed=0.01f*gm.st.speed;
        for(float i=1f;i>0.5f;i-=speed)
        {
            img.color=new Color(img.color.r-(0.4f/0.5f*speed),img.color.g-(0.4f/0.5f*speed),img.color.b-(0.4f/0.5f*speed),1f);

            Transform parent=img.transform.parent.parent;
            parent.localScale=new Vector3(parent.localScale.x-(0.1f/0.5f*speed),parent.localScale.y-(0.1f/0.5f*speed),0);

            parent.position=new Vector3(parent.position.x,parent.position.y-(0.2f/0.5f*speed),0);
            yield return new WaitForSeconds(0.01f);
        }
    }

    private void Talk(string name,bool punch)
    {
        Transform hero=gm.HeroesGameobjects[name].transform;
        Transform sprites=hero.GetChild(0);
        SpriteRenderer _sprite=GetActiveChild(sprites)?.GetComponent<SpriteRenderer>()??
        sprites.GetChild(0).GetComponent<SpriteRenderer>();
        if(_sprite.color.r<1f) StartCoroutine(routine:Talking(_sprite,punch));
        else if(punch==true) StartCoroutine(routine:Punch(hero));
    }

    private IEnumerator Punch(Transform pers)
    {
        Vector3 old=pers.localScale;
        float step=0.05f/0.05f*0.01f;
        float stepx=old.x>0?step:-step;
        float stepy=old.y>0?step:-step;
        for(float i=0;i<0.1f;i+=0.01f)
        {
            if(i<0.05f)
            pers.localScale=new Vector3(pers.localScale.x+stepx,
            pers.localScale.y+stepy,0);
            else
            pers.localScale=new Vector3(pers.localScale.x-stepx,
            pers.localScale.y-stepy,0);
            yield return new WaitForSeconds(0.01f);
        }
        pers.localScale=new Vector3(old.x,old.y,0);
    }

    private IEnumerator Talking(SpriteRenderer img,bool punch)
    {
        float speed=0.01f*gm.st.speed;
        Transform parent=img.transform.parent.parent;

        for(float i=1f;i>0.5f;i-=speed)
        {
            img.color=new Color(img.color.r+(0.4f/0.5f*speed),img.color.g+(0.4f/0.5f*speed),img.color.b+(0.4f/0.5f*speed),1f);

            parent.localScale=new Vector3(parent.localScale.x+(0.1f/0.5f*speed),
            parent.localScale.y+(0.1f/0.5f*speed),0);

            parent.position=new Vector3(parent.position.x,parent.position.y+(0.2f/0.5f*speed),0);
            yield return new WaitForSeconds(0.01f);
        }
        if(punch==true)StartCoroutine(routine:Punch(parent));
    }

    public Transform GetChildAtTag(Transform parent,string _tag)
    {
        foreach(Transform child in parent)
        {
            if(child.tag==_tag) return child;
        }
        return null;
    }

    public Transform GetActiveChild(Transform parent)
    {
        foreach(Transform child in parent)
        {
            if(child.gameObject.activeInHierarchy==true)
            {
                return child;
            }
        }
        return null;
    }

    public Transform GetInactiveChild(Transform parent)
    {
        foreach(Transform child in parent)
        {
            if(child.gameObject.activeInHierarchy==false)
            {
                return child;
            }
        }
        return null;
    }

    public string ConvertReduction(string reduction)
    {
        return reduction switch
        {
            "a" => "Андрей",
            "aa" => "Андрюша",
            "sh" => "Женя",
            "s" => "Саня",
            "f" => "Федя",
            "fr" => "Франческа",
            "t" => "Таня",
            "girl" => "Девочка",
            "woman" => "Женщина",
            _ => reduction
        };
    }

    public void DeactiveChilds(Transform parent)
    {
        foreach(Transform child in parent)
        {
            child.gameObject.SetActive(false);
        }
    }

    private void DeactiveChildsExcept(Transform parent, int exception)
    {
        for(int i=0;i<parent.childCount;i++)
        {
            if(i==exception) parent.GetChild(i).gameObject.SetActive(true);
            else parent.GetChild(i).gameObject.SetActive(false);
        }
    }

    public void SaveGame(string name)
    {
		 Game _game=new Game();
         int L=gm.persons.Length;
         _game.persActive=new bool[L];
         _game.persEmotions=new int[L];
         _game.persColor=new string[L];
         _game.persPos=new Vector3[L];
         _game.persScale=new Vector3[L];
         _game.stats=new int[7];
         for(int i=0;i<L;i++)
         {
             Transform hero=gm.persons[i].transform;
             Transform sprites=hero.GetChild(0);
             _game.persActive[i]=hero.gameObject.activeInHierarchy;
             _game.persEmotions[i]=GetActiveChild(sprites)?.GetSiblingIndex()??0;
             _game.persPos[i]=hero.position;
             _game.persScale[i]=hero.localScale;
             Color _color=GetActiveChild(sprites)?.GetComponent<SpriteRenderer>().color??Color.white;
             _game.persColor[i]="#"+ColorUtility.ToHtmlStringRGBA(_color);
         }
         for(int i=0;i<7;i++)
         {
             _game.stats[i]=gm.Stats.ElementAt(i).Value;
         }
         gm.st.GetMaterialValues(out _game.Imaterial,out _game.materialValues);
         _game.tboxContent=gm.tb.Content.text;
         _game.tboxName=gm.tb.Name.text;
         _game.Istory=gm.st.Istory;
         _game.step=gm.choiceList.gameObject.activeInHierarchy?gm.st.step-1:gm.st.step;
         _game.label=gm.st.label;
         _game.scene=Array.IndexOf(gm.scenes,gm.background.sprite);
         _game.secondscene=GetActiveChild(gm.secondBackground)?.GetSiblingIndex()??-1;
		_game.Iitem=Tools.GetActiveChild(gm.itemBox)?.GetSiblingIndex()??-1;		
		_game.music=Array.IndexOf(gm.au.musicClips,gm.au.music.clip);
		_game.musicPitch=gm.au.music.pitch;
		_game.sceneSpriteAspect=gm.background.preserveAspect;
		_game.path=gm.st.Path;		
         if(gm.tw.IsActive()==true) _game.textWindowContent=gm.tw.GetAllContent();
         string jsv=JsonNet.Serialize(_game);
         PlayerPrefs.SetString($"{name}",jsv);
         PlayerPrefs.SetString("LastSave",name);
         string laststeps=JsonNet.Serialize(gm.st.ReturnLastSteps());
         PlayerPrefs.SetString("PassedSteps",laststeps);
    }

    public void Load(string name)
    {
        string jsv=PlayerPrefs.GetString($"{name}");
        Game _game=JsonNet.Deserialize<Game>(jsv);

        for(int i=0;i<gm.persons.Length;i++)
        {
            if(i<_game.persPos.Length)
            {
                Transform hero=gm.persons[i].transform;
                Transform sprites=hero.GetChild(0);
                hero.gameObject.SetActive(_game.persActive[i]);
                hero.position=_game.persPos[i];
                hero.localScale=_game.persScale[i];
                for(int abc=0;abc<sprites.childCount;abc++)
                {
                    if(abc==_game.persEmotions[i])
                    {
                        sprites.GetChild(abc).gameObject.SetActive(true);
                        Color _color=Color.red;
                        ColorUtility.TryParseHtmlString(_game.persColor[i],out _color);
                        sprites.GetChild(abc).GetComponent<SpriteRenderer>().color=_color;
                    }
                    else sprites.GetChild(abc).gameObject.SetActive(false);
                }
            }
            else gm.persons[i].transform.gameObject.SetActive(false);
        }
        for(int i=0;i<7;i++)
        {
            gm.Stats[gm.Stats.ElementAt(i).Key]=_game.stats[i];
        }
        if(gm.HeroesGameobjects.ContainsKey(_game.tboxName)) gm.tb.Name.color=gm.HeroesGameobjects[_game.tboxName].namesColor;
        else gm.tb.Name.color=Color.white;
        gm.tb.Content.text=_game.tboxContent;
        gm.tb.Name.text=_game.tboxName;
        gm.st.SetMaterialValues(_game.Imaterial,_game.materialValues);
        gm.st.step=_game.step;
        gm.st.Istory=_game.Istory;
        gm.st.label=_game.label;
        gm.st.Path=_game.path;
        Scene(_game.scene,true,_game.sceneSpriteAspect);
        if(_game.secondscene>=0) SecondScene(_game.secondscene);
		DeactiveChilds(gm.itemBox);
		if(_game.Iitem>=0) gm.items[_game.Iitem].gameObject.SetActive(true);
        if(_game.textWindowContent.Count>0)
        {
            gm.tw.WindowActive(true);
            gm.tw.SetAllContent(_game.textWindowContent);
        }
        else gm.tw.window.gameObject.SetActive(false);
		gm.au.PlayMusic(number:_game.music,_pitch:(float)_game.musicPitch);		
        gm.choiceList.gameObject.SetActive(false);
        gm.menuBox.gameObject.SetActive(false);
        gm.saveBox.gameObject.SetActive(false);		
		CanTap=true;
		turn=0;
	}
}
