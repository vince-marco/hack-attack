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

    Animator myAnimator;

    // Start is called before the first frame update

    void Start()
    {
        myAnimator = gameObject.GetComponent("Animator") as Animator;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OpenDoor(){
        if(isLocked == false && isOpen == false){
        isOpen = true;
// Open Door
        myAnimator.SetBool("Open", true);
        StartCoroutine("Timer");
        }
    }
     public void CloseDoor(){
        if(isOpen == true){
        isOpen = false;
        myAnimator.SetBool("Open", false);
        }
    }
    public void UnlockDoor(){
        isLocked = false;
    }
    IEnumerator Timer(){
        if(timeRemaining >= 0)
            yield return new WaitForSeconds(timeRemaining);
            CloseDoor();
    }
}
