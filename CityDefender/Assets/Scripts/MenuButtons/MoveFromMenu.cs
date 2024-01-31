using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFromMenu : MonoBehaviour
{

    public GameObject _mainMenu;
    public GameObject _nextScreen;

    public void OnClickMoveCredits()
    {
        _mainMenu.SetActive(false);
        _nextScreen.SetActive(true);
    }
}
