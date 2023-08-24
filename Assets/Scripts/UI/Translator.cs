using UnityEngine;
using TMPro;

public class Translator : MonoBehaviour
{
    public string RusTranslaiton,EngTranslation;

    private void Start()
    {
        int lang=GameManager.gm.language;        
        GetComponent<TextMeshProUGUI>().text=lang==1?RusTranslaiton:EngTranslation;
    }
}
