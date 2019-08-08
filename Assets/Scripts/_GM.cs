using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _GM : MonoBehaviour
{
    [SerializeField]
    GameObject drawArea;

    GameObject[] markers = new GameObject[4];
    bool markersSet
    {
        get
        {
            return markers.Length == 4;
        }
    }

    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    void FixedUpdate()
    {
        if (markersSet)
        {

            Vector3 sum = Vector3.zero;
            foreach(var v in markers){
                sum += v.transform.position;
            }
            sum /= 4;
            drawArea.transform.position = sum;
            drawArea.SetActive(true);
        }
    }

    public bool AddMarker(GameObject marker)
    {
        if (!markersSet)
        {
            markers[markers.Length] = marker;
            return true;
        }

        return false;
    }
}
