using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InformationBox : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI infoBoxText;

    public void SetText(string _text)
    {
        infoBoxText.text=_text;

    }

}
