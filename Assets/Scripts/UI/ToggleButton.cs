using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ToggleButton : MonoBehaviour
{
    private GameManager gm=>GameManager.gm;

    public void IsOn(bool ison)
    {
        if(ison)
        {
            gm.mbox.toggleValue=transform.GetSiblingIndex();
            gm.mbox.RefreshAll();
        }
    }
}
