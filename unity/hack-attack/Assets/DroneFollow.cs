using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerDrone;
    public float playerDistThresh = 10.0f;
    public float cameraSpeed = 1.0f;

    float playerDist;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerDist = Vector3.Distance(gameObject.transform.position , playerDrone.position);
        if(playerDist >= playerDistThresh){
            FollowDrone();
        }
    }
    public void FollowDrone(){
        Vector3 cameraTarget = new Vector3(Vector3.MoveTowards(gameObject.transform.position, playerDrone.position, cameraSpeed).x,gameObject.transform.position.y,Vector3.MoveTowards(gameObject.transform.position, playerDrone.position, cameraSpeed).z);
        gameObject.transform.position = cameraTarget;        
    }
    public void Reorient(){

    }
}
