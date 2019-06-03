using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "VirtualFile")]
public class VirtualFile: ScriptableObject {

    [SerializeField] string filename;  
    [SerializeField] int size;  
    [TextArea(10, 14)][SerializeField] string helptext;
    private VirtualCmd[]  commands = {
        new VirtualCmd("list", "file list --local", "Lists remote files (unless --local)"),
        new VirtualCmd("download", "file download <name>", "Downloads the file"),
        new VirtualCmd("upload", "file upload <name>", "Uploads the file"),
        new VirtualCmd("encrypt", "file encrypt <name>", "Encrypts the file (must be on your local storage)"),
        new VirtualCmd("decrypt", "file decrypt <name>", "Decrypts the file (must be on your local storage"),
        new VirtualCmd("delete", "file delete <name>", "Deletes a remove file")
    };
}