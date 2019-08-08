using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    public GameObject auswahlPanel;
    public GameObject confirmPanel;
    [SerializeField]
    public Sprite[] sprites = new Sprite[6];
    [SerializeField]
    public Image anzeigeBild;

    public Material[] materials = new Material[6];

    private _GM gameManager;

    // Start is called before the first frame update
    void Start()
    {
        auswahlPanel.SetActive(false);
        confirmPanel.SetActive(false);
        gameManager = FindObjectOfType<_GM>();

    }

    public void HideAuswahl()
    {
        auswahlPanel.SetActive(false);
    }

    public void HideConfirm()
    {
        confirmPanel.SetActive(false);
    }

    public void ShowAuswahlPanel()
    {
        auswahlPanel.SetActive(true);
    }

    public void ShowConfirmPanel()
    {
        anzeigeBild.sprite = sprites[gameManager.bildIndex];
        confirmPanel.SetActive(true);
    }

    public void QuitApplication()
    {
        Debug.Log("Exiting...");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void GotoProjection()
    {
        SceneManager.LoadScene(1);
    }

    public void GotoMenu()
    {
        SceneManager.LoadScene(0);
    }




}
