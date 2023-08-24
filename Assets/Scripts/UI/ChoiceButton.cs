using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChoiceButton : MonoBehaviour
{
    public string _label,comment;
    public int _step,istory;
    public bool must;

    private Transform blackImage,infoButton;
    private Button button;
    private GameManager gm=>GameManager.gm;

    private void Awake()
    {
        blackImage=transform.GetChild(1);
        infoButton=transform.GetChild(2);
        button=GetComponent<Button>();
    }

    private void OnEnable()
    {
        button.interactable=must;
        blackImage.gameObject.SetActive(!must);
        infoButton.gameObject.SetActive(comment.Length>0?true:false);
    }

    public void ChooseChoice()
    {
        gm.act.CanTap=true;
        gm.st.Istory=istory;
        gm.st.step=_step;
        gm.st.label=_label;
        gm.st.Path.Add(_label);
        gm.st.NextStep();
        transform.parent.gameObject.SetActive(false);
    }

    public void OpenInfo()=>gm.InfoBoxActive(comment);



}
