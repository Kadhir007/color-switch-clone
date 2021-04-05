using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercolor : MonoBehaviour
{
    public SpriteRenderer playersprite;
    public Color colorCyan;
    public Color colorYellow;
    public Color colorMagenta;
    public Color colorRed;

    public void ColorChange()
    {
        int ran = Random.Range(0, 4);
        playersprite = GetComponent<SpriteRenderer>();

        switch (ran)
        {
            case 0:
                //red 
                playersprite.color = colorRed;
                name = "Red";
                break;
            case 1:
                //yellow 
                playersprite.color = colorYellow;

                name = "Yellow";
                break;
            case 2:
                //magenta
               
                playersprite.color =  colorMagenta;
                name = "Magenta";
                break;
            case 3:
                //cyan
                playersprite.color = colorCyan;
                name = "Cyan";
                break;
        }
    }

    void Start ()
    {
    ColorChange();

    }
}


