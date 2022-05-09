using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intantiator : MonoBehaviour
{
    public int clonar;
    public GameObject objectToClone;
    
    public void CloneObject()
    {
        int num = clonar;
        while (num > 0)
        {
            num--;
            Instantiate(objectToClone);
        }
    }
}
