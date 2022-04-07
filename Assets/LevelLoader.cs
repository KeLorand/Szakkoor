using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader
{
    public static void load(Level level)
    {
        Texture2D texture = new Texture2D(100, 100);
        texture.LoadImage(System.IO.File.ReadAllBytes("Assets/Resources/icon.png"));
        Debug.Log(texture.width);
        for (int i = 0; i <= level.blocks.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= level.blocks.GetUpperBound(1); j++)
            {
                GameObject gobj = new GameObject(""+i+":"+j);
                SpriteRenderer sr = gobj.AddComponent<SpriteRenderer>();
                //sr.sprite = Resources.Load<Sprite>("Circle"); //Így is jó!
                sr.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f), Mathf.Max(texture.width, texture.height));
                gobj.transform.position = new Vector3(i * 1f, j * 1f, 100);
            }
        }
    }
}
