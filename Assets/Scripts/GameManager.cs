using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int vidas = 3;
    public int contador = 3;
    public GameObject imagenVidas;
    public GameObject botonPausa;
    public GameObject botonGameOver;
    public PlayerController playerController;

    public static GameManager instance;

    public int Length { get; internal set; }


    //private void Awake()
    //{
    //    if(instance == null)
    //    {
    //        instance = this;
    //    }
    //    else
    //    {
    //        Destroy(gameObject);
    //    }
    //}
    //public void PerderVida()
    //{
    //    vidas--;

    //    if(vidas <= 0)
    //    {
    //        botonPausa.SetActive(false);
    //        botonGameOver.SetActive(true);
    //        imagenVidas.SetActive(false);
    //        playerController.perderVida();
    //    }

    //    else
    //    {
    //        imagenVidas.SetActive(true);
    //        ActualizarVidas();
    //    }
    //}


    //public void RecuperarVidas()
    //{
    //    if(vidas < 3)
    //    {
    //        vidas++;
    //        imagenVidas.SetActive(true);
    //        ActualizarVidas();
    //    }
    //}

    //public void ActualizarVidas()
    //{
    //    botonPausa.SetActive(true);
    //    botonGameOver.SetActive(false);
    //    imagenVidas.SetActive(true);
    //}
    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if(other.gameObject.CompareTag("Player"))
    //    {
    //        GameManager.instance.PerderVida();
    //    }
    //}
}
