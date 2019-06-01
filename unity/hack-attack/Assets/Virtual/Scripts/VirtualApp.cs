using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "VirtualApp")]
public class VirtualApp : ScriptableObject {

    [SerializeField] string name;  
    [TextArea(10, 14)][SerializeField] string helptext;

    [SerializeField] ArrayList<VirtualCmd> commands = new ArrayList<VirtualCmd>();
}