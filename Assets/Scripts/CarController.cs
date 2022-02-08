using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    public WheelCollider FlCol, FrCol, RlCol, RrCol;

    public GameObject Fl, Fr, Rl, Rr;

    public float motorSpeed;
    public float RotationSpeed;

    public float motor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     

    }

    private void FixedUpdate()
    {
        motor = motorSpeed * Input.GetAxis("Vertical");
        float rotation = RotationSpeed * Input.GetAxis("Horizontal");

        FlCol.steerAngle = FrCol.steerAngle = rotation;
        RrCol.motorTorque = motor;
        RlCol.motorTorque = motor;

    }

}
