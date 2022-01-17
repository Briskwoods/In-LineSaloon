using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMovemntTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag == "Char1")
        {
            case true:
                other.GetComponent<Animator>().SetBool("isWalking", false);
                break;
            case false:
                break;
        }

        switch (other.tag == "Char2")
        {
            case true:
                other.GetComponent<Animator>().SetBool("isWalking", false);
                break;
            case false:
                break;
        }

        switch (other.tag == "Char3")
        {
            case true:
                other.GetComponent<Animator>().SetBool("isWalking", false);
                break;
            case false:
                break;
        }

        switch (other.tag == "Char4")
        {
            case true:
                other.GetComponent<Animator>().SetBool("isWalking", false);
                break;
            case false:
                break;
        }

        switch (other.tag == "Char5")
        {
            case true:
                other.GetComponent<Animator>().SetBool("isWalking", false);
                break;
            case false:
                break;
        }
    }

}
