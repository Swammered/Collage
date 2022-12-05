using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WarpAround : MonoBehaviour
    {
    private TrailRenderer trailRenderer;
    private void Start() {
        trailRenderer = GetComponent<TrailRenderer>();
    }
    IEnumerator waiter(float posx, float posy)
{
    trailRenderer.emitting = false;
    yield return new WaitForEndOfFrame();
    transform.position = new Vector3(posx,posy,0);
    yield return new WaitForEndOfFrame();
    trailRenderer.emitting = true;
    Debug.Log("CLEAR");
}
    private void Update() 
    {
        if (transform.position.x > 830)
        {
            //Debug.Log("hes too far right");
            transform.position = new Vector3(-130,transform.position.y,0);
            StartCoroutine(waiter(-130,transform.position.y));
        }
        else if(transform.position.x < -130){
            //Debug.Log("hes too far left");
            transform.position = new Vector3(800,transform.position.y,0);
            StartCoroutine(waiter(830,transform.position.y));
        }

        if (transform.position.y > 335)
        {
            //Debug.Log("hes too high");
            transform.position = new Vector3(-130,transform.position.y,0);
            StartCoroutine(waiter(transform.position.x,90));
        }
        else if(transform.position.y < 90){
            //Debug.Log("hes too low");
            transform.position = new Vector3(800,transform.position.y,0);
            StartCoroutine(waiter(transform.position.x,335));
        }
    }
}
