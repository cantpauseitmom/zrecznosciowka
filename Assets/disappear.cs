using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappear : MonoBehaviour
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
            yield return new WaitForSeconds(1);
            GetComponent<Collider>().enabled = false;
            yield return new WaitForSeconds(2);
            GetComponent<Collider>().enabled = true;
    }
}