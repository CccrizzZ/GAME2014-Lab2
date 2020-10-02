using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //public TMP_Text SceneLabel;
    public TMP_Text LifeLabel;
    public TMP_Text ScoreLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (Input.deviceOrientation)
        {
            case DeviceOrientation.LandscapeLeft:
                LifeLabel.rectTransform.anchoredPosition = new Vector2(370.0f, -105f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-349.0f, -105f);
               
                break;
            case DeviceOrientation.LandscapeRight:
                LifeLabel.rectTransform.anchoredPosition = new Vector2(248.0f, -105f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-490.0f, -105f);
           

                break;
            case DeviceOrientation.Portrait:
                LifeLabel.rectTransform.anchoredPosition = new Vector2(248.0f, -185f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-349.0f, -185f);
               
                break;
            case DeviceOrientation.Unknown:
                break;
        }

    }
}
