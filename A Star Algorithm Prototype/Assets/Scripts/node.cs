using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class node {

    public bool canWalk;
    public Vector2 worldPosition;
    public int gridX;
    public int gridY;

    public int gCost;
    public int hCost;
    
    public int fCost
    {
        get
        {
            return gCost + hCost;
        }
    }

    public node(bool _canWalk, Vector2 _worldPos, int _gridX, int _gridY)
    {
        canWalk = _canWalk;
        worldPosition = _worldPos;
        gridX = _gridX;
        gridY = _gridY;
    }
}
