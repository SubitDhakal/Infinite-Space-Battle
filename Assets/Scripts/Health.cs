using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    Text healthText;
    DestroyPlayer destroyPlayer;

    // Start is called before the first frame update
    void Start()
    {
        healthText = GetComponent<Text>();
        
       destroyPlayer= FindObjectOfType<DestroyPlayer>();
        
    }

    // Update is called once per frame
    void Update()
    {

        healthText.text = destroyPlayer.GetHealth().ToString();
        if (destroyPlayer.GetHealth() <= 0)
        {
            healthText.text = string.Format("000");
        }
    }
}
