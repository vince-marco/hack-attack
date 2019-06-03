using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirtualTerm : MonoBehaviour
{
    [SerializeField] Text term1;
    [SerializeField] Text term2;
    [SerializeField] Text term3;
    [SerializeField] Text console;

    private Text term;

    // Start is called before the first frame update
    void Start()
    {
        var input = gameObject.GetComponent<InputField>();
        input.onEndEdit.AddListener(SubmitCmd);
        term = term1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SubmitCmd(string cmd) 
    {
        var input = gameObject.GetComponent<InputField>();
        if (input.text.Contains("term -1")) 
        {
            term = term1;
            term1.text += "\nTerminal-1 is active.\n";
        }
        else if (input.text.Contains(" -2")) 
        {
            term = term2;
            term1.text += "\nTerminal-2 is active.\n";
        }
        else if (input.text.Contains(" -3")) 
        {
            term = term1;
            term1.text += "\nTerminal-1 is active.\n";
        }
        else
        {
            term.text += "\n> ";
            term.text += input.text;
            term.text += "...executing\n";
        }
        input.text = "";
    }
}
