using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "VirtualApp")]
public class VirtualApp : ScriptableObject {

    [SerializeField] string vname;  
    [TextArea(10, 14)][SerializeField] string helptext;

    ArrayList commands = new ArrayList();
}