using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleTileMap : MonoBehaviour
{
    public GameObject glass_Tile;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                GameObject temp = (GameObject)Instantiate(glass_Tile);
                temp.transform.position = new Vector3(i, 0, j);
            }

    
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
