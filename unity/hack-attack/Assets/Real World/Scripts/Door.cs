using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool isLocked = false;
    public bool isOpen = false;

    public float timeOpen = 5.0f;

    float timeRemaining = 5f;
    public Collider sensor1;
    public Collider sensor2;

    // Start is called before the first frame update

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OpenDoor(){
        if(isLocked == false && isOpen == false){
        isOpen = true;
// Open Door
        gameObject.SetActive(false);
       InvokeRepeating("Countdown",0f,1f);
       Debug.Log("Opening Door"+ " Starting Door Timer");
        }
    }
    public void UnlockDoor(){
        
    }
    public void Countdown(){
        if(timeRemaining < 0){
            timeRemaining --;
            Debug.Log(timeRemaining);
        }
        else{
            isOpen = false;
            gameObject.SetActive(true);
        }
    }
}
