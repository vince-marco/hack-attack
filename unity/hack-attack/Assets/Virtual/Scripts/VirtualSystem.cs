using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirtualSystem : MonoBehaviour {

    private float timeLeft = 30.0f;
    [SerializeField] Text textview;
    [TextArea(2, 5)][SerializeField] string consoleGreeting;
    [TextArea(2, 5)][SerializeField] string term1Greeting;
    [TextArea(2, 5)][SerializeField] string term2Greeting;
    [TextArea(2, 5)][SerializeField] string term3Greeting;

  // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
      timeLeft -= Time.deltaTime;
      if (timeLeft < 0) {
        //Logger.info("VirtualSystem...running.");
        textview.text += "VirtualSystem...running.\n\n";
        timeLeft = 30.0f;
      }
    }
    void FixedUpdate()
    {

    }

}