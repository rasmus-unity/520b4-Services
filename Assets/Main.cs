using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class Main : MonoBehaviour
{
	public void ShowAd()
	{
		if (!Advertisement.IsReady())
		{
			Debug.Log("=== Ads not ready ===");
			return;
		}

		Advertisement.Show();
	}
}
