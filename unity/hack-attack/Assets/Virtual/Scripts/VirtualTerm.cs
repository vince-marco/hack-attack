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

    // Start is called before the first frame update
    void Start()
    {
        var input = gameObject.GetComponent<InputField>();
        input.onEndEdit.AddListener(SubmitCmd);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SubmitCmd(string cmd) 
    {
        var input = gameObject.GetComponent<InputField>();
        if (input.text.Contains(" -1")) 
        {
            term1.text += "\n> ";
            term1.text += input.text;
            term1.text += "...executing\n";
        }
        else if (input.text.Contains(" -2")) 
        {
            term2.text += "\n> ";
            term2.text += input.text;
            term2.text += "...executing\n";
        }
        else if (input.text.Contains(" -3")) 
        {
            term3.text += "\n> ";
            term3.text += input.text;
            term3.text += "...executing\n";
        }
        else
        {
            console.text += "\n> ";
            console.text += input.text;
            console.text += "...executing\n";
        }
        input.text = "";
    }
}
