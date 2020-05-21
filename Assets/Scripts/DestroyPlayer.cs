 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyPlayer : MonoBehaviour
{

    [SerializeField] int health = 400;
    [SerializeField] float delayTime = 3f;
   
    Text healthText;




    [Header("Audio")]
    [SerializeField] AudioClip playerDeathSound;
    [SerializeField] [Range(0, 1)]  float deathSoundVolume = 1f;


    private void OnTriggerEnter2D(Collider2D other)
    {
        DamageDealer damageDealer = other.gameObject.GetComponent<DamageDealer>();
        if (!damageDealer) { return; }
        Handheld.Vibrate();
        ProcessHit(damageDealer);
    }


    private void ProcessHit(DamageDealer damageDealer)
    {
        health -= damageDealer.GetDamage();
        damageDealer.Hit();

        if (health <= 0)
        {

            Die();
        }
    }

    private void Die()
    {
        
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(playerDeathSound, Camera.main.transform.position, deathSoundVolume);
        FindObjectOfType<Level>().Invoke("LoadGameOver",delayTime);
    }

    public int GetHealth()
    {
        return health;
    }

}
