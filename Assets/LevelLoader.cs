using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader
{
    public static void load(Level level)
    {
        for (int x = 0; x <= level.blocks.GetUpperBound(0); x++)
        {
            for (int y = 0; y <= level.blocks.GetUpperBound(1); y++)
            {
                new Wall(level.blocks[x, y], x - 5, y - 3);
            }
        }
    }

}
