using System.Collections;
using UnityEngine;
using TMPro;
using Febucci.UI;


public class TextBox : MonoBehaviour
{
	[HideInInspector] public TypewriterByCharacter twc;
	public TextMeshProUGUI Name,Content;
    private AudioSource voice;   

    private GameManager gm=>GameManager.gm;

    private void Awake()
    {
        Content=transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        Name=transform.GetChild(1).GetComponent<TextMeshProUGUI>();
		twc=Content.GetComponent<TypewriterByCharacter>();		
		twc.waitForNormalChars=0.03f/PlayerPrefs.GetFloat("TextSpeed");
		//voice=GetComponent<AudioSource>();

	}

	 public void Say(Person person,string content,bool instantly=false)
	 {
         Color col=person.namesColor;
         Name.color=new Color(col.r,col.g,col.b,1f);
		Name.text = gm.language == 1 ? person.Name : person.Name switch
		{
			"Андрей"=>"Andrey",
			"Андрюша"=>"Andrusha",
			"Женя"=>"Shenya",
			"Саня"=>"Sanya",
			"Федя"=>"Fedya",
			"Франческа"=>"Francesca",
			"Таня"=>"Tanya",
			"Девочка"=>"Girl",
			"Женщина"=>"Woman",
			_ => person.Name
		};
		twc.ShowText(content);

	}

     private int WordsCount(string text,string word)=>(text.Length-text.Replace(word,"").Length)/text.Length;

     public void Say(string name,string content,bool instantly=false)
     {
         Name.color=new Color(0.8f,0.8f,0.8f,1f);
         Name.text=name;
		twc.ShowText(content);
	}

	 public void Think(string content,bool instantly=false)
	 {
         Name.text="";
		twc.ShowText(content);
	}	 




}
