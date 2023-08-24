using UnityEngine;

public class Screenshot : MonoBehaviour
{
    public Canvas canvasMenuBox;
    private byte[] jpg;
    private Texture2D texture;
    public static Screenshot scr;

    private void Start()
    {
        scr=this;
    }

	 public byte[] MakeScreenshot()
	 {
		canvasMenuBox.gameObject.SetActive(false);
		 int width = Camera.main.pixelWidth;
		 int height = Camera.main.pixelHeight;
		 texture = new Texture2D(width, height);
		 RenderTexture _targetTexture = RenderTexture.GetTemporary(width, height);
		 Camera.main.targetTexture = _targetTexture;
		 Camera.main.Render();
		 RenderTexture.active = _targetTexture;
		 Rect rect = new Rect(0, 0, width, height);
		 texture.ReadPixels(rect, 0, 0);
		 texture.Apply();
         Camera.main.targetTexture=null;
         jpg=texture.EncodeToJPG();
         Destroy(texture);

		canvasMenuBox.gameObject.SetActive(true);
		return jpg;

	    // Texture2D tex = new Texture2D(width, height);
        // tex.LoadImage(jpg);

		// Sprite screenshot=Sprite.Create(tex, new Rect(0,0,width,height), Vector2.zero);
		 //img.sprite=screenshot;

	 }


}
