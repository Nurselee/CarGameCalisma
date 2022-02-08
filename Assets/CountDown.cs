using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{

    public float timeStart = 10;
    public Text textBox;

    
    
    // Start is called before the first frame update
    void Start()
    {
        textBox.text = timeStart.ToString();
       
    }

    // Update is called once per frame
    void Update()
    {
        
        timeStart -= Time.deltaTime;
        if (timeStart == 0)
        {
            SceneManager.LoadScene(1);
            return;

        }
        else
            textBox.text = Mathf.Round(timeStart).ToString();
        
        
    }
}
