using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour {
    // This script is in the key object
    [SerializeField] private MoveTheGoddamnUnicorn m_Yas;
    private void Start()
    {
        m_Yas = FindObjectOfType<MoveTheGoddamnUnicorn>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            // When player collides with the keys, it adds to the players keycount and deactivates the keys in the scene
            m_Yas.m_KeyCount++;                         
            this.gameObject.SetActive(false);
        }
    }


}
