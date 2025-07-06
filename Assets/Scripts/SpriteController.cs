using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpriteController : MonoBehaviour
{
    public GameObject Pausa;
    public Sprite pauseSprite;
    public Sprite playSprite;


    // Start is called before the first frame update
    void Start()
    {
        Pausa = gameObject;
        Sprite Load(string imageName, string spriteName)
        {
            Sprite[] all = Resources.LoadAll<Sprite>(imageName); //carga absolutamente todos los sprites de la carpeta de Resources
            foreach (var s in all)
            {
                if (s.name == spriteName)
                {
                    return s;
                }
            }
            return null;
        }
        playSprite = Load("play-pause", "play");
        pauseSprite = Load("play-pause", "pausa");
        // nombre variable = carga(nombre de la imagen, nombre del sector de la misma)
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0)
        {
            Pausa.GetComponent<Image>().sprite = playSprite;
        }
        else
        {
            Pausa.GetComponent<Image>().sprite = pauseSprite;
        }
    }
}
