using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public TileTemplate tileClass;
    public GameObject tileFace;

    public int suit;
    public int number;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetValues(int suit, int number)
    {
        tileFace.GetComponent<MeshRenderer>().material = tileClass.tileSprite;
        this.suit = suit;
        this.number = number;
    }
}
