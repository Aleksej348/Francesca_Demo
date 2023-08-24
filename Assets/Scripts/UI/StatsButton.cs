
using UnityEngine;

public class StatsButton : MonoBehaviour
{
    public StatsBox statsBox;
    public bool open;

    public void ClickToButton()
    {
        open=!open;
        if(open)
        {
            statsBox.gameObject.SetActive(true);
            GameManager.gm.st.skip=false;
        }
        else
        {
            statsBox.Close();
        }
    }


}
