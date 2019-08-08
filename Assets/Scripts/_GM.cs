using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _GM : MonoBehaviour
{
    [SerializeField]
    GameObject drawArea;

    List<GameObject> markers = new List<GameObject>();

    bool markersSet
    {
        get
        {
          return markers.Count == 4;
        }
    }

    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    void ResetMarker()
    {
        markers = new List<GameObject>();
    }

    void SetDrawPlane()
    {
        Debug.Log("Draw Plane");
        Debug.Log(markers);

        Vector3 sum = Vector3.zero;

        foreach (var v in markers)
        {
            sum += v.transform.position;
        }
        sum /= 4;

        drawArea.transform.position = sum;
        drawArea.SetActive(true);

        ResetMarker();

    }

    public void AddMarker(GameObject marker)
    {

        markers.Add(marker);

        if (markersSet)
        {
            SetDrawPlane();
        }
    }
}
