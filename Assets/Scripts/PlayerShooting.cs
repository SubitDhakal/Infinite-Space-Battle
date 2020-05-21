using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [Header("Projectile")]

    [SerializeField] GameObject laserPrefab;
    [SerializeField] float projectileSpeed = 40f;
    [SerializeField] float timer =0.35f;


    [Header("Audio")]
    [SerializeField] AudioClip playerShootSound;
    [SerializeField] [Range(0, 1)] float shootingVolume = 0.65f;



    Coroutine firingCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   public void Update()
    {

        Fire();
    }
    
    public void Fire()
    {
        timer -= Time.deltaTime;
        
            if (timer <= 0)
            {
            FireContinuously();
                timer = 0.35f;
            }
    }
    
    private void FireContinuously()
    {
        GameObject laser = Instantiate(
                  laserPrefab,
                  transform.position,
                  Quaternion.identity) as GameObject;
            laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, projectileSpeed);
            AudioSource.PlayClipAtPoint(playerShootSound, Camera.main.transform.position, shootingVolume);
    }
}
