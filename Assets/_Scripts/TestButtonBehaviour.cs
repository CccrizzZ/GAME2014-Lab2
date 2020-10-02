using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TestButtonBehaviour : MonoBehaviour
{
    public TMP_Text SceneLabel;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public void OnTestButtonPressed()
    {
        if (SceneLabel.text != "Test")
        {
            Debug.Log("Test Button Pressed");
            SceneLabel.text = "Test";            
        }
        else
        {
            Debug.Log("Test Button Pressed");
            SceneLabel.text = "Play Scene";      
        }

    }


}
