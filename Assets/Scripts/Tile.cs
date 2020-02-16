using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public TileTemplate tileTemplate;
    public GameObject tileFace;

    public int suit;
    public int number;
    public int maxCopies; // the number of copies in the collection (there should be four copies of '3 dots', but only one copy of the 'chinese 3 flower'

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetValues(TileTemplate template)
    {
        tileFace.GetComponent<MeshRenderer>().material = tileTemplate.tileSprite;
        template.suit = suit;
        template.number = number;
    }
}
