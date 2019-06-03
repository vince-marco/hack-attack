using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class VirtualCmd {

    string cmd = "help";
    string usage = "";
    string help = "";
    public VirtualCmd(string acmd, string ausage, string ahelp) {
        cmd = acmd;
        usage = ausage;
        help = ahelp;
    }
}