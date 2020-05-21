using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{

    [SerializeField] float playerSpeed = 100f;

    [SerializeField] float shiftUpward = 30f;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }
    
    private void Move()
    {
        if (Input.touchCount > 0)
        {
            // The screen has been touched so store the touch
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
            {


                // If the finger is on the screen, move the object smoothly to the touch position
                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y+shiftUpward, 5));
                transform.position = Vector3.Lerp(transform.position , touchPosition, Time.deltaTime * playerSpeed);
                FindObjectOfType<PlayerShooting>().Fire();
            }
        }
    }

   

}



        


     

