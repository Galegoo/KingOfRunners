using UnityEngine;
using System.Collections;

public class TouchPulo : MonoBehaviour
{
    PlayerController link;

    void Awake()
    {
        link = GameObject.Find("Personagem").GetComponent<PlayerController>();
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0)) 
        {
            if (link.grounded)
            {

                link.myRigidbody.velocity = new Vector2(link.myRigidbody.velocity.x, link.jumpForce);
                link.stoppedJumping = false;
                link.jumpSound.Play();
            }
            if (!link.grounded && link.canDoubleJump)
            {
                link.myRigidbody.velocity = new Vector2(link.myRigidbody.velocity.x, link.jumpForce);
                //jumpTimeCounter = jumpTime;
                link.stoppedJumping = false;
                link.canDoubleJump = false;
                link.jumpSound.Play();
            }
        }
        if ((Input.GetMouseButton(0) && !link.stoppedJumping))
        {
            if (link.jumpTimeCounter > 0)
            {
                link.myRigidbody.velocity = new Vector2(link.myRigidbody.velocity.x, link.jumpForce);
                link.jumpTimeCounter -= Time.deltaTime;
            }

        }
        if (Input.GetMouseButtonUp(0))
        {
            link.jumpTimeCounter = 0;
            link.stoppedJumping = true;
        }
    }
}
