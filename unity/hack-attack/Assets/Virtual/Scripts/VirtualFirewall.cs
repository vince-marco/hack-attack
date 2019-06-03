using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "VirtualFirewall")]
public class VirtualFirewall : ScriptableObject {

    [TextArea(2, 5)][SerializeField] string blockMsg;
    [TextArea(2, 5)][SerializeField] string detectMsg;
    [TextArea(2, 5)][SerializeField] string traceMsg;
    [TextArea(2, 5)][SerializeField] string lockdownMsg;
    private VirtualCmd[]  commands = {
        new VirtualCmd("start", "firewall start <id> [-f <keyfile>]", "Starts the port"),
        new VirtualCmd("stop", "firewall stop <id> [-f <keyfile>]", "Stops the port"),
        new VirtualCmd("arm", "firewall arm <id> [-f <keyfile>]", "Arms the alarm for the port"),
        new VirtualCmd("disarm", "firewall disarm <id> [-f <keyfile>]", "Disarms the alarm for the port"),
        new VirtualCmd("trigger", "firewall trigger <id> [-f <keyfile>]", "Triggers the alarm"),
        new VirtualCmd("quiet", "firewall quiet <id> [-f <keyfile>]", "Sets alarm to not triggered")
    };
}