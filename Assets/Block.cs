using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Block
{
    //XXXXBTRL
    byte data;

    public Block(bool left, bool right, bool top, bool bottom)
    {

    }
    public Block(byte data)
    {
        this.data = data;
    }
    public Block(int data)
    {
        this.data = (byte)data;
    }



    public bool left
    {
        get { return (data & (byte)1) == (byte)1; }
    }
    public bool right
    {
        get { return (data & (byte)2) == (byte)2; }
    }

    public bool top
    {
        get { return (data & (byte)4) == (byte)4; }
    }

    public bool bottom
    {
        get { return (data & (byte)8) == (byte)8; }
    }

    public override string ToString()
    {
        return String.Format("{0:X}", data);
    }
}