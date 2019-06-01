using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "VirtualFirewall")]
public class VirtualFirewall : ScriptableObject {

    [TextArea(2, 5)][SerializeField] string blockMsg;
    [TextArea(2, 5)][SerializeField] string detectMsg;
    [TextArea(2, 5)][SerializeField] string traceMsg;
    [TextArea(2, 5)][SerializeField] string lockdownMsg;
}