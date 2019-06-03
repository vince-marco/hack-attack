using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirtualDoor : MonoBehaviour {

    [SerializeField] public string id = "door";
    [SerializeField] float startupDelay = 5.0f;
    [SerializeField] VirtualSystem system;
    private VirtualCmd[]  commands = {
        new VirtualCmd("start", "door start <id> [-f <keyfile>]", "Starts the alarm detection"),
        new VirtualCmd("stop", "door stop <id> [-f <keyfile>]", "Stops alarm detection"),
        new VirtualCmd("trigger", "door trigger <id> [-f <keyfile>]", "Triggers the alarm"),
        new VirtualCmd("quiet", "door quiet <id> [-f <keyfile>]", "Clears alarm if triggered"),
        new VirtualCmd("lock", "door lock <id> [-f <keyfile>]", "Locks door"),
        new VirtualCmd("unlock", "door unlock <id> [-f <keyfile>]", "Unlocks door using keyfile if specified"),
        new VirtualCmd("open", "door open <id> [-f <keyfile>]", "Opens door using keyfile if specified"),
        new VirtualCmd("close", "door close <id> [-f <keyfile>]", "Closes door.  If key is specified, then key required to open")
    };
    private bool registered = false;
    private float duration = 0.0f;
//    private Animator myAnimator;

  // Start is called before the first frame update
    void Start()
    {
      system.RegisterDoor(this);
//      myAnimator = gameObject.GetComponent("Animator") as Animator;
      string msg = "Door: " + id + " : registering door\n";
        system.textview.text += msg;
    }

    // Update is called once per frame
    void Update()
    {
    }
    void FixedUpdate()
    {
      duration += Time.deltaTime;
      if (registered == false && duration > startupDelay) {
        registered = true;
        string msg = "Door: " + id + " : registered\n";
        system.textview.text += msg;
        }
    }

  void Unlock() {
    Door door = gameObject.GetComponent("Door") as Door;
    door.UnlockDoor();
    string msg = "Door: " + id + " : unlocked\n";
    system.textview.text += msg;
  }

  void Help() {

  }
}