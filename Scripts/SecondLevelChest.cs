

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecondLevelChest : MonoBehaviour
{
    // This script is in the second level chest object
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
        if (collider.gameObject.name == "Player" && m_Yas.m_KeyCount >= 5) 
        {
            m_ChestAnimator.SetTrigger("Open");
            // Loads next scene after 5 frames.
            Invoke("NextLevel", 4f); 
        }
    }
    void NextLevel()
    {
        SceneManager.LoadScene("ThirdLevel");
    }
}