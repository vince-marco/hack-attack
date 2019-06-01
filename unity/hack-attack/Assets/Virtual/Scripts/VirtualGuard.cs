using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "VirtualGuard")]
public class VirtualGuard : ScriptableObject {

    [SerializeField] string vname;  
    [SerializeField] int duration;  
    [TextArea(10, 14)][SerializeField] string helptext;

    ArrayList commands = new ArrayList();
}