using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject AuswahlPanel;

    // Start is called before the first frame update
    void Start()
    {
        AuswahlPanel.SetActive(false);
    }

    public void HideAuswahl()
    {
        AuswahlPanel.SetActive(false);
    }

    public void ShowAuswahlPanel()
    {
        AuswahlPanel.SetActive(true);
    }

    IEnumerator AnimateAuswahlPanel()
    {
        return null;
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
}
