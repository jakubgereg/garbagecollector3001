using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoardCreator : MonoBehaviour {

    public Sprite boardSprite;
    public int BoardWidht;
    public int boardHeight;

    public List<GameObject> tiles;

    /// <summary>
    /// mozna se to vysere tady
    /// </summary>
    int numberOfBoardUnits
    {
        get { return BoardWidht + boardHeight; }
    }

    float spriteSize;

    Vector2 actualTilePos;
    int actualTileIndex;
	
    void Start () {
        actualTileIndex = 0;
        spriteSize = boardSprite.bounds.size.x;
        createBoard();
    }
	
	void Update () {
		
	}

    public void createBoard()
    {
        tiles.Clear();
        tiles = new List<GameObject>();
        actualTilePos = transform.position;
        for (int y = 0; y < boardHeight; y++)
        {

            for (int x = 0;x < BoardWidht;x++)
            {
                GameObject t = new GameObject();
                t.transform.position = actualTilePos;
                t.name = actualTileIndex.ToString();
                t.AddComponent<SpriteRenderer>().sprite = boardSprite;
                tiles.Add(t);
                actualTilePos = new Vector2(actualTilePos.x + spriteSize, actualTilePos.y);
                actualTileIndex++;
            }
            actualTileIndex++;
            actualTilePos = new Vector2(transform.position.x, actualTilePos.y - spriteSize);
            
        }
    }
}
