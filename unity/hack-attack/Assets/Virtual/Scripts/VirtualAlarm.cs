using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirtualAlarm : MonoBehaviour {

    string agentname = "alarm";
    [SerializeField] string id;
    [SerializeField] float startupDelay = 5.0f;
    [SerializeField] VirtualSystem system;
    private VirtualCmd[]  commands = {
        new VirtualCmd("start", "alarm start <id> [-f <keyfile>]", "Starts the alarm detection"),
        new VirtualCmd("stop", "alarm stop <id> [-f <keyfile>]", "Stops the alarm detection"),
        new VirtualCmd("trigger", "alarm trigger <id> [-f <keyfile>]", "Triggers the alarm"),
        new VirtualCmd("quiet", "alarm quiet <id> [-f <keyfile>]", "Sets alarm to not triggered")
    };
    private float duration = 0.0f;
    private bool running = false;

  // Start is called before the first frame update
    void Start()
    {
      string msg = agentname + "-" + id + " : registering agent\n";
        system.textview.text += msg;
    }

    // Update is called once per frame
    void Update()
    {
    }
    void FixedUpdate()
    {
      duration += Time.deltaTime;
      if (running == false && duration > startupDelay) {
        string msg = agentname + " : started\n";
        running = true;
        system.textview.text += msg;
      }
    }

}