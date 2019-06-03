using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirtualSystem : MonoBehaviour {

    private float timeLeft = 30.0f;
    [SerializeField] public Text textview;
    [SerializeField] public com.ootii.Actors.SpiderDriver driver;
    [TextArea(2, 5)][SerializeField] string consoleGreeting;
    [TextArea(2, 5)][SerializeField] string term1Greeting;
    [TextArea(2, 5)][SerializeField] string term2Greeting;
    [TextArea(2, 5)][SerializeField] string term3Greeting;
    private VirtualCmd[]  commands = {};

  // Start is called before the first frame update
    void Start()
    {
      gameObject.active = false;
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
      if (Input.GetKeyUp("c")) {
        Transform canvas = transform.Find("Canvas");
        bool isConsole = canvas.gameObject.active;
        driver.IsEnabled = isConsole;
        canvas.gameObject.active = !isConsole;
      }
    }

    void doCommand(string cmd) {
      Debug.Log("perofrming cmd: " + cmd.ToString());
      if (cmd.StartsWith("door ")) {
        string[] words = cmd.Split(' ');
        // if (words[0] == "door" && words[1] == "unlock") {
        //   VirtualDoor[] doors = GameObject
        // }
      }
    }

}