using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    public int powerUpID;
    public static bool gunPowerUpOn = false;
    [SerializeField] private AudioSource powerUpSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime * Vector2.down);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            powerUpSoundEffect.Play();
            PlayerController player = collision.GetComponent<PlayerController>();

            if(powerUpID == 1 && gunPowerUpOn == false)
            {
                gunPowerUpOn = true;
                player.CanFastShoot();
                //var txt = Instantiate(player.txtPowerUp1, player.transform.position, Quaternion.identity);
                //Destroy(txt, 2f);
            }
            if (powerUpID == 2)
            {
                player.ShieldPowerUpOn();
                //var txt = Instantiate(player.txtPowerUp2, player.transform.position, Quaternion.identity);
                //Destroy(txt, 2f);
            }
            if(powerUpID==3 && gunPowerUpOn == false) 
            {
                gunPowerUpOn = true;
                player.CanGrenadeLauncher();
                //var txt = Instantiate(player.txtPowerUp3, player.transform.position, Quaternion.identity);
                //Destroy(txt, 2f);
            }

            Destroy(gameObject, 0.9f);
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }

        if (collision.gameObject.tag == "DestroyBoundary")
        {
            Destroy(gameObject);
        }
    }
}
