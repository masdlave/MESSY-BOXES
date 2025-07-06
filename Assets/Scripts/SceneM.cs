using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SceneM : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Primer laberinto", LoadSceneMode.Single);
    }
    
}