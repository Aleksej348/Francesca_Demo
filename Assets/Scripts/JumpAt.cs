using UnityEngine;

public class JumpAt : MonoBehaviour
{
    public void JumpAtTheEnd()
	{
		GameManager.gm.st.NextCoroutine("G1",4,44);

		gameObject.SetActive(false);
	
	}
}
