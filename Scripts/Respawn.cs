using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    [SerializeField] private Transform m_Player;
    [SerializeField] private Transform m_RespawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        m_Player.transform.position = m_RespawnPoint.transform.position;
    }
}
