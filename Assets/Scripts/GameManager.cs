using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player[] players = new Player[4];
    public TileTemplate[] tileCollection = new TileTemplate[2];
    //public Tile[] tileWall = new Tile[144];
    public Stack<Tile> tileWall;
    public Tile tileObjectPrefab;

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

    public Tile CreateTileObject(TileTemplate template)
    {
        var tileObject = Instantiate(tileObjectPrefab, gameObject.transform);
        tileObject.SetValues(template);
        return tileObject;
    }

    public void FillTileWall()
    {
        for (int i = 0; i < tileCollection.Length; i++)
        {
            randomInt = Random.Range(0, tileCollection.Length);
            tileWall.Push(CreateTileObject(tileCollection[randomInt]));
        }
    }

    public void DealTheHands()
    {

    }
}
