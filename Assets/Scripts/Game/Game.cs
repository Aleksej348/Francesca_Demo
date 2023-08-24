using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Game
{
    public List<string> path=new List<string>();
    public List<string> textWindowContent=new List<string>();
    public List<double> materialValues=new List<double>();
    public Vector3[] persPos,persScale;
    public bool[] persActive;
    public int[] persEmotions,stats;
    public string[] persColor;
    public string tboxContent,tboxName,label;
    public int Istory,step,music,scene,secondscene,Imaterial,Iitem=-1;
	public double musicPitch=1;
	public bool sceneSpriteAspect;
}
