using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "VirtualFile")]
public class VirtualFile: ScriptableObject {

    [SerializeField] string vname;  
    [SerializeField] string path;  
    [SerializeField] int size;  
    [TextArea(10, 14)][SerializeField] string helptext;
}