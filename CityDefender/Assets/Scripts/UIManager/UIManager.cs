using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TMPro.TextMeshProUGUI _timer;
    public TMPro.TextMeshProUGUI _timeScore;
    public GameObject _loosePanel;
    private float _timeValue = 0;
    


    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "GameScene")
        {
            _timeValue += Time.deltaTime;
            _timer.text = "Time: " + _timeValue.ToString("0.00");
        }
    }

    public void OnDeathShowPanel()
    {
        _loosePanel.SetActive(true);
    }
}
