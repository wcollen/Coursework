using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathfinding : MonoBehaviour {

    grid Grid;

    void Awake()
    {
        Grid = GetComponent<grid>();
    }

    void findPath(Vector2 startPosition, Vector2 targetPosition)
    {
        node startNode = Grid.nodeFromWorldPoint(startPosition);
        node targetNode = Grid.nodeFromWorldPoint(targetPosition);

        List<node> openSet = new List<node>();
        HashSet<node> closedSet = new HashSet<node>();
        openSet.Add(startNode);
        while (openSet.Count > 0)
        {
            node currentNode = openSet[0];
            for (int i = 0; i < openSet.Count; i++)
            {
                if (openSet[i].fCost < currentNode.fCost || openSet[i].fCost == currentNode.fCost && openSet[i].hCost < currentNode.hCost)
                {
                    currentNode = openSet[i];
                }

                openSet.Remove(currentNode);
                closedSet.Add(currentNode);

                if (currentNode == targetNode)
                {
                    return;
                }


            }
        }
    }
}
