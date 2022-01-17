using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public DialogueTrigger m_IntroDialogue;

    public GameObject m_Character1;
    public GameObject m_Character2;
    public GameObject m_Character3;
    public GameObject m_Character4;
    public GameObject m_Character5;

    public Animator m_character1Anim;
    public Animator m_character2Anim;
    public Animator m_character3Anim;
    public Animator m_character4Anim;
    public Animator m_character5Anim;

    public GameObject Trigger1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Trigger1.GetComponent<MovementTrigger>().enabled = true;
            m_character1Anim.SetBool("isWalking", true);
        }

        else if (Input.GetKeyDown(KeyCode.W))
        {
            m_character1Anim.SetBool("isWalking", false);
        }

        else if (Input.GetKeyDown(KeyCode.E))
        {
            m_character1Anim.SetTrigger("Wave");
        }

        else if (Input.GetKeyDown(KeyCode.R))
        {
            m_IntroDialogue.TriggerDialogue();
        }

        else if (Input.GetKeyDown(KeyCode.T))
        {
            m_character2Anim.SetBool("isWalking", true);
            m_Character2.GetComponent<CharacterController>().enabled = true;
        }

        else if (Input.GetKeyDown(KeyCode.Y))
        {
            m_character3Anim.SetBool("isWalking", true);
            m_Character3.GetComponent<CharacterController>().enabled = true;
        }

        else if (Input.GetKeyDown(KeyCode.U))
        {
            m_character4Anim.SetBool("isWalking", true);
            m_Character4.GetComponent<CharacterController>().enabled = true;

        }

        else if (Input.GetKeyDown(KeyCode.I))
        {
            m_character5Anim.SetBool("isWalking", true);
            m_Character5.GetComponent<CharacterController>().enabled = true;

        }

        else if (Input.GetKeyDown(KeyCode.O))
        {
            Trigger1.GetComponent<MovementTrigger>().enabled = false;
            m_Character1.GetComponent<CharacterController>().enabled = true;
            m_character1Anim.SetBool("isWalking", true);
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            m_character1Anim.SetTrigger("Sit");
            m_character2Anim.SetTrigger("Sit");
            m_character3Anim.SetTrigger("Sit");
            m_character4Anim.SetTrigger("Sit");
            m_character5Anim.SetTrigger("Sit");
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            m_Character1.GetComponent<LookAtCamera>().enabled = true;
            m_Character2.GetComponent<LookAtCamera>().enabled = true;
            m_Character3.GetComponent<LookAtCamera>().enabled = true;
            m_Character4.GetComponent<LookAtCamera>().enabled = true;
            m_Character5.GetComponent<LookAtCamera>().enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            m_character1Anim.SetTrigger("Stand");
            m_character2Anim.SetTrigger("Stand");
            m_character3Anim.SetTrigger("Stand");
            m_character4Anim.SetTrigger("Stand");
            m_character5Anim.SetTrigger("Stand");
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            m_character1Anim.SetTrigger("Win");
            m_character2Anim.SetTrigger("Win");
            m_character3Anim.SetTrigger("Win");
            m_character4Anim.SetTrigger("Win");
            m_character5Anim.SetTrigger("Win");
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            m_character1Anim.SetTrigger("Lose");
            m_character2Anim.SetTrigger("Lose");
            m_character3Anim.SetTrigger("Lose");
            m_character4Anim.SetTrigger("Lose");
            m_character5Anim.SetTrigger("Lose");
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            m_Character1.GetComponent<LookAtCamera>().enabled = false;
            m_Character2.GetComponent<LookAtCamera>().enabled = false;
            m_Character3.GetComponent<LookAtCamera>().enabled = false;
            m_Character4.GetComponent<LookAtCamera>().enabled = false;
            m_Character5.GetComponent<LookAtCamera>().enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {

        }
        else if (Input.GetKeyDown(KeyCode.J))
        {

        }
        else if (Input.GetKeyDown(KeyCode.K))
        {

        }
        else if (Input.GetKeyDown(KeyCode.L))
        {

        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {

        }
    }


    [ContextMenu("StartIntro")]
    public void WalkIntoShop()
    {
        StartCoroutine(PlayIntro());
    }


    [ContextMenu("Win")]
    public void StandAndCelebrate()
    {
        StartCoroutine(PlayWin());
    }

    [ContextMenu("Lose")]
    public void StandAndStomp()
    {
        StartCoroutine(PlayLose());
    }


    IEnumerator PlayIntro()
    {
        m_Character1.GetComponent<CharacterController>().enabled = true;
        m_character1Anim.SetBool("isWalking", true);
        yield return new WaitForSeconds(0.5f);
        m_character2Anim.SetBool("isWalking", true);
        m_Character2.GetComponent<CharacterController>().enabled = true;
        yield return new WaitForSeconds(0.5f);
        m_character3Anim.SetBool("isWalking", true);
        m_Character3.GetComponent<CharacterController>().enabled = true;
        yield return new WaitForSeconds(0.5f);
        m_character4Anim.SetBool("isWalking", true);
        m_Character4.GetComponent<CharacterController>().enabled = true;
        yield return new WaitForSeconds(0.5f);
        m_character5Anim.SetBool("isWalking", true);
        m_Character5.GetComponent<CharacterController>().enabled = true;
        yield return new WaitForSeconds(5f);
        m_IntroDialogue.TriggerDialogue();
        m_Character1.GetComponent<LookAtCamera>().enabled = true;
        m_Character2.GetComponent<LookAtCamera>().enabled = true;
        m_Character3.GetComponent<LookAtCamera>().enabled = true;
        m_Character4.GetComponent<LookAtCamera>().enabled = true;
        m_Character5.GetComponent<LookAtCamera>().enabled = true;
        yield return new WaitForSeconds(5f);
        m_IntroDialogue.DisplayNextLine();
        m_Character1.GetComponent<LookAtCamera>().enabled = false;
        m_Character2.GetComponent<LookAtCamera>().enabled = false;
        m_Character3.GetComponent<LookAtCamera>().enabled = false;
        m_Character4.GetComponent<LookAtCamera>().enabled = false;
        m_Character5.GetComponent<LookAtCamera>().enabled = false;
        yield return new WaitForSeconds(2f);
        m_character1Anim.SetTrigger("Sit");
        m_character2Anim.SetTrigger("Sit");
        m_character3Anim.SetTrigger("Sit");
        m_character4Anim.SetTrigger("Sit");
        m_character5Anim.SetTrigger("Sit");
        StopAllCoroutines();
    }



    IEnumerator PlayWin()
    {
        m_character1Anim.SetTrigger("Stand");
        m_character2Anim.SetTrigger("Stand");
        m_character3Anim.SetTrigger("Stand");
        m_character4Anim.SetTrigger("Stand");
        m_character5Anim.SetTrigger("Stand");
        yield return new WaitForSeconds(1.5f);
        m_character1Anim.SetTrigger("Win");
        m_character2Anim.SetTrigger("Win");
        m_character3Anim.SetTrigger("Win");
        m_character4Anim.SetTrigger("Win");
        m_character5Anim.SetTrigger("Win");
        StopAllCoroutines();
    }

    IEnumerator PlayLose()
    {
        m_character1Anim.SetTrigger("Stand");
        m_character2Anim.SetTrigger("Stand");
        m_character3Anim.SetTrigger("Stand");
        m_character4Anim.SetTrigger("Stand");
        m_character5Anim.SetTrigger("Stand");
        yield return new WaitForSeconds(1.5f);
        m_character1Anim.SetTrigger("Lose");
        m_character2Anim.SetTrigger("Lose");
        m_character3Anim.SetTrigger("Lose");
        m_character4Anim.SetTrigger("Lose");
        m_character5Anim.SetTrigger("Lose");
        StopAllCoroutines();
    }
}
