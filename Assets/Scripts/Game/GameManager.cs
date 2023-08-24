using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public delegate void Void();

public class GameManager : MonoBehaviour
{
    public static GameManager gm;

    public bool mainmenu;

    [Space(10, order = 0)]
    [Header("Главные управляющие классы",order=1)]
    [Space(5, order = 2)]
    public Storyteller st;
    public Actions act;
    public TextBox tb;
    public TextWindow tw;
    public Audio au;
    public MenuBox mbox;
    public InformationBox infoBox;
    public MainAchievement mainAchievement;

    [Space(10, order = 0)]
    [Header("Объекты",order=1)]
    [Space(5, order = 2)]
    public Transform choiceList;
    public Transform floatMessage;
    public Transform fade;
    public Transform menuBox;
    public Transform saveBox;
    public Transform itemBox;
    public Transform personBox;
    public Transform statsBox;
    public Image background;
    public Sprite[] scenes;
    public TextMeshProUGUI loger;

    private int? _language=null;
    public int language=>_language??=PlayerPrefs.GetInt("Language");

    //_language??=PlayerPrefs.GetInt("Language");

    [HideInInspector] public Person[] persons;
    [HideInInspector] public Transform[] items;
    [HideInInspector] public Transform secondBackground;
    [HideInInspector] public Dictionary<string,Person> HeroesGameobjects;
    [HideInInspector] public Dictionary<string,int> Stats;
    [HideInInspector] public Dictionary<string,float> Directions;

    private void Awake()
    {
        //Application.logMessageReceived+= HandleLog;
        Application.targetFrameRate = 60;
        Time.timeScale=1f;
        gm=this;
    }

    private void Start()
    {
        if(mainmenu==false)
        {

            persons=new Person[personBox.childCount];
            for(int i=0;i<persons.Length;i++) persons[i]=personBox.GetChild(i).GetComponent<Person>();
            items=new Transform[itemBox.childCount];
            for(int i=0;i<items.Length;i++) items[i]=itemBox.GetChild(i);

            HeroesGameobjects= new Dictionary<string,Person>();
            foreach(Person pers in persons)
            {
                HeroesGameobjects.Add(pers.Name,pers);
            }
            Directions= new Dictionary<string,float>
            {
                {"Лево",-Camera.main.orthographicSize*Camera.main.aspect+6f},
                {"Право",Camera.main.orthographicSize*Camera.main.aspect-6f},
                {"Центр",0}
            };
            Stats=new Dictionary<string,int>
            {
                {"Искренность",0},
                {"Эскапизм",0},
                {"Безумие",0},
                {"Франческа",0},
                {"Саня",0},
                {"Женя",0},
                {"Root",0}
            };

            secondBackground=background.transform.GetChild(0);


            //ЗАПУСК НОВЕЛЛЫ
            if(StaticClass.savename.Length>0)
            act.Load(StaticClass.savename);
            else
            st.NextStep();

            //Debug.Log("dataPath : " + Application.dataPath + " PersistentDataPath: "+Application.persistentDataPath);

        }

    }

    private void HandleLog(string condition, string stackTrace, LogType type)
    {
        loger.text+=">>>>>"+condition+"\r\n"+stackTrace+"\r\n";
    }

    public void InfoBoxActive(string _text="")
    {
        infoBox.SetText(_text);
        infoBox.transform.gameObject.SetActive(true);
        LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)infoBox.infoBoxText.transform.parent);
        LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)infoBox.infoBoxText.transform);
    }

    public void InfoBoxDeactive()=>infoBox.transform.gameObject.SetActive(false);



}
