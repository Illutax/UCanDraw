using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _GM : MonoBehaviour
{
    public int bildIndex;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPictureToDraw(int sender)
    {
        bildIndex = sender;

    }
}
