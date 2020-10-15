using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller11 : MonoBehaviour
{
    float speed = 10.0f;
    float maxLimit = 4.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float HorizontalInput = Input.GetAxis("Horizontal");
        float jumpInput = Input.GetAxis("Jump");
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speed);
        transform.Translate(Vector3.right * Time.deltaTime * HorizontalInput * speed);
        transform.Translate(Vector3.up * Time.deltaTime * jumpInput * speed);

        if(transform.position.z < -maxLimit)
        {
            transform.position(new Vector3(transform))
        }
    }
}
