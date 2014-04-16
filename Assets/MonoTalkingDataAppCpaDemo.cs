using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Threading;

public class MonoTalkingDataAppCpaDemo: MonoBehaviour {	
	
	const int left = 90;
	const int height = 50;
	const int top = 60;
	int width = Screen.width - left * 2;
	const int step = 60;

	string account = "binlao";

	
	void OnGUI() {	
		
		int i = 0;
        GUI.Box(new Rect(10, 10, Screen.width - 20, Screen.height - 20), "Demo Menu");
        
		if (GUI.Button(new Rect(left, top + step * i++, width, height), "Register")) {
			Debug.Log("Pressed Register Button");
			TalkingDataAppCpaPlugin.OnRegister(account);
        }

		if (GUI.Button(new Rect(left, top + step * i++, width, height), "Login")) {
			Debug.Log("Pressed Login Button");
			TalkingDataAppCpaPlugin.OnLogin(account);
		}

		if (GUI.Button(new Rect(left, top + step * i++, width, height), "Pay")) {
			Debug.Log("Pressed Pay Button");
			TalkingDataAppCpaPlugin.OnPay(account, "100001", 6, "CNY");
		}
		
		if (GUI.Button(new Rect(left, top + step * i++, width, height), "CustEvent1")) {
			Debug.Log("Pressed CustEvent1 Button");
			TalkingDataAppCpaPlugin.OnCustEvent1();
        }

		if (GUI.Button(new Rect(left, top + step * i++, width, height), "CustEvent2")) {
			Debug.Log("Pressed CustEvent2 Button");
			TalkingDataAppCpaPlugin.OnCustEvent2();
		}

		if (GUI.Button(new Rect(left, top + step * i++, width, height), "CustEvent3")) {
			Debug.Log("Pressed CustEvent3 Button");
			TalkingDataAppCpaPlugin.OnCustEvent3();
		}
    }
	
	void Start () {
		Debug.Log("start...!!!!!!!!!!");
#if UNITY_IPHONE
		TalkingDataAppCpaPlugin.Init("12c86e2a0c034aa5ab4dcb408ccccf28","");
#endif
#if UNITY_ANDROID
		TalkingDataAppCpaPlugin.Init("dc3ef25be1d44d0f90aedd24271a0845","GF_1");
#endif
	}
	
	void Update () {

	}
	
	void OnDestroy (){
		Debug.Log("onDestroy");
	}
	
	void Awake () {
		Debug.Log("Awake");
	}
}
