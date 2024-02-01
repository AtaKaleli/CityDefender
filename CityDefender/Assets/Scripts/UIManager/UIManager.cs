using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TMPro.TextMeshProUGUI _timer;
    public TMPro.TextMeshProUGUI _timeScore;
    public GameObject _loosePanel;
    public SpriteRenderer _backGround;
    private float _timeValue = 0;
    public Image _shotReload;


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
        _timeScore.text = "You have successfully defended your city \n" + _timeValue.ToString("0.00") + "\nminutes";
        _backGround.color = Color.red;
        _loosePanel.SetActive(true);
    }

    public void UpdateShotReload(float readyness)
    {
        _shotReload.fillAmount = readyness;
    }
}
