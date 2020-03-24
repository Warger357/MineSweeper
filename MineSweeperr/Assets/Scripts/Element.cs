using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{
    public bool mine;
    public Sprite[] emptyTextures;
    public Sprite mineTexture;

    void Start()
    {
        mine = Random.value < 0.15;

        int x = (int)transform.position.x;
        int y = (int)transform.position.y;
        grid.elements[x, y] = this;


    }

    public void loadTexture(int adjacentCount)
    {
        if (mine)
        {
            GetComponent<SpriteRenderer>().sprite = mineTexture;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = emptyTextures[adjacentCount];
        }
    }

    public bool isCovered()
    {
        return GetComponent<SpriteRenderer>().sprite.texture.name == "default";
    }

    public void OnMouseUpAsButton()
    {
        if (GetComponent<SpriteRenderer>().sprite != emptyTextures[10])
        {
            if (mine)
            {
                grid.bumBombaKebaboCiaparito();
            }
            else
            {

                int x = (int)transform.position.x;
                int y = (int)transform.position.y;
                grid.showNeighbour(x, y, new bool[grid.w, grid.h]);
                if (grid.isFinished())
                {
                    print("you win!");
                }
            }
        }
    }
    
    public void onMouseUp()
    {
        
    }
    public void Update()
    {
        if (Input.GetMouseButton(1))
        {
            int x = (int)transform.position.x;
            int y = (int)transform.position.y;
            if (GetComponent<SpriteRenderer>().sprite == emptyTextures[10])
            {
                GetComponent<SpriteRenderer>().sprite = emptyTextures[9]; print("zmień się kurwa");
                return;
            }
            if (GetComponent<SpriteRenderer>().sprite == emptyTextures[9])
            {
                GetComponent<SpriteRenderer>().sprite = emptyTextures[10];
                return;
            }

        }
    }
}
