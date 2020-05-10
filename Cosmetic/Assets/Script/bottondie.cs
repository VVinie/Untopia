using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Microsoft.Win32;




public class bottondie : MonoBehaviour
{
	bool isClicked;

    void Start(){Debug.Log("1");}
	
	void TaskOnClick()
	{
		Debug.Log("2");
		SceneManager.LoadScene("SampleScene");
		//isClicked = true;
	}

    //void Update()
    //{
        //if(isClicked == true)
		//{
			//SceneManager.LoadScene("SampleScene");
			//Debug.Log("1");
		//}
    //}
}
