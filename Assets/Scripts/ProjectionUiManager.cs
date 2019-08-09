using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProjectionUiManager : MonoBehaviour
{
    [SerializeField]
    GameObject hamburgerMenu;

    _GM gameManager;

    private void Start()
    {
        hamburgerMenu.SetActive(false);
        gameManager = FindObjectOfType<_GM>();
    }

    public void GotoMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Recalibrate()
    {
        gameManager.ResetMarkers();
    }

    public void ToggleHamburgerMenu()
    {
        hamburgerMenu.SetActive(!hamburgerMenu.activeSelf);
    }
}
