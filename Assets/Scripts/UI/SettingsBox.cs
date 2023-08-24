using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
using System;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class SettingsBox : MonoBehaviour
{
    private Toggle effects;
    private Slider MusicVolume,TextSpeed,AnimationSpeed,SoundVolume;
    private TextMeshProUGUI musvalue,textvalue,animvalue,soundvalue;
    private GameManager gm=>GameManager.gm;

    private void Awake()
    {
        TextSpeed=transform.GetChild(0).GetComponent<Slider>();
        AnimationSpeed=transform.GetChild(1).GetComponent<Slider>();
        MusicVolume=transform.GetChild(2).GetComponent<Slider>();
        SoundVolume=transform.GetChild(3).GetComponent<Slider>();
        effects=transform.GetChild(4).GetChild(0).GetComponent<Toggle>();
        musvalue=MusicVolume.transform.GetChild(MusicVolume.transform.childCount-1).GetComponent<TextMeshProUGUI>();
        soundvalue=SoundVolume.transform.GetChild(SoundVolume.transform.childCount-1).GetComponent<TextMeshProUGUI>();
        textvalue=TextSpeed.transform.GetChild(TextSpeed.transform.childCount-1).GetComponent<TextMeshProUGUI>();
        animvalue=AnimationSpeed.transform.GetChild(AnimationSpeed.transform.childCount-1).GetComponent<TextMeshProUGUI>();
        TextSpeed.value=PlayerPrefs.GetFloat("TextSpeed");
        AnimationSpeed.value=PlayerPrefs.GetFloat("AnimationSpeed");
        MusicVolume.value=PlayerPrefs.GetFloat("MusicVolume");
        SoundVolume.value=PlayerPrefs.GetFloat("SoundVolume");
        effects.isOn=PlayerPrefs.GetInt("EffectsBool")==1?true:false;
    }

    public void SetEffectsValue(bool value)
    {
        PlayerPrefs.SetInt("EffectsBool",value==true?1:0);
        if(gm.mainmenu==false&&value==false) gm.background.material=null;
        else if(gm.mainmenu==false&&value==true) gm.st.SetMaterial(0,new Dictionary<string,float>{{"_WaveSpeed",2.5f},{"_WaveAmplitude",0.003f}});
    }

    public void SetMusicVolume(float value)
    {
        float _value=(float)Math.Round(value,1);
        musvalue.text=""+_value;
        PlayerPrefs.SetFloat("MusicVolume",value);
        gm.au.mixer.SetFloat("MusicVolume", Mathf.Log10(value) * 20);
    }

    public void SetSoundVolume(float value)
    {
        float _value=(float)Math.Round(value,1);
        soundvalue.text=""+_value;
        PlayerPrefs.SetFloat("SoundVolume",value);
        gm.au.mixer.SetFloat("SoundVolume", Mathf.Log10(value) * 20);
    }

    public void SetTextSpeed(float value)
    {
		value=(float)Math.Round(value,1);
		PlayerPrefs.SetFloat("TextSpeed",value);		
		textvalue.text=""+value;
        if(gm.mainmenu==false) gm.st.RefreshSavedSettings();
    }

    public void SetAnimationSpeed(float value)
    {
        float _value=(float)Math.Round(value,1);
        PlayerPrefs.SetFloat("AnimationSpeed",_value);
        animvalue.text=""+_value;
        if(gm.mainmenu==false) gm.st.RefreshSavedSettings();
    }




}
