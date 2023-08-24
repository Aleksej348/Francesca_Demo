using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using System.Linq;

namespace UnityTools
{
    public static class Tools
    {
        public static void DeactivateChilds(Transform parent){foreach(Transform child in parent) child.gameObject.SetActive(false);}

        public static void ActivateChilds(Transform parent){foreach(Transform child in parent) child.gameObject.SetActive(true);}

        public static void DeactivateChildsExcept(Transform parent, int exception)
        {
            for(int i=0;i<parent.childCount;i++)
            {
                if(i==exception) parent.GetChild(i).gameObject.SetActive(true);
                else parent.GetChild(i).gameObject.SetActive(false);
            }
        }

        public static void DeactivateChildsExcept(Transform parent, int[] exceptions)
        {
            for(int i=0;i<parent.childCount;i++)
            {
                if(exceptions.Contains(i)) parent.GetChild(i).gameObject.SetActive(true);
                else parent.GetChild(i).gameObject.SetActive(false);
            }
        }

        public static Transform GetActiveChild(Transform parent)
        {
            foreach(Transform child in parent)
            {if(child.gameObject.activeInHierarchy==true) return child;}
            return null;
        }

        public static Transform GetInactiveChild(Transform parent)
        {
            foreach(Transform child in parent)
            {if(child.gameObject.activeInHierarchy==false) return child;}
            return null;
        }


        public static bool? IsActive<T>(T obj) where T : MonoBehaviour
        {return obj?.transform.gameObject.activeInHierarchy??null;}

        public static Transform GetChildAtTag(Transform parent,string righttag)
        {
            foreach(Transform child in parent)
            {if(child.gameObject.CompareTag(righttag)) return child;}
            return null;
        }

        public static T GetChildOfTypeAtTag<T>(Transform parent,string righttag)
        {
            foreach(Transform child in parent)
            {if(child.gameObject.CompareTag(righttag)) return child.GetComponent<T>();}
            return default(T);
        }

        public static List<Transform> GetListChildsAtTag(Transform parent,string righttag)
        {
            List<Transform> list=new List<Transform>();
            foreach(Transform child in parent)
            {if(child.gameObject.CompareTag(righttag)) list.Add(child);}
            return list;
        }

        public static List<T> GetListChildsOfTypeAtTag<T>(Transform parent,string righttag)
        {
            List<T> list=new List<T>();
            foreach(Transform child in parent)
            {if(child.gameObject.CompareTag(righttag)) list.Add(child.GetComponent<T>());}
            return list;
        }


        public static List<T> GetListChildsOfType<T>(Transform parent)
        {
            List<T> list=new List<T>();
            foreach(Transform child in parent)
            {
                T component=child.GetComponent<T>();
                if(component!=null) list.Add(component);
            }
            return list;
        }

        public static T[] GetArrayChildsOfType<T>(Transform parent)
        {
            T[] arr=new T[parent.childCount];
            for(int i=0;i<parent.childCount;i++) arr[i]=parent.GetChild(i).GetComponent<T>();
            return arr;
        }

        public static T[] GetArrayGrandchildsOfType<T>(Transform parent,int num)
        {
            T[] arr=new T[parent.childCount];
            for(int i=0;i<parent.childCount;i++) arr[i]=parent.GetChild(i).GetChild(num).GetComponent<T>();
            return arr;
        }

        public static IEnumerator ChangePositionInTime(Transform obj,Vector3 startpos,Vector3 endpos,float time)
        {
            for(float i=0;i<time;i+=0.01f)
            {
                obj.position=Vector3.Lerp(startpos,endpos,i/time);
                yield return new WaitForSecondsRealtime(0.01f);
            }
            obj.position=endpos;
        }

        public static IEnumerator ChangeLocalPositionInTime(Transform obj,Vector3 startpos,Vector3 endpos,float time)
        {
            for(float i=0;i<time;i+=0.01f)
            {
                obj.localPosition=Vector3.Lerp(startpos,endpos,i/time);
                yield return new WaitForSecondsRealtime(0.01f);
            }
            obj.localPosition=endpos;
        }

        public static IEnumerator ChangeAnchoredPositionInTime(RectTransform obj,Vector3 startpos,Vector3 endpos,float time)
        {
            for(float i=0;i<time;i+=0.01f)
            {
                obj.anchoredPosition=Vector3.Lerp(startpos,endpos,i/time);
                yield return new WaitForSecondsRealtime(0.01f);
            }
            obj.anchoredPosition=endpos;
        }

        public static IEnumerator ChangeScaleInTime(Transform obj,Vector3 startpos,Vector3 endpos,float time)
        {
            for(float i=0;i<time;i+=0.01f)
            {
                obj.localScale=Vector3.Lerp(startpos,endpos,i/time);
                yield return new WaitForSecondsRealtime(0.01f);
            }
            obj.localScale=endpos;
        }

        public static IEnumerator ChangeImageColorInTime(Image img,Color from,Color where,float time)
        {
            for(float i=0;i<time;i+=0.01f)
            {
                img.color=Color.Lerp(from,where,i/time);
                yield return new WaitForSecondsRealtime(0.01f);
            }
            img.color=where;
        }

        public static IEnumerator ChangeSpriteColorInTime(SpriteRenderer img,Color from,Color where,float time)
        {
            for(float i=0;i<time;i+=0.01f)
            {
                img.color=Color.Lerp(from,where,i/time);
                yield return new WaitForSecondsRealtime(0.01f);
            }
            img.color=where;
        }

        public static IEnumerator ChangeTMPColorInTime(TextMeshProUGUI tmp,Color from,Color where,float time)
        {
            for(float i=0;i<time;i+=0.01f)
            {
                tmp.color=Color.Lerp(from,where,i/time);
                yield return new WaitForSecondsRealtime(0.01f);
            }
            tmp.color=where;
        }

        public static bool IsPointerOverUIObject(string ignoretag="IgnoreRaycast")
        {

            PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
            if(Application.isMobilePlatform)
            eventDataCurrentPosition.position = new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y);
            else
            eventDataCurrentPosition.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y,Input.mousePosition.z);
            List<RaycastResult> results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
            List<RaycastResult> filtr = results;
            foreach(RaycastResult rr in results.ToList()) if(rr.gameObject.CompareTag(ignoretag)) results.Remove(rr);
            return results.Count > 0;
        }

        public static void SetPreferredMaxHeight(RectTransform rect,float maxHeight)
        {rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Mathf.Min(LayoutUtility.GetPreferredHeight(rect),maxHeight));}

        public static void SetPreferredMaxWidth(RectTransform rect,float maxWidth)
        {rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Mathf.Min(LayoutUtility.GetPreferredWidth(rect),maxWidth));}



    }
}
