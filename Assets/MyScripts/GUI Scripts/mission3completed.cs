/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using System.Collections;

public class mission3completed : MonoBehaviour {
	public GUIStyle belowTextGUIStyle= new GUIStyle();
	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetString("m4_on" , "true");
		belowTextGUIStyle.fontSize = Screen.width/20;
	}
	void OnGUI(){

			GUI.Label(new Rect(Screen.width*0.415f, Screen.height*0.1859063f, Screen.width*0.21f, Screen.height*.25f),"More levels are comming soon" ,belowTextGUIStyle);
	
	}


}
