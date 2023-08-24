using Febucci.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextWindow : MonoBehaviour
{
	private Scrollbar vertScroll;
	public Transform window, scrollview, content;
	private VerticalLayoutGroup vlg;
	private List<TextMeshProUGUI> textchilds = new List<TextMeshProUGUI>();
	private Animator anim;

	private GameManager gm => GameManager.gm;

	private void Awake()
	{
		window=transform.GetChild(0);
		scrollview=window.GetChild(0);
		content=scrollview.GetChild(0).GetChild(0);
		vertScroll=scrollview.GetChild(2).GetComponent<Scrollbar>();
		anim=window.GetComponent<Animator>();
		vlg=content.GetComponent<VerticalLayoutGroup>();
		foreach(Transform child in content)
		{
			textchilds.Add(child.GetComponent<TextMeshProUGUI>());
		}
	}

	public void WindowActive(bool value)
	{
		if(value==true)
		{
			window.gameObject.SetActive(true);
		}
		anim.SetBool("Down",!value);
	}

	public void ScrollbarValue() => vertScroll.value=0;

	public bool IsActive() { return window.gameObject.activeInHierarchy; }

	public List<string> GetAllContent()
	{
		List<string> texts = new List<string>();
		foreach(TextMeshProUGUI tmp in textchilds)
		{
			if(tmp.gameObject.activeInHierarchy)
				texts.Add(tmp.text);
			else
				break;
		}
		return texts;
	}

	public void SetAllContent(List<string> texts)
	{
		gm.act.DeactiveChilds(content);
		for(int i = 0;i<texts.Count;i++)
		{
			textchilds[i].gameObject.SetActive(true);
			textchilds[i].text=texts[i];
		}
		vlg.enabled=false;
		vlg.enabled=true;
		ScrollbarValue();
	}

	public void Text(string txt)
	{
		if(gm.act.GetInactiveChild(content)==null)
			gm.act.DeactiveChilds(content);
		TypewriterByCharacter twc = gm.act.GetInactiveChild(content).GetComponent<TypewriterByCharacter>();		
		twc.gameObject.SetActive(true);
		if(gm.st.skip==true)
		{
			twc.useTypeWriter=false;
			twc.ShowText(txt);
			ScrollbarValue();
		}
		else
		{
			twc.useTypeWriter=true;
			twc.ShowText(txt);
			ScrollbarValue();
		}
	}
		
}
