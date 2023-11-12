using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetButton("Horizontal") )
        {
            float sense = Input.GetAxis("Horizontal");

            if (sense > 0)
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
            else if (sense < 0) 
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }            
        }

        if ( Input.GetButton("Vertical") )
        {
            float sense = Input.GetAxis("Vertical");

            if (sense > 0)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            else if (sense < 0)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }
    }

    
}
