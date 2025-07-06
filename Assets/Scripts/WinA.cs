using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class WinA : MonoBehaviour
{
    public void OnTriggerEnter (Collider collider)
    {
        Debug.Log("se tocan");
        if (collider.CompareTag("Player"))
        {
            SceneManager.LoadScene("Tercer laberinto", LoadSceneMode.Single);
        }
    }
}
