using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public com.ootii.Actors.SpiderAIDriver myController;
    public Transform[] Path = new Transform[3];
    public int currentMarker;
    public Transform playerPosition;
    public LevelManager myLevelManager;
    public Transform myRobot;
    StateMachine stateMachine = new StateMachine();
    bool isLooking = true;
    bool inActive = false;
    void Start(){
        myController = gameObject.GetComponentInChildren<com.ootii.Actors.SpiderAIDriver>();
        stateMachine.ChangeState(new Patrol(this), gameObject);
    }
    void Update(){
        stateMachine.Update();
    }
    public void CheckForActivation(){
         if(inActive == false){
            stateMachine.ChangeState(new Patrol(this), gameObject);
        }
    }
   public void CheckForSight(){
         if(Spotted() == true && isLooking == true){
            stateMachine.ChangeState(new Chase(this), gameObject);
        }
    }
   public void CheckForNonSight(){
        if(Spotted() == false){
            stateMachine.ChangeState(new Patrol(this), gameObject);
        }
    }
    public void CheckForDeactivation(){
        if(inActive == true){
            stateMachine.ChangeState(new Inactive(this), gameObject);
        }
    }
    public void SetDestination(Transform target){
        myController.Target = target;        
    }
    public void Cyclepath(){
        if(currentMarker >= 2){
            currentMarker = 0;
        }
        else{ currentMarker ++;}
        SetDestination(Path[currentMarker]);
    }
    public bool Spotted(){
        Vector3 targetDir = playerPosition.position - transform.GetChild(0).position;
        float angletoPlayer = (Vector3.Angle(targetDir,transform.GetChild(0).forward));
        int layerMask = 1 << 8;
        layerMask = ~layerMask;
        if(angletoPlayer >= -45 && angletoPlayer <= 45){ 
            if(Physics.Linecast(transform.GetChild(0).position, playerPosition.position,layerMask) == true){
                Debug.DrawLine(transform.GetChild(0).position, playerPosition.position,Color.blue,2f);
                return false;
            }
            else{
            Debug.DrawLine(transform.position, playerPosition.position,Color.blue,2f);
            return true;
            }
        }
        else {return false;}
    }
}


