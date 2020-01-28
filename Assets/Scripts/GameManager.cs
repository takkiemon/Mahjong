using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player[] players = new Player[4];
    public TileTemplate[] tileCollection = new TileTemplate[2];
    //public Tile[] tileWall = new Tile[144];
    public Stack<Tile> tileWall;

    //private int handSize;
    //private int maxCopies; // this will be 4 (the number of copies allowed of most tiles)

    private int totalCollection;
    private int randomInt;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FillTileWall()
    {
        /*
        foreach (Tile currentTile in tileWall)
        {
            randomInt = Random.Range(0, 2);
            currentTile.tileTemplate = tileCollection[randomInt];
        }
        */
    }

    public void DealTheHands()
    {

    }
}
