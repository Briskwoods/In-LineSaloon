using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementTrigger : MonoBehaviour
{
    [SerializeField] private Transform Target1;
    [SerializeField] private Transform Target2;
    [SerializeField] private Transform Target3;
    [SerializeField] private Transform Target4;
    [SerializeField] private Transform Target5;

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag == "Char1")
        {
            case true:
                other.GetComponent<CharacterController>().target = Target1;
                other.transform.LookAt(Target1);
                break;
            case false:
                break;
        }

        switch (other.tag == "Char2")
        {
            case true:
                other.GetComponent<CharacterController>().target = Target2;
                other.transform.LookAt(Target2);
                break;
            case false:
                break;
        }

        switch (other.tag == "Char3")
        {
            case true:
                other.GetComponent<CharacterController>().target = Target3;
                other.transform.LookAt(Target3);
                break;
            case false:
                break;
        }

        switch (other.tag == "Char4")
        {
            case true:
                other.GetComponent<CharacterController>().target = Target4;
                other.transform.LookAt(Target4);
                break;
            case false:
                break;
        }

        switch (other.tag == "Char5")
        {
            case true:
                other.GetComponent<CharacterController>().target = Target5;
                other.transform.LookAt(Target5);
                break;
            case false:
                break;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        switch (other.tag == "Char1")
        {
            case true:
                other.GetComponent<CharacterController>().target = Target1;
                                break;
            case false:
                break;
        }

        switch (other.tag == "Char2")
        {
            case true:
                other.GetComponent<CharacterController>().target = Target2;
                                break;
            case false:
                break;
        }

        switch (other.tag == "Char3")
        {
            case true:
                other.GetComponent<CharacterController>().target = Target3;
                                break;
            case false:
                break;
        }

        switch (other.tag == "Char4")
        {
            case true:
                other.GetComponent<CharacterController>().target = Target4;
                                break;
            case false:
                break;
        }

        switch (other.tag == "Char5")
        {
            case true:
                other.GetComponent<CharacterController>().target = Target5;
                                break;
            case false:
                break;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        switch (other.tag == "Char1")
        {
            case true:
                other.GetComponent<CharacterController>().target = Target1;
                                break;
            case false:
                break;
        }

        switch (other.tag == "Char2")
        {
            case true:
                other.GetComponent<CharacterController>().target = Target2;
                                break;
            case false:
                break;
        }

        switch (other.tag == "Char3")
        {
            case true:
                other.GetComponent<CharacterController>().target = Target3;
                                break;
            case false:
                break;
        }

        switch (other.tag == "Char4")
        {
            case true:
                other.GetComponent<CharacterController>().target = Target4;
                                break;
            case false:
                break;
        }

        switch (other.tag == "Char5")
        {
            case true:
                other.GetComponent<CharacterController>().target = Target5;
                                break;
            case false:
                break;
        }
    }
}
