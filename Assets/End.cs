using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            StartCoroutine(waiter());
        }
    }

    IEnumerator waiter()
    {
        GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(2);
        Application.Quit();
        print("Worked");
    }
}


