using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackMenu : MonoBehaviour
{
    public GameObject _mainMenu;
    public GameObject _nextScreen;

    public void OnClickMoveCredits()
    {
        _mainMenu.SetActive(true);
        _nextScreen.SetActive(false);
    }
}
