using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChestScript : MonoBehaviour
{
    [SerializeField] private MoveTheGoddamnUnicorn m_Yas;
    //public Animation m_ChestOpen;
    public Animator m_ChestAnimator;

    private void Start()
    {
        m_ChestAnimator = GetComponent<Animator>();
        //m_ChestOpen = GetComponent<Animation>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        // When player is on the trigger and has 5 keys, an animation plays.
        if (collider.gameObject.name == "Player" && m_Yas.m_KeyCount >=5) 
        {
            m_ChestAnimator.SetTrigger("Open");
            Invoke("NextLevel", 4f); // Loads next scene after 5 frames.
        }

    }

    void NextLevel()
    {
        SceneManager.LoadScene("SecondLevel");
    }
}

	
