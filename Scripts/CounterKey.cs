
using UnityEngine;
using UnityEngine.UI;

public class CounterKey : MonoBehaviour {

    //get the number of keys from the player script, which we need to reference in the editor
    [SerializeField] private MoveTheGoddamnUnicorn m_Yas; 
    public Text m_KeyAmountText;
    public float m_TheNumber; 

    private void Start()
    {
        m_Yas = FindObjectOfType<MoveTheGoddamnUnicorn>();
    }


    void Update ()
    {
        // The number is the same thing as the keycount in the player script
        m_TheNumber = m_Yas.m_KeyCount;
        // Displays the number of keys in the screen 
        m_KeyAmountText.text = m_TheNumber.ToString();   
		
	}
}
