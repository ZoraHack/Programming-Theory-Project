using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    [SerializeField] float speed = 5.0f;
    [SerializeField] float turnSpeed = 25;
    private float horizontalInput;
    private float forwardInput;

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");


        MoveVehicleForwardAndBack();
        TurnVehicle();
    }

    public virtual void MoveVehicleForwardAndBack()
    {
        // We move the Bus Forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
    }
    public virtual void TurnVehicle()
    {
         // We turn the Bus based on horizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
