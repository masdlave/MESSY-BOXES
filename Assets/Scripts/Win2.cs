using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
public class Win2 : MonoBehaviour
{
    public GameObject winText; //panel nuevo
 public void OnTriggerEnter(Collider collider){
    Debug.Log("se tocan ");
    
    if(collider.CompareTag("Player")){
    winText.SetActive(true);
    } // Panel nuevo
 }
}