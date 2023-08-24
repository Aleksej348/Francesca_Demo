using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class SaveButton : MonoBehaviour
{
    private Image img;
    private TextMeshProUGUI txt;
    private string savename;
    private int num;
    private Transform deleteButton;

    private GameManager gm=>GameManager.gm;

    private void Awake()
    {
        num=transform.parent.GetSiblingIndex();
        img=transform.GetChild(0).GetComponent<Image>();
        deleteButton=transform.parent.GetChild(1);
        txt=transform.GetChild(1).GetComponent<TextMeshProUGUI>();

    }

    private void SetSprite(byte[] bytes)
    {
        int width = Camera.main.pixelWidth;
        int height = Camera.main.pixelHeight;
        Texture2D _texture = new Texture2D(width,height);
        _texture.LoadImage(bytes);
        Sprite scrsprite=Sprite.Create(_texture, new Rect(0,0,_texture.width,_texture.height), Vector2.zero);
        img.sprite=scrsprite;
        img.color=Color.white;
        txt.text="";
    }

    public void SaveAtSlot()
    {
        savename="Scr"+gm.mbox.toggleValue+""+num;
        byte[] scrbytes=Screenshot.scr.MakeScreenshot();
        SetSprite(scrbytes);
        deleteButton.gameObject.SetActive(true);
        gm.act.SaveGame(savename);
        File.WriteAllBytes(Application.persistentDataPath+$"/{savename}.bmp",scrbytes);

    }

    public void ConfirmToResave()
    {
        if(gm.mbox.SaveOrLoad==true)
        {
            if(txt.text.Length<2)
            {
                string message=gm.language==1?"Вы уверены, что хотите перезаписать данное сохранение?": "Are you sure you want to overwrite this save?";
                gm.mbox.OpenConfirmBox(SaveAtSlot,message);
            }
            else
            SaveAtSlot();
        }
        else
        {
            LoadGame();
        }
    }

    public void ConfirmToDeleteSave()
    {
        string message=gm.language==1?"Вы уверены, что хотите удалить данное сохранение?": "Are you sure you want to delete this save?";
        gm.mbox.OpenConfirmBox(DeleteSave,message);
    }

    public void DeleteSave()
    {
        savename="Scr"+gm.mbox.toggleValue+""+num;
        if(File.Exists(Application.persistentDataPath+$"/{savename}.bmp"))
        {
            File.Delete(Application.persistentDataPath+$"/{savename}.bmp");
            Invoke("Refresh",0.03f);
        }
    }

    public void Refresh()
    {
        savename="Scr"+gm.mbox.toggleValue+""+num;
        if(File.Exists(Application.persistentDataPath+$"/{savename}.bmp"))
        {
            byte[] bytes=File.ReadAllBytes(Application.persistentDataPath+$"/{savename}.bmp");
            SetSprite(bytes);
            deleteButton.gameObject.SetActive(true);
        }
        else
        {
            img.sprite=null;
            img.color=Color.black;
            txt.text=gm.language==1?"Пусто":"Empty";
            deleteButton.gameObject.SetActive(false);
        }
    }


    public void LoadGame()
    {
        if(txt.text.Length<2)
        {
            savename="Scr"+gm.mbox.toggleValue+""+num;
            gm.act.Load(savename);
        }
    }

    public void LoadAtMainMenu()
    {
        if(txt.text.Length<2) gm.mbox.LoadAtMainMenu("Scr"+gm.mbox.toggleValue+""+num);
    }


}
