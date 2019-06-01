using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "VirtualGuard")]
public class VirtualGuard : ScriptableObject {

    [SerializeField] string name;  
    [SerializeField] int duration;  
    [TextArea(10, 14)][SerializeField] string helptext;

    [SerializeField] ArrayList<VirtualCmd> commands = new ArrayList<VirtualCmd>();
}