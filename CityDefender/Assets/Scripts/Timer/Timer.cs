using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI _timer;
    private  float _currentTime = 0;
   
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
        
        if(SceneManager.GetActiveScene().name == "GameScene")
        {
            _currentTime += Time.deltaTime;
            _timer.text = "Time\n" + _currentTime.ToString("0.00");
        }
        




    }
}
