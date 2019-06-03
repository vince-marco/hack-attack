using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualServer : MonoBehaviour {

    [SerializeField] string hostname;  
    [SerializeField] string ip;  
    [SerializeField] int cores;  
   [TextArea(10, 14)][SerializeField] string helptext;
   [TextArea(10, 14)][SerializeField] string greeting;
   [TextArea(10, 14)][SerializeField] string ping;
   [TextArea(10, 14)][SerializeField] string unauthorized;

   [SerializeField] VirtualPort[] ports;
    private VirtualCmd[]  commands = {
        new VirtualCmd("start", "door start <id> [-f <keyfile>]", "Starts the alarm detection"),
        new VirtualCmd("stop", "door stop <id> [-f <keyfile>]", "Stops the alarm detection"),
        new VirtualCmd("trigger", "door trigger <id> [-f <keyfile>]", "Triggers the alarm"),
        new VirtualCmd("quiet", "door quiet <id> [-f <keyfile>]", "Sets alarm to not triggered")
    };

  // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    void FixedUpdate()
    {

    }
}