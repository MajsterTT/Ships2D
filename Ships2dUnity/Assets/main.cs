using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TerrainNode tile1=new TerrainNode();
        tile1.height="2";

        Debug.Log(tile1.height);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
