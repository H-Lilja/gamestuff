using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheGoddamnUnicorn : MonoBehaviour {

    private CharacterController m_CharacterController;  
    private Animator m_Animator;
    public int m_KeyCount = 0;
    //The speeds are changeable in the unity editor.
    [SerializeField] private float m_Movespeed = 100f;  
    [SerializeField] private float m_TurnSpeed = 5f;  

    private void Awake()
    {
        //get the character controller component on awake so we can use it
        m_CharacterController = GetComponent<CharacterController>();
        // get the animator so we can use the animations
        m_Animator = GetComponentInChildren<Animator>(); 
    }

    private void Update()
    {
        var m_Horizontal = Input.GetAxis("Horizontal"), m_Vertical = Input.GetAxis("Vertical"), 
            m_Movement = new Vector3(m_Horizontal, 0, m_Vertical);
        // Get the basic movement with this
        m_CharacterController.SimpleMove(m_Movement * Time.deltaTime * m_Movespeed);
        m_Animator.SetFloat("Speed", m_Movement.magnitude );

        if (m_Movement.magnitude > 0)
        {
            Quaternion m_NewDirection = Quaternion.LookRotation(m_Movement); // Makes the chracter turn
            transform.rotation = Quaternion.Slerp(transform.rotation, m_NewDirection, Time.deltaTime * m_TurnSpeed);
        }
    }

}
