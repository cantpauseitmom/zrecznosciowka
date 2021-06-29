using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport1 : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (col.gameObject.tag == "Player")
        {
            player.transform.position = new Vector3(-20, 15, 3);
        }
    }
}