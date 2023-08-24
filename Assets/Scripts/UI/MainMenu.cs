using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Sprite[] sprites;
    public Image background;
    public Transform continueButton;

    private void Awake()
    {
        if(PlayerPrefs.GetString("WasDeleted").Length==0)
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.SetString("WasDeleted","Yes!");
        }
        if(PlayerPrefs.GetInt("RegionLanguage")==0)
        {
            if(Application.systemLanguage == SystemLanguage.Russian) PlayerPrefs.SetInt("Language",1);
            else PlayerPrefs.SetInt("Language",0);
            PlayerPrefs.SetInt("RegionLanguage",1);
        }
    }

    private void Start()
    {
        if(PlayerPrefs.GetString("LastSave").Length==0) continueButton.gameObject.SetActive(false);
        if(PlayerPrefs.GetFloat("TextSpeed")==0) PlayerPrefs.SetFloat("TextSpeed",1f);
        if(PlayerPrefs.GetFloat("AnimationSpeed")==0)  PlayerPrefs.SetFloat("AnimationSpeed",1f);
        if(PlayerPrefs.GetInt("EffectsBool")==0) PlayerPrefs.SetInt("EffectsBool",1);
        background.sprite=sprites[Random.Range(0,sprites.Length)];
    }

    public void Close()
    {
        Application.Quit();
    }

    public void Begin()
    {
        StaticClass.savename="";
        GameManager.gm.mbox.LoadSceneAsync(1);
    }

    public void Continue()
    {
        StaticClass.savename=PlayerPrefs.GetString("LastSave");
        GameManager.gm.mbox.LoadSceneAsync(1);
    }

    public void SetLanguage(int value)
    {
        PlayerPrefs.SetInt("Language",value);
        GameManager.gm.mbox.LoadSceneAsync(0);
    }

    public void Link(string url)=>Application.OpenURL(url);

	public void DeleteAllSaves()
	{
		PlayerPrefs.DeleteAll();
		for(int x = 0;x<6;x++)
		{
			for(int y = 0;y<6;y++)
			{
				string Name = $"Scr{x}{y}";
				if(System.IO.File.Exists(Application.persistentDataPath+$"/{Name}.bmp"))
					System.IO.File.Delete(Application.persistentDataPath+$"/{Name}.bmp");
			}
		}
		GameManager.gm.mbox.LoadSceneAsync(0);
	}

	public void ConfirmToDeleteAllSave()
	{
		string message = GameManager.gm.language==1 ? "¬ы уверены, что хотите удалить все сохранени€?" : "Are you sure you want to delete all saves?";
		GameManager.gm.mbox.OpenConfirmBox(DeleteAllSaves,message);
	}
}
