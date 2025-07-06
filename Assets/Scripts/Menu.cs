using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Menu : MonoBehaviour
{
    public void MenuOpen()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
    
}