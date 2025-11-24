using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f; // Movement speed
    Rigidbody rb;



    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    void Update()
    {
        // Get input values
        float horizontal = Input.GetAxis("Horizontal"); // A/D or Left/Right
        float forwards = Input.GetAxis("Vertical");     // W/S or Up/Down
        Vector3 up = new Vector3(0f, 1, 0f);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(up * 5, ForceMode.Impulse);
        }



        // Movement direction
        Vector3 direction = new Vector3(horizontal, 0f, forwards);


        // Apply movement
        transform.Translate(direction * speed * Time.deltaTime);

    }
}
