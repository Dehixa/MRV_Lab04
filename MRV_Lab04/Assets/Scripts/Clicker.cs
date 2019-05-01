using System.Collections;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    public bool clicked()
    {
        return Input.anyKeyDown;
    }
}
