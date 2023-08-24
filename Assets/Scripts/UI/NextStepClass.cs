using UnityEngine.EventSystems;
using UnityEngine;

public class NextStepClass : MonoBehaviour,IPointerClickHandler
{
    private GameManager gm=>GameManager.gm;

    public void OnPointerClick(PointerEventData eventData)
    {
		if(gm.st.skip==true)
			gm.st.skip=false;
		else if(gm.act.CanTap==true)
			gm.st.NextStep();
	}
}
