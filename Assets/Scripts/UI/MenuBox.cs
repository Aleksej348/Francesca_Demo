using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuBox : MonoBehaviour
{
    public Transform menuBox,saveBox,confirmBox,settingBox,aboutbox,achieveBox;
    public SaveButton[] saveButtons;
    public int toggleValue;
    public Void confirm;
    public bool SaveOrLoad;

    public TextMeshProUGUI loadpercent;
    public Transform loadScreen,loadimage;

    private TextMeshProUGUI confirmBoxText,saveBoxText;


    private void Start()
    {
        confirmBoxText=confirmBox.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>();
        saveBoxText=saveBox.GetChild(0).GetComponent<TextMeshProUGUI>();
    }

    public void LoadSceneAsync(int num)
    {
        StartCoroutine(loadSceneAsync(num));
    }

    public IEnumerator loadSceneAsync(int num)
    {
        loadScreen.gameObject.SetActive(true);

        float progress=0,rand=0;
        for(float i=0;i<1f;i+=0.1f)
        {
            progress+=rand=Random.Range(0.05f,0.2f);
            int percent=(int)(progress/0.9f*100f);
            loadpercent.text=percent>100?100+"%":percent+"%";
            yield return new WaitForSeconds(rand);
        }

        SceneManager.LoadScene(num);
    }

    public void OpenMenuBox(bool value)
    {
        menuBox.gameObject.SetActive(value);
        GameManager.gm.st.skip=false;
    }

    public void OpenSaveBox(bool _save)
    {
        saveBox.gameObject.SetActive(true);
        menuBox.gameObject.SetActive(false);
        SaveOrLoad=_save;
        saveBoxText.text=GameManager.gm.language switch
        {
            1=>_save==true?"Сохранение":"Загрузка",
            _=>_save==true?"Save":"Load"
        };
        RefreshAll();
    }

    public void OpenSettingBox()
    {
        menuBox.gameObject.SetActive(false);
        settingBox.gameObject.SetActive(true);
    }

    public void OpenAchieveBox()
    {
        menuBox.gameObject.SetActive(false);
        achieveBox.gameObject.SetActive(true);
    }

    public void OpenAboutBox()
    {
        menuBox.gameObject.SetActive(false);
        aboutbox.gameObject.SetActive(true);
    }

    public void OpenConfirmBox(Void method, string txt)
    {
        confirm=method;
        confirmBoxText.text=txt;
        confirmBox.gameObject.SetActive(true);
    }

    public void ReturnToMenuBox()
    {
        if(achieveBox!=null)achieveBox.gameObject.SetActive(false);
        if(aboutbox!=null)aboutbox.gameObject.SetActive(false);
        saveBox.gameObject.SetActive(false);
        settingBox.gameObject.SetActive(false);
        menuBox.gameObject.SetActive(true);
    }

    public void ReturnToMainMenu()
    {
        string message=GameManager.gm.language==1?"Вы уверены, что хотите вернуться в главное меню? Все несохраненные данные будут потеряны":"Are you sure you want to return to the main menu? All unsaved data will be lost";
        OpenConfirmBox(_ReturnToMainMenu,message);
    }

    private void _ReturnToMainMenu()=>SceneManager.LoadScene(0);

    public void RefreshAll()
    {
        foreach(SaveButton svb in saveButtons)
        {
            svb.Refresh();
        }
    }

    public void Confirm(bool accept)
    {
        if(accept==true) confirm();
        confirmBox.gameObject.SetActive(false);
    }

    public void LoadAtMainMenu(string name)
    {
        StaticClass.savename=name;
        LoadSceneAsync(1);
    }






}
