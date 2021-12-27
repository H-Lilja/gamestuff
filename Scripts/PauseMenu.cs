using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour {

    public GameObject m_PauseMenu;
    public bool m_IsPaused;

	void Update ()
    {
		
        if (Input.GetKeyDown(KeyCode.Escape))
            if (m_IsPaused)
                {
                m_IsPaused = false;
                m_PauseMenu.SetActive(false);
                Time.timeScale = 1f;
            }
        else
            {
                m_IsPaused = true;
                m_PauseMenu.SetActive(true);
                Time.timeScale = 0f;
            }
	}

    public void ResumeGame()
    {
        m_IsPaused = false;
        m_PauseMenu.SetActive(false);
        Time.timeScale = 1f;

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
