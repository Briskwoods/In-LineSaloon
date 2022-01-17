using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTrigger : MonoBehaviour
{

    public Transform m_Character;
    public Transform m_EndPoint;

    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        //m_Character.position = Vector3.MoveTowards(m_Character.position, m_EndPoint.position, 10 * Time.deltaTime);

    }

    // Update is called once per frame
    void Update()
    {
        m_Character.position = Vector3.MoveTowards(m_Character.position, m_EndPoint.position, 10 * Time.deltaTime);

    }
}
