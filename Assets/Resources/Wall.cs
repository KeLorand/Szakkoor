using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall// : MonoBehaviour
{
    public enum Pos{
        top, bottom, left, right
    }

    static Texture2D texture = null;

    Block m_block = new Block(0);

    int x, y;

    GameObject top = null;
    GameObject bottom = null;
    GameObject left = null;
    GameObject right = null;

    public Wall(Block block, int x, int y)
    {
        if (texture == null) {
            texture = new Texture2D(128, 128);
            texture.LoadImage(System.IO.File.ReadAllBytes("Assets/Resources/icon.png"));
            //Debug.Log(texture.width);
        }
        this.x = x;
        this.y = y;
        this.block = block;
    }

    void Create(Pos pos)
    {
        GameObject gobj = new GameObject("" + x + ":" + y + " - " + pos.ToString());
        SpriteRenderer sr = gobj.AddComponent<SpriteRenderer>();
        sr.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f), Mathf.Max(texture.width, texture.height));
        //Debug.Log(pos.ToString());
        //Debug.Log("Create");
        switch (pos)
        {
            case Pos.top:
                gobj.transform.localScale = new Vector3(1, 0.1f, 0);
                gobj.transform.position = new Vector3(x, y + 0.45f, 100);
                break;
            case Pos.bottom:
                gobj.transform.localScale = new Vector3(1, 0.1f, 0);
                gobj.transform.position = new Vector3(x, y - 0.45f, 100);
                break;
            case Pos.left:
                gobj.transform.localScale = new Vector3(0.1f, 1, 0);
                gobj.transform.position = new Vector3(x - 0.45f, y, 100);
                break;
            case Pos.right:
                gobj.transform.localScale = new Vector3(0.1f, 1, 0);
                gobj.transform.position = new Vector3(x + 0.45f, y, 100);
                break;
            default:
                break;
        }

        //sr.sprite = Resources.Load<Sprite>("Circle"); //Így is jó!
        //gobj.transform.localScale = new Vector3(10, 10, 10);
    }

    public Block block
    {
        get { 
            return m_block; 
        }
        set {
            /*Debug.Log(m_block.top);
            Debug.Log(value.top);
            Debug.Log(value.ToString());*/
            if (m_block.top && !value.top) Object.Destroy(top);
            if (!m_block.top && value.top) Create(Pos.top);
            if (m_block.bottom && !value.bottom) Object.Destroy(bottom);
            if (!m_block.bottom && value.bottom) Create(Pos.bottom);
            if (m_block.left && !value.left) Object.Destroy(left);
            if (!m_block.left && value.left) Create(Pos.left);
            if (m_block.right && !value.right) Object.Destroy(right);
            if (!m_block.right && value.right) Create(Pos.right);
            m_block = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
