using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnicornMove : MonoBehaviour {

    [SerializeField] private float m_Speed = 2f;
    private float m_JumpForce = 8f;
    private float m_Gravity = 30f;
    private Vector3 m_MoveDir = Vector3.zero;
    public int m_KeyCount = 0;
    public Animator m_Animator;
    float m_HorizontalMove = 0f;
    float m_VerticalMove = 0f;

    void Update()
    {


        
        CharacterController controller = gameObject.GetComponent<CharacterController>();

        if (controller.isGrounded)
        {
            m_MoveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));  // Moves the thing
            m_MoveDir = transform.TransformDirection(m_MoveDir);
            m_MoveDir *= m_Speed;

            if (Input.GetButtonDown ("Jump"))  // Makes jump
            {
                m_MoveDir.y = m_JumpForce;
            }
        }

        m_MoveDir.y -= m_Gravity * Time.deltaTime;
        controller.Move(m_MoveDir * Time.deltaTime);


        m_VerticalMove = Input.GetAxisRaw("Vertical") * m_Speed;
        m_HorizontalMove = Input.GetAxisRaw("Horizontal") * m_Speed;
        m_Animator.SetFloat("Speed", Mathf.Abs(m_VerticalMove));
        m_Animator.SetFloat("Sideways", Mathf.Abs(m_HorizontalMove));


    }

    

}
