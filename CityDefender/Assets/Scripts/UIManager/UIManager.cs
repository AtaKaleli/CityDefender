using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TMPro.TextMeshProUGUI _timer;
    public TMPro.TextMeshProUGUI _timeScore;
    public TMPro.TextMeshProUGUI _powerShotInfo;
    public TMPro.TextMeshProUGUI _lineInfo;
    public TMPro.TextMeshProUGUI _bossInfo;
    public AudioSource _lostAudio;
    public GameObject _loosePanel;
    public SpriteRenderer _backGround;
    private float _timeValue = 0;
    public Image _shotReload;
    private bool[] ifFlags = { false, false, false };

    

    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "GameScene")
        {
            _timeValue += Time.deltaTime;
            _timer.text = "Time: " + _timeValue.ToString("0.00");

        }
        if (_timeValue>0 && _timeValue<1)
        {
            _bossInfo.enabled = false;
        } 
        if (_timeValue > 10 && !ifFlags[0])
        {
            
            ifFlags[0] = true;
            _powerShotInfo.enabled = false;
            _lineInfo.enabled = false;
        }
        if(_timeValue > 20 && !ifFlags[1])
        {
            
            ifFlags[1] = true;
            _bossInfo.enabled = true;
        }
        if(_timeValue > 25 && !ifFlags[2])
        {
            
            ifFlags[2] = true;
            _bossInfo.enabled = false;

        }
    }

    public void OnDeathShowPanel()
    {
        _lostAudio.Play();
        _timeScore.text = "You have successfully defended your city \n" + _timeValue.ToString("0.00") + "\n Seconds";
        _backGround.color = Color.red;
        _loosePanel.SetActive(true);
    }

    public void UpdateShotReload(float readyness)
    {
        _shotReload.fillAmount = readyness;
    }
}
