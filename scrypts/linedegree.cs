using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linedegree : MonoBehaviour
{
    [SerializeField] GameObject mm;
    void Update()
    {
        gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
    }
}
