﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
	public int num;

     public void GoToScene()
    {
    	 SceneManager.LoadScene(num);
    }
    
}
