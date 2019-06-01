using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualServer : MonoBehaviour {

    [SerializeField] string hostname;  
    [SerializeField] string ip;  
    [SerializeField] int cores;  
   [TextArea(10, 14)][SerializeField] string helptext;
   [TextArea(10, 14)][SerializeField] string greeting;
   [TextArea(10, 14)][SerializeField] string ping;
   [TextArea(10, 14)][SerializeField] string unauthorized;

  // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    void FixedUpdate()
    {

    }
}