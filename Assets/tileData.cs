using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileData : MonoBehaviour
{
    public int id;
    public GameObject dummy;
    public Vector2 coords;
    public int type;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void reload()
    {
        changeType(0);
        dummy = null;
    }
    public void setTile(int l_id,Vector2 cds)
    {
        id = l_id;
        coords = cds;
        

    }
    public void highlight(bool state)
    {
        if (state)
        {
            GetComponent<SpriteRenderer>().color = Color.grey;
            return;
        }

        changeType(type);
    }
    public void changeType(int l_type)
    {
        type = l_type;
        Color clr=Color.white;
        switch (l_type)
        { 
            case 0:
                clr = Color.white;
                break;
            case 1:
                clr = Color.red;
                break;
            case 2:
                clr = Color.yellow;
                break;
            case 3:
                clr = Color.green;
                break;
            case 4:
                clr = Color.grey;
                break;
        }
        GetComponent<SpriteRenderer>().color = clr;
    }
    public void addDummy(GameObject dumdum)
    {
        dummy = dumdum;
       // GetComponent<SpriteRenderer>().color = Color.cyan;
    } 
    // Update is called once per frame
    void Update()
    {
        
    }
}
