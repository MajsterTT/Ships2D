using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
   TerrainNode[,] gridTable=new TerrainNode[100,100];

    for(int i=0; i<gridTable.GetLength(0); i++)
    {
        for(int r=0; r<gridTable.GetLength(1); r++)
        {
            //nazwa dla tile z i oraz r
            TerrainNode tile=new TerrainNode();
            tile.height="2";
            tile.height="2";
            tile.height="2";
            tile.height="2";
            tile.height="2";
        }
    }

}
