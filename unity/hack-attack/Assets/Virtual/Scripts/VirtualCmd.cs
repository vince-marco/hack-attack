using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "VirtualCmd")]
public class VirtualCmd : ScriptableObject {

    [SerializeField] string vname;  
    [SerializeField] string usage;  
   [TextArea(10, 14)][SerializeField] string helptext;
}