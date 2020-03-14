using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem : MonoBehaviour
{
    [SerializeField]
    private int rows = 100;
    [SerializeField]
    private int cols = 100;
    [SerializeField]
    private float tileSize = 1.1f;

    void Start()
    {
        GenerateGrid();
        
    }

    private void GenerateGrid()
    {
        GameObject tilePointer = (GameObject)Instantiate(Resources.Load("Tile"));

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                GameObject tile = (GameObject)Instantiate(tilePointer, transform);
                float posX = i * tileSize;
                float posY = j * tileSize;
                tile.transform.position = new Vector2(posX, posY);
            }
        }
        Destroy(tilePointer);

        float gridW = cols * tileSize;
        float gridH = rows * tileSize;
        transform.position = new Vector2(0, 0);
    }

    void Update()
    {
        
    }
}
