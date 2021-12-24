using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GotToLevel1 : MonoBehaviour
{
	void OnMouseUp()
	{
		print("I said don't press this asshole");
		//lol this does not work so beware.
		SceneManager.LoadScene("Main");
	}
}
