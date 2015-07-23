using UnityEngine;
using System.Collections;
#if UNITY_ADS
using UnityEngine.Advertisements;
#endif

public class Main : MonoBehaviour
{
	public void ShowAd()
	{
#if UNITY_ADS
		if (!Advertisement.IsReady())
		{
			Debug.Log("=== Ads not ready ===");
			return;
		}

		Advertisement.Show();
#endif
	}
}
