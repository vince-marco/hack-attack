using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "VirutalStorage")]
public class VirutalStorage : ScriptableObject {

    [TextArea(10, 14)][SerializeField] string description;
}