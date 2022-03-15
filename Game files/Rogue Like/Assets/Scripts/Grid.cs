using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    [SerializeField]private int width, height;

    [SerializeField] private Tile prefab;

    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                var spawned_tile = Instantiate(prefab, new Vector3(i, j), Quaternion.identity);

                var isOffSet = (i % 2 == 0 && j % 2 != 0) || (i % 2 != 0 && j % 2 == 0);

                spawned_tile.InitColor(isOffSet);
            }
        }
    }
}
