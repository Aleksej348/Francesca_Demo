using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Web;
using System.Net;
using System.IO;

public class MainTranslator : MonoBehaviour
{
    public string Name;

    public void TranslateScript()
    {
        string txt=Resources.Load<TextAsset>(Name).text;
        string[] lines=txt.Split(new[]{'\r','\n'},StringSplitOptions.RemoveEmptyEntries);
        for(int i=0;i<lines.Length;i++)
        if(lines[i].Contains("if(language==1)"))
        {
            string line=lines[i].Replace("(\"","^").Replace("\")","@").Replace("\",\"","_");
            string trans=Translate(line.Replace("if(language==1)","else "),"ru","en").Replace("\\\"","\"").Replace("\\\\\"","\\\"");
            lines[i]+="\r\n"+trans.Replace("^","(\"").Replace("@","\")").Replace("_","\",\"");
            File.WriteAllLines(Application.dataPath+$"/Resources/{Name}_Translate.txt", lines);
        }

    }

    public String Translate(String word,string fl,string sl)
    {
        if(word.Length!=0)
        {
            String url = $"https://translate.google.com/translate_a/single?client=gtx&sl={fl}&tl={sl}&dt=t&q={HttpUtility.UrlEncode(word)}";
            var webClient = new WebClient
            {
                Encoding = System.Text.Encoding.UTF8
            };
            String result = webClient.DownloadString(url);
            String[] results=result.Split("]]]]");
            string fullresult="";
            for(int i=0;i<results.Length;i++)
            {
                string[] subresults=results[i].Split("\",\"",2);
                fullresult+=subresults[0].Remove(0,subresults[0].IndexOf("\"")+1).Replace($"{fl}\",null,null,null,null,[]]","");
            }
            return fullresult;
        }
        else return "";
    }
}
