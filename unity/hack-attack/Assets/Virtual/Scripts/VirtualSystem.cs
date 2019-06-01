using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "VirtualSystem")]
public class VirtualSystem : MonoBehavior {

    [TextArea(2, 5)][SerializeField] string consoleGreeting;
    [TextArea(2, 5)][SerializeField] string term1Greeting;
    [TextArea(2, 5)][SerializeField] string term2Greeting;
    [TextArea(2, 5)][SerializeField] string term3Greeting;

}