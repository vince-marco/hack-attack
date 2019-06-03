using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirtualPort : MonoBehaviour {

    [SerializeField] string agentname;
    [SerializeField] float startupDelay = 5.0f;
    [SerializeField] VirtualSystem system;
    private VirtualCmd[]  commands = {
        new VirtualCmd("start", "port start <id> [-f <keyfile>]", "Starts the port"),
        new VirtualCmd("stop", "port stop <id> [-f <keyfile>]", "Stops the port"),
        new VirtualCmd("arm", "port arm <id> [-f <keyfile>]", "Arms the alarm for the port"),
        new VirtualCmd("disarm", "port disarm <id> [-f <keyfile>]", "Disarms the alarm for the port"),
        new VirtualCmd("trigger", "port trigger <id> [-f <keyfile>]", "Triggers the alarm"),
        new VirtualCmd("quiet", "port quiet <id> [-f <keyfile>]", "Sets alarm to not triggered")
    };
    private float duration = 0.0f;
    private bool running = false;

  // Start is called before the first frame update
    void Start()
    {
      string msg = agentname + " : registering port\n";
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