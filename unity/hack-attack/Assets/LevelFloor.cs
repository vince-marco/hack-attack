using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFloor : MonoBehaviour
{
    public LevelManager myLevelManager;
    void OnTriggerEnter(Collider other){
        myLevelManager.LoadLevel("LoseScreen");
    }
}
