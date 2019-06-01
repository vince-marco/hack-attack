using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "VirtualProcess")]
public class VirtualProcess : ScriptableObject {

    [SerializeField] string vname;  
    [SerializeField] int duration;  
    [TextArea(10, 14)][SerializeField] string helptext;

    ArrayList commands = new ArrayList();
}