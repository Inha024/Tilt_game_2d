using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        Tilt.SetYouWinToTrue();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Goal")
        {
            Destroy(gameObject, .4f);
            Debug.Log("You Win!");
        }

    }

}
