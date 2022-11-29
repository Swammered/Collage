using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByTouch : MonoBehaviour
{
    public Joystick joystick;
    float horizontalMove = 0f;
    float verticalMove = 0f;
    [SerializeField] float moveSpeed = .01f;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = joystick.Horizontal * moveSpeed;
        verticalMove = joystick.Vertical * moveSpeed;

        transform.Translate(horizontalMove,verticalMove,0);

        // for (int i = 0; i < Input.touchCount; i++)
        // {
        //     Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.touches[i].position);

            
        // }
    }
}
