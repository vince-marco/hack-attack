using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "VirtualNet")]
public class VirtualNet : ScriptableObject {

    [SerializeField] string subnet;
    [TextArea(10, 14)][SerializeField] string help;

    ArrayList connects = new ArrayList();
}