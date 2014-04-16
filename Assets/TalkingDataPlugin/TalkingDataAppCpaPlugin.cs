/*
 *	The Talking Data Cpa Plugin 
 *
 *	by Liu
 *
 */

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System;
using System.Threading;

public class TalkingDataAppCpaPlugin {
#if UNITY_IPHONE
	/* Interface to native implementation */
	
	[DllImport ("__Internal")]
	private static extern void _cpaInit(string appKey, string channelId);
	
	[DllImport ("__Internal")]
	private static extern void _cpaOnRegister(string account);
	
	[DllImport ("__Internal")]
	private static extern void _cpaOnLogin(string account);
	
	[DllImport ("__Internal")] 
	private static extern void _cpaOnPay(string account, string orderId, int amount, string currencyType);

	[DllImport ("__Internal")]
	private static extern void _cpaOnCustEvent1();
	
	[DllImport ("__Internal")]
	private static extern void _cpaOnCustEvent2();

	[DllImport ("__Internal")]
	private static extern void _cpaOnCustEvent3();

	[DllImport ("__Internal")]
	private static extern void _cpaOnCustEvent4();

	[DllImport ("__Internal")]
	private static extern void _cpaOnCustEvent5();
	
	[DllImport ("__Internal")]
	private static extern void _cpaOnCustEvent6();
	
	[DllImport ("__Internal")]
	private static extern void _cpaOnCustEvent7();
	
	[DllImport ("__Internal")]
	private static extern void _cpaOnCustEvent8();

	[DllImport ("__Internal")]
	private static extern void _cpaOnCustEvent9();
	
	[DllImport ("__Internal")]
	private static extern void _cpaOnCustEvent10();
#endif
#if UNITY_ANDROID
	private static AndroidJavaClass _appCpa;
	private static AndroidJavaObject _currActivity;
#endif
	
	/* Public interface for use inside C# / JS code */
	
	public static void Init(string appKey, string channelId)
	{
		// Call plugin only when running on real device
		if (Application.platform != RuntimePlatform.OSXEditor && Application.platform != RuntimePlatform.WindowsEditor)
		{
#if UNITY_IPHONE
			//SuperDebug.Log(SuperDebug.DEFAULT, "TalkingData AppCpa iOS Init");
			Debug.Log("TalkingData AppCpa iOS Init." + " appKey=" + appKey + " channelId=" + channelId);
			_cpaInit(appKey, channelId);
#endif
#if UNITY_ANDROID
			_appCpa = new AndroidJavaClass("com.tendcloud.appcpa.TalkingDataAppCpa");
			AndroidJavaClass unityClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
			_currActivity = unityClass.GetStatic<AndroidJavaObject>("currentActivity");

			//SuperDebug.Log(SuperDebug.DEFAULT, "TalkingData AppCpa Android Start");
			Debug.Log("TalkingData AppCpa Android Init." + " appKey=" + appKey + " channelId=" + channelId);
			_appCpa.CallStatic("init", _currActivity, appKey, channelId);
#endif
		}
	}

	public static void OnRegister(string account)
	{
		// Call plugin only when running on real device
		if (Application.platform != RuntimePlatform.OSXEditor && Application.platform != RuntimePlatform.WindowsEditor)
		{
#if UNITY_IPHONE
			Debug.Log("TalkingData AppCpa IOS OnRegister." + " account=" + account);
			_cpaOnRegister(account);
#endif
#if UNITY_ANDROID
			Debug.Log("TalkingData AppCpa Android OnRegister." + " account=" + account);
			_appCpa.CallStatic("onRegister", account);
#endif
		}
	}

	public static void OnLogin(string account)
	{
		// Call plugin only when running on real device
		if (Application.platform != RuntimePlatform.OSXEditor && Application.platform != RuntimePlatform.WindowsEditor)
		{
#if UNITY_IPHONE
			Debug.Log("TalkingData AppCpa IOS OnLogin." + " account=" + account);
			_cpaOnLogin(account);
#endif
#if UNITY_ANDROID
			Debug.Log("TalkingData AppCpa Android OnLogin." + " account=" + account);
			_appCpa.CallStatic("onLogin", account);
#endif
		}
	}

	public static void OnPay(string account, string orderId, int amount, string currencyType)
	{
		// Call plugin only when running on real device
		if (Application.platform != RuntimePlatform.OSXEditor && Application.platform != RuntimePlatform.WindowsEditor)
		{
#if UNITY_IPHONE
			Debug.Log("TalkingData AppCpa IOS OnPay." + " account=" + account + " orderId=" + orderId + " amount=" + amount + " currencyType=" + currencyType);
			_cpaOnPay(account, orderId, amount, currencyType);
#endif
#if UNITY_ANDROID
			Debug.Log("TalkingData AppCpa Android OnPay." + " account=" + account + " orderId=" + orderId + " amount=" + amount + " currencyType=" + currencyType);
			_appCpa.CallStatic("onPay", account, orderId, amount, currencyType);
#endif
		}
	}

	public static void OnCustEvent1()
	{
		// Call plugin only when running on real device
		if (Application.platform != RuntimePlatform.OSXEditor && Application.platform != RuntimePlatform.WindowsEditor)
		{
#if UNITY_IPHONE
			Debug.Log("TalkingData AppCpa IOS OnCustEvent1.");
			_cpaOnCustEvent1();
#endif
#if UNITY_ANDROID
			Debug.Log("TalkingData AppCpa Android OnCustEvent1.");
			_appCpa.CallStatic("onCustEvent1");
#endif
		}
	}

	public static void OnCustEvent2()
	{
		// Call plugin only when running on real device
		if (Application.platform != RuntimePlatform.OSXEditor && Application.platform != RuntimePlatform.WindowsEditor)
		{
#if UNITY_IPHONE
			Debug.Log("TalkingData AppCpa IOS OnCustEvent2.");
			_cpaOnCustEvent2();
#endif
#if UNITY_ANDROID
			Debug.Log("TalkingData AppCpa Android OnCustEvent2.");
			_appCpa.CallStatic("onCustEvent2");
#endif
		}
	}

	public static void OnCustEvent3()
	{
		// Call plugin only when running on real device
		if (Application.platform != RuntimePlatform.OSXEditor && Application.platform != RuntimePlatform.WindowsEditor)
		{
#if UNITY_IPHONE
			Debug.Log("TalkingData AppCpa IOS OnCustEvent3.");
			_cpaOnCustEvent3();
#endif
#if UNITY_ANDROID
			Debug.Log("TalkingData AppCpa Android OnCustEvent3.");
			_appCpa.CallStatic("onCustEvent3");
#endif
		}
	}

	public static void OnCustEvent4()
	{
		// Call plugin only when running on real device
		if (Application.platform != RuntimePlatform.OSXEditor && Application.platform != RuntimePlatform.WindowsEditor)
		{
#if UNITY_IPHONE
			Debug.Log("TalkingData AppCpa IOS OnCustEvent4.");
			_cpaOnCustEvent4();
#endif
#if UNITY_ANDROID
			Debug.Log("TalkingData AppCpa Android OnCustEvent4.");
			_appCpa.CallStatic("onCustEvent4");
#endif
		}
	}

	public static void OnCustEvent5()
	{
		// Call plugin only when running on real device
		if (Application.platform != RuntimePlatform.OSXEditor && Application.platform != RuntimePlatform.WindowsEditor)
		{
#if UNITY_IPHONE
			Debug.Log("TalkingData AppCpa IOS OnCustEvent5.");
			_cpaOnCustEvent5();
#endif
#if UNITY_ANDROID
			Debug.Log("TalkingData AppCpa Android OnCustEvent5.");
			_appCpa.CallStatic("onCustEvent5");
#endif
		}
	}

	public static void OnCustEvent6()
	{
		// Call plugin only when running on real device
		if (Application.platform != RuntimePlatform.OSXEditor && Application.platform != RuntimePlatform.WindowsEditor)
		{
#if UNITY_IPHONE
			Debug.Log("TalkingData AppCpa IOS OnCustEvent6.");
			_cpaOnCustEvent6();
#endif
#if UNITY_ANDROID
			Debug.Log("TalkingData AppCpa Android OnCustEvent6.");
			_appCpa.CallStatic("onCustEvent6");
#endif
		}
	}
	
	public static void OnCustEvent7()
	{
		// Call plugin only when running on real device
		if (Application.platform != RuntimePlatform.OSXEditor && Application.platform != RuntimePlatform.WindowsEditor)
		{
#if UNITY_IPHONE
			Debug.Log("TalkingData AppCpa IOS OnCustEvent7.");
			_cpaOnCustEvent7();
#endif
#if UNITY_ANDROID
			Debug.Log("TalkingData AppCpa Android OnCustEvent7.");
			_appCpa.CallStatic("onCustEvent7");
#endif
		}
	}
	
	public static void OnCustEvent8()
	{
		// Call plugin only when running on real device
		if (Application.platform != RuntimePlatform.OSXEditor && Application.platform != RuntimePlatform.WindowsEditor)
		{
#if UNITY_IPHONE
			Debug.Log("TalkingData AppCpa IOS OnCustEvent8.");
			_cpaOnCustEvent8();
#endif
#if UNITY_ANDROID
			Debug.Log("TalkingData AppCpa Android OnCustEvent8.");
			_appCpa.CallStatic("onCustEvent8");
#endif
		}
	}
	
	public static void OnCustEvent9()
	{
		// Call plugin only when running on real device
		if (Application.platform != RuntimePlatform.OSXEditor && Application.platform != RuntimePlatform.WindowsEditor)
		{
#if UNITY_IPHONE
			Debug.Log("TalkingData AppCpa IOS OnCustEvent9.");
			_cpaOnCustEvent9();
#endif
#if UNITY_ANDROID
			Debug.Log("TalkingData AppCpa Android OnCustEvent9.");
			_appCpa.CallStatic("onCustEvent9");
#endif
		}
	}
	
	public static void OnCustEvent10()
	{
		// Call plugin only when running on real device
		if (Application.platform != RuntimePlatform.OSXEditor && Application.platform != RuntimePlatform.WindowsEditor)
		{
#if UNITY_IPHONE
			Debug.Log("TalkingData AppCpa Android OnCustEvent10.");
			_cpaOnCustEvent10();
#endif
#if UNITY_ANDROID
			Debug.Log("TalkingData AppCpa Android OnCustEvent10.");
			_appCpa.CallStatic("onCustEvent10");
#endif
		}
	}
}
