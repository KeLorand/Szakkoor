using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader
{
    public static void load(Level level)
    {
        //GameObject asd = (GameObject)Resources.Load("Wall", typeof(GameObject));
        for (int i = 0; i <= level.blocks.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= level.blocks.GetUpperBound(1); j++)
            {

                //GameObject asd = (GameObject)(new Wall());
                GameObject asd = new GameObject(""+i+":"+j);
                SpriteRenderer sr = asd.AddComponent<SpriteRenderer>();
                asd.GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load("unity_builtin_extra/Knob", typeof(Sprite));
                //Transform tr = asd.AddComponent<Transform>();
                asd.transform.position = new Vector3(i, j, 100);

            }
        }
    }
}
