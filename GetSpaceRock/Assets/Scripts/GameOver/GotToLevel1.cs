using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GotToLevel1 : MonoBehaviour
{
	void OnMouseUp()
	{
		lives.livesCount = 5;
		score.scoreValue = 0;
		rocksCollected.rockCount = 0;
		rocksCollectedLevel2.rockCountlvl2 = 0;
		SceneManager.LoadScene("Main");
}
}
