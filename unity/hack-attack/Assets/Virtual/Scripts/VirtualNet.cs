using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "VirtualNet")]
public class VirtualNet : ScriptableObject {

    [SerializeField] string subnet;
    [TextArea(10, 14)][SerializeField] string help;

    ArrayList connects = new ArrayList();
    private VirtualCmd[]  commands = {
        new VirtualCmd("start", "port start <id> [-f <keyfile>]", "Starts the port"),
        new VirtualCmd("stop", "port stop <id> [-f <keyfile>]", "Stops the port"),
        new VirtualCmd("arm", "port arm <id> [-f <keyfile>]", "Arms the alarm for the port"),
        new VirtualCmd("disarm", "port disarm <id> [-f <keyfile>]", "Disarms the alarm for the port"),
        new VirtualCmd("trigger", "port trigger <id> [-f <keyfile>]", "Triggers the alarm"),
        new VirtualCmd("quiet", "port quiet <id> [-f <keyfile>]", "Sets alarm to not triggered")
    };
}