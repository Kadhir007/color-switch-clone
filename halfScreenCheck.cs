using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class halfScreenCheck : MonoBehaviour
{
    public float camerajumpspeed = 20f;
    private Rigidbody2D halfbody;
    // Start is called before the first frame update
    void Start()
    {
        halfbody = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            halfbody.velocity = Vector2.up * camerajumpspeed * 0.1f;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            halfbody.velocity = Vector2.up * camerajumpspeed * 0;
        }
    }

}
