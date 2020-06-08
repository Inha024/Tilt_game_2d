using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathpit : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        Tilt.setIsDeadTrue();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Death")
        {
            Destroy(gameObject, .4f);
            Debug.Log("You Loose!");
        }

    }

}
