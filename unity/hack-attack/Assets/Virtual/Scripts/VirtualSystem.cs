using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class VirtualSystem : MonoBehaviour {

    private float timeLeft = 30.0f;
    [SerializeField] public Text textview;
    [SerializeField] public com.ootii.Actors.SpiderDriver driver;
    [TextArea(2, 5)][SerializeField] string consoleGreeting;
    [TextArea(2, 5)][SerializeField] string term1Greeting;
    [TextArea(2, 5)][SerializeField] string term2Greeting;
    [TextArea(2, 5)][SerializeField] string term3Greeting;
    private VirtualCmd[]  commands = {};

    private ArrayList doors = new ArrayList();

  // Start is called before the first frame update
    void Start()
    {
//      gameObject.active = false;
    }

    // Update is called once per frame
    void Update()
    {
      timeLeft -= Time.deltaTime;
      if (timeLeft < 0) {
        //Logger.info("VirtualSystem...running.");
        textview.text += "VirtualSystem...running.\n\n";
        timeLeft = 30.0f;
      }
      if (Input.GetKeyUp("`")) {
        Debug.Log("Should open console...");
        Transform canvas = transform.Find("Canvas");
        bool isConsole = canvas.gameObject.active;
        driver.IsEnabled = isConsole;
        canvas.gameObject.active = !isConsole;
      }
    }

    public void RegisterDoor(VirtualDoor door) {
      doors.Add(door);
    }
    public void DoCommand(string cmd, Text text) {
      string[] words = cmd.Split(' ');
      if (words[0] == "door" && words[1] == "unlock" && words[2] != null) {
        VirtualDoor door = GetDoor(words[2]);
        if (door != null) {
          Door d = door.gameObject.GetComponent("Door") as Door;
          d.isLocked = false;
          text.text += "Door - " + door.id + " : Unlocked\n";
        }
      } else if (words[0] == "door" && words[1] == "list") {
        ListDoors(text);
      }
    }

    private VirtualDoor GetDoor(string doorid) {
      for(int i = 0; i < doors.Count; i++) {
        VirtualDoor d = doors[i] as VirtualDoor;
        if (d.id == doorid) {
          return d;
        }
      }
      return null;
    }

    private void ListDoors(Text text) {
      text.text += "=== Doors ===\n";
      for(int i = 0; i < doors.Count; i++) {
        VirtualDoor vd = doors[i] as VirtualDoor;
        Door d = vd.gameObject.GetComponent("Door") as Door;
        string status = (d.isLocked ? "Locked" : "Unlocked\n");
        text.text += "door - " + vd.id + " : " + status + "\n";
      }
    }
}