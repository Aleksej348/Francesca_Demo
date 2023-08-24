using System.Collections;
using UnityEngine;
using TMPro;
using System.Linq;

public class StatsBox : MonoBehaviour
{
    public TextMeshProUGUI _name;
    public Animator anim;
    public Transform statsButton,ruInfoButton,engInfoButton;
    public TextMeshProUGUI[] statsText;
    //private string[] words=new string[]{"t","a","t","i","s","t","i","c","s"};
    private GameManager gm=>GameManager.gm;

    private void OnEnable()
    {
        Refresh();
        anim.SetBool("Close",false);
        //StartCoroutine("WordsEnable");
    }

	private void Start()
	{
		ruInfoButton.gameObject.SetActive(gm.language==1?true:false);
		engInfoButton.gameObject.SetActive(gm.language==0?true:false);
	}

	/*private IEnumerator WordsEnable()
    {
        _name.text="S";
        foreach(string word in words)
        {
            _name.text+=word;
            yield return new WaitForSecondsRealtime(0.05f);
        }
    }*/

	public void _SetActiveFalse()
    {
        statsButton.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }

    public void Close()
    {
        anim.SetBool("Close",true);
        //StartCoroutine("WordsDisable");
    }

    private IEnumerator WordsDisable()
    {
        for(int i=9;i>0;i--)
        {
            _name.text=_name.text.Remove(i);
            yield return new WaitForSecondsRealtime(0.05f);
        }
    }

    private void Refresh()
    {
        for(int i=0;i<statsText.Length;i++)
        {
            statsText[i].text=""+gm.Stats.ElementAt(i).Value;
        }
    }












}
