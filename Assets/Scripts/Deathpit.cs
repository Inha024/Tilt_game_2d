using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathpit : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        Tilt.setIsDeadTrue();
        {
            if (col.name == "Death")
            {
                Destroy(gameObject, .4f);
                Debug.Log("You Loose!");
            }


        }
    }
}

  
