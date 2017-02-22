using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDestroyController : MonoBehaviour {

    GameBoardCreator board;
    int actualTileIndex;
    int boardSize;

	void Start () {
        actualTileIndex = 0;
        board = GetComponent<GameBoardCreator>();
        boardSize = board.tiles.Count;
	}
	
	void Update () {

	}

    public void destroyNextTile()
    {
        Destroy(board.tiles[actualTileIndex]);
        actualTileIndex++;
        if(actualTileIndex > board.tiles.Count-1)
        {
            board.createBoard();
            actualTileIndex = 0;
        }
    }


}
