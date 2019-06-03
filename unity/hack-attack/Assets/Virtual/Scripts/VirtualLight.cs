using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirtualLight : MonoBehaviour {

    [SerializeField] string agentname;
    [SerializeField] float startupDelay = 5.0f;
    [SerializeField] VirtualSystem system;
    private VirtualCmd[]  commands = {
        new VirtualCmd("on", "light on <id> [-f <keyfile>]", "Turn the light(s) on"),
        new VirtualCmd("off", "light off <id> [-f <keyfile>]", "turn the light(s) off")
    };
    private float duration = 0.0f;
    private bool running = false;

  // Start is called before the first frame update
    void Start()
    {
      string msg = agentname + " : registering agent\n";
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