using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using Json.Net;
using System;

[System.Serializable]
public class MaterialProperties {public string _name;public Material material; public List<string> propertyNames;}

public class Storyteller : MonoBehaviour
{
    public Animator timemachineAnimator,toyAnimator;

    public Story[] stories;
    public MaterialProperties[] props;

    public int step,Istory=0;
    public string label="A1";
    public bool isRunning,skip;
    [HideInInspector] public float speed=1f,textspeed=1f;
    [HideInInspector] public Dictionary<string,int> passedSteps;
    [HideInInspector] public List<string> Path=new List<string>();
	private TextBox _tb;
	private TextBox tb => _tb??=GameManager.gm.tb;

    private string[] labels=new string[]
    {
        "Z1","A1","A2","B1","B2","C1","C2","C1A1","C1A2","C2A1","C2A2","C2A1B1","D1",
        "D1A1","D1A2","D1A3","E1","E1A1","E1A2","E1A1B1","E1A2B1","F1","F1A1",
        "F1A2","F1A3","F1A4","F1A3B1","F1A3B2","G1","B3","G1A1","G1A2","G1A3","G1A4"
    };

    public Button skipButton;

    private GameManager gm=>GameManager.gm;

    private void Awake()
    {
        passedSteps=labels.ToDictionary(x=>x,y=>0);        
        LoadLastSteps();
		speed=1f;
    }
	private void Start()
	{
		
	}

	public void SetMaterial(int index,Dictionary<string,float> values)
    {
        if(PlayerPrefs.GetInt("EffectsBool")==0) return;

        gm.background.material=props[index].material;

        foreach(var kvp in values)
        {
            gm.background.material.SetFloat(kvp.Key,kvp.Value);
        }
    }


    public void SetMaterialValues(int index,List<double> values)
    {
        if(PlayerPrefs.GetInt("EffectsBool")==0) return;

        gm.background.material=props[index].material;

        for(int i=0;i<values.Count;i++)
        {
            gm.background.material.SetFloat(props[index].propertyNames[i],(float)values[i]);
        }
    }

    public void GetMaterialValues(out int index, out List<double> values)
    {

        values=new List<double>();
        index=0;

        if(PlayerPrefs.GetInt("EffectsBool")==0) return;

        Material mat=gm.background.material;
        foreach(MaterialProperties prop in props)
        {
            if(prop.material.name==gm.background.material.name)
            {
                index=Array.IndexOf(props,prop);
                foreach(string propname in prop.propertyNames)
                {
                    values.Add((double)gm.background.material.GetFloat(propname));
                }
                break;
            }
        }
    }

    public void RefreshSavedSettings()
    {
        speed=1f;
        textspeed=PlayerPrefs.GetFloat("TextSpeed");
		tb.twc.waitForNormalChars=0.03f/textspeed;
	}

    public void NextStep()
    {
        if(tb.twc.isShowingText==false)
        {
            stories[Istory].StartCoroutine($"{label}");
            step++;
        }
        else
			tb.twc.SkipTypewriter();
	}

    public void NextCoroutine(string _label,int istory=-1,int _step=0)
    {
        FixPassedSteps();
        Istory=istory==-1?Istory:istory;
        step=_step;
        label=_label;
        NextStep();
    }

    public void FixPassedSteps()
    {
        if(passedSteps[label]<step)
        passedSteps[label]=step;
    }

    public int[] ReturnLastSteps()
    {
        FixPassedSteps();
        int[] passtepsNow=passedSteps.Values.ToArray();
        string _passteps=PlayerPrefs.GetString("PassedSteps");
        if(_passteps.Length>0)
        {
            int[] passtepsWas=JsonNet.Deserialize<int[]>(_passteps);
            for(int i=0;i<passtepsWas.Length;i++)
            passtepsNow[i]=passtepsNow[i]>passtepsWas[i]?passtepsNow[i]:passtepsWas[i];
        }
        return passtepsNow;
    }

    public void LoadLastSteps()
    {
        string laststeps=PlayerPrefs.GetString("PassedSteps");
        if(laststeps.Length>0)
        {
            int[] _laststeps=JsonNet.Deserialize<int[]>(laststeps);
            for(int i=0;i<_laststeps.Length;i++)
            passedSteps[passedSteps.ElementAt(i).Key]=_laststeps[i];
        }
    }

    public void CoroutineBegining()
    {
        isRunning=true;   		
        if(step<passedSteps[label]) skipButton.interactable=true;
        else
        {
            skipButton.interactable=false;
            skip=false;
        }
    }

    public void CoroutineEnding()
    {
       
        isRunning=false;
  
    }

    public void SkipButton()
    {		
        skip=!skip;
        if(skip==true)
        {            
            StartCoroutine("_Skip");
        }
    }

    public void CanSkip(bool value)
    {
        skip=false;
        skipButton.interactable=value;
    }

	private IEnumerator _Skip()
	{		
		speed=3f;
		tb.twc.useTypeWriter=false;
		while(skip)
		{
			NextStep();
			yield return new WaitUntil(() => isRunning==false);
			yield return new WaitForSecondsRealtime(0.1f);
		}
			tb.twc.useTypeWriter=true;
		speed=1f;		
	}
}
