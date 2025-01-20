using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] Avengers = new string[] {"IronMan", "CaptainAmerica", "Spiderman"};
        string[] DCComics = new string[3];
        DCComics[0] = "SuperMan";
        DCComics[1] = "BatMan";
        DCComics[2] = "AquaMan";

        string[,] heros = new string[,] {{}, {}};
        // string [][] newHeros = new string[2][];
        // newHeros[0] = new string[] {"IronMan", "CaptainAmerica", "Spiderman"};
        // newHeros[1] = new string[] {"SuperMan", "BatMan", "AquaMan"};
        // Debug.Log(newHeros[1][1]);

        string[][] newHeros = new string[][]
        {
            new string[]{""},
            new string[]{""}
        };
    }

    // Update is called once per frame
    public void TwoDarrToOneDarr()
    {
        int[,] arr2D = new int[,] {{1, 2}, {3, 4}, {5, 6}};
        int[] arr1D = new int[arr2D.GetLength((0)) * arr2D.GetLength((1))];

        for(int i = 0; i < arr2D.GetLength(0); i++)
        {
            for(int j = 0; j < arr2D.GetLength(1); j++)
            {
                arr1D[arr2D.GetLength(1) * i + j] = arr2D[i, j];
            }
        }
    }
}
