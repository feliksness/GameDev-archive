using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camermove : MonoBehaviour
{
    [SerializeField] Scrollbar ss;
    [SerializeField] bool vertical;
    [SerializeField]int a, b;
    void FixedUpdate()
    {
        if (vertical == false)
        {
            gameObject.transform.position = new Vector3(a + (ss.value * b), gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if (vertical == true)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, a + (ss.value * b), gameObject.transform.position.z);
        }
    }
}
