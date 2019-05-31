using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDroneController : MonoBehaviour
{
    public float Speed =  5f;
    public float JumpHeight =  2f;
    public float GroundDistance =  0.2f;
    public float DashDistance =  5f;
    public LayerMask Ground;
    public bool isActive = true;
    public float turnSpeed = 10.0f;
    Rigidbody myRigidbody;
    Vector3 verticalInputs = Vector3.zero;
    Vector3 horizontalInputs = Vector3.zero;
    bool isGrounded = true;
    Transform groundChecker;
// Logic to facilitate drone movement will only occur when isActive is true. Use BroadcastMessage on this object with either "SetActive" or "SetInactive" when using or turning off the drone to save preformance.
   
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = gameObject.GetComponent("Rigidbody") as Rigidbody;
        groundChecker = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive == true){
            isGrounded = Physics.CheckSphere(groundChecker.position, GroundDistance);

            verticalInputs = Vector3.zero;
            horizontalInputs = Vector3.zero;
            horizontalInputs.y = Input.GetAxis("Horizontal") * turnSpeed;
            verticalInputs.z = Input.GetAxis("Vertical");

            if (Input.GetButtonDown("Jump") && isGrounded){
                myRigidbody.AddForce(Vector3.up * Mathf.Sqrt(JumpHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);
            }
             if (Input.GetButtonDown("Dash")){
                 Vector3 dashVelocity = Vector3.Scale(transform.forward, DashDistance * new Vector3 (Mathf.Log(1f/Time.deltaTime * myRigidbody.drag + 1) / -Time.deltaTime, 0 , (Mathf.Log(1f/ (Time.deltaTime * myRigidbody.drag + 1) )/ -Time.deltaTime)));
                 myRigidbody.AddForce(dashVelocity, ForceMode.VelocityChange);
            }
        }
    }
    void FixedUpdate(){
        if(isActive == true && verticalInputs != Vector3.zero){
            myRigidbody.MovePosition(myRigidbody.position + gameObject.transform.forward * Speed * Time.fixedDeltaTime * verticalInputs.z);
        }
         gameObject.transform.localEulerAngles += horizontalInputs;
    }
    public void SetActive(){
        bool isActive = true;
    }
    public void SetInactive(){
        bool isActive = false;
    }
}
