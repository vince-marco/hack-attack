using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "VirtualNet")]
public class VirtualNet : ScriptableObject {

    [TextArea(10, 14)][SerializeField] string help;

    [SerializeField] ArrayList<VirtualConnect>  connects = new ArrayList<VirtualConnect>();
}