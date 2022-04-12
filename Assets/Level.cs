using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level
{
    public Block[,] blocks = new Block[11, 6];

    public void Clear()
    {
        for (int i = 0; i <= blocks.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= blocks.GetUpperBound(1); j++)
            {
                blocks[i, j] = new Block(Random.Range(0,16));
            }
        }
    }

    public Level(string filename)
    {
        Clear();
        foreach (string s in new System.IO.StreamReader(filename).ReadToEnd().Trim().Split('\n'))
        {
            Debug.Log(s);
        }
    }
    public Level()
    {
        Clear();
    }

    public override string ToString()
    {
        string s = "";
        for (int i = 0; i <= blocks.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= blocks.GetUpperBound(1); j++)
            {
                s += blocks[i, j].ToString() + (blocks[i, j].ToString().Length == 1 ? "  " : " ");
            }
            s += "\n";
        }
        return s;
    }
}
