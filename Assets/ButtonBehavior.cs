﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehavior : MonoBehaviour
{
    public void GoToLevel() {
      SceneManager.LoadScene("RandomLevel");    		
    }
}
