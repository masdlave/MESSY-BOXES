using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class panelLvl1 : MonoBehaviour
{
    public GameObject winText;
    public void OnTriggerEnter(Collider collider)
    {
        Debug.Log("se tocan ");

        if (collider.CompareTag("Player"))
        {
            winText.SetActive(true);
        } // Panel nuevo
    }
}