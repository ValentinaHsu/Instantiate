using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public void CloneObject()
    {
        Instantiate(objectToClone);
    }
}
