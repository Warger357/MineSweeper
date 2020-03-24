using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grid : MonoBehaviour
{
    public static int w = 11; //width
    public static int h = 14; //height
    public static Element[,] elements = new Element[w, h];

    public static void bumBombaKebaboCiaparito()
    {
        foreach (Element elem in elements)
        {
            if (elem.mine)
                elem.loadTexture(0);
        }
    }
    public static bool mineAt(int x, int y)
    {
        if (x >= 0 && y >= 0 && x < w && y < h)
        {
            return elements[x, y].mine;
        }
        return false;
    }
    public static int minesCount(int x, int y)
    {
        int count = 0;
        if (mineAt(x - 1, y + 1)) count++; //TL
        if (mineAt(x, y + 1)) count++; //T
        if (mineAt(x + 1, y + 1)) count++; //TR

        if (mineAt(x - 1, y)) count++; //L
        if (mineAt(x, y)) count++; //M
        if (mineAt(x + 1, y)) count++; //R


        if (mineAt(x - 1, y - 1)) count++; //BL
        if (mineAt(x, y - 1)) count++; // B
        if (mineAt(x + 1, y - 1)) count++; //BR

        return count;
    }
    public static void showNeighbour(int x, int y, bool[,] visited)
    {
        if (x >= 0 && y >= 0 && x < w && y < h)
        {
            if (visited[x, y])
                return;

            elements[x, y].loadTexture(minesCount(x, y));
            if (minesCount(x, y) > 0)
                return;

            visited[x, y] = true;
            showNeighbour(x - 1, y + 1, visited);
            showNeighbour(x, y + 1, visited);
            showNeighbour(x + 1, y + 1, visited);

            showNeighbour(x - 1, y, visited);
            showNeighbour(x, y, visited);
            showNeighbour(x + 1, y, visited);

            showNeighbour(x - 1, y - 1, visited);
            showNeighbour(x, y - 1, visited);
            showNeighbour(x + 1, y - 1, visited);
        }
    }
    public static bool isFinished()
    {
        foreach(Element elem in elements)
        {
            if(elem.isCovered() && !elem.mine)
            {
                return false;
            }
        }
        return true;
    }
}
