using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "VirtualServer")]
public class VirtualServer: MonoBehavior {

    [SerializeField] string hostname;  
    [SerializeField] string ip;  
    [SerializeField] int cores;  
   [TextArea(10, 14)][SerializeField] string helptext;
   [TextArea(10, 14)][SerializeField] string greeting;
   [TextArea(10, 14)][SerializeField] string ping;
   [TextArea(10, 14)][SerializeField] string unauthorized;
}