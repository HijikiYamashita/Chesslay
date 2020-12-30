/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceController : MonoBehaviour
{
    int[][] boardStatus;

    public GameObject[] pieces;

    void Start()
    {
        int[][] boardStatus =
        {
                new int[] {0,0,0,0,0,0,0,0},
                new int[] {0,0,0,0,0,0,0,0},
                new int[] {0,0,0,0,0,0,0,0},
                new int[] {0,0,0,0,0,0,0,0},
                new int[] {0,0,0,0,0,0,0,0},
                new int[] {0,0,0,0,0,0,0,0},
                new int[] {1,2,3,4,5,6,7,8},
                new int[] {9,10,11,12,13,14,15,16}
            };

        for (int i = 0; i < boardStatus.Length; i++)
        {
            for (int j = 0; j < boardStatus[i].Length; j++)
            {
                if (boardStatus[i][j] > 0 && boardStatus[i][j] <= 16)
                {
                    Instantiate(pieces[boardStatus[i][j]], new Vector3(-3.5f + j, 0.35f, 3.5f - i), Quaternion.identity);
                }
            }
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {

        }
    }
}
*/