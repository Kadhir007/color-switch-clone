using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class playercollision : MonoBehaviour 
 
{
    private SpriteRenderer playersprite;
    public Color colorRed;
    public Color colorYellow;
    public Color colorCyan;
    public Color colorMagenta;
    public GameObject score;
    private TextMesh scoretext;

    public void Start()
    {
        scoretext = score.GetComponent<TextMesh>();
        PlayerPrefs.SetString("currentscore", "0");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "obstracles")
        {
            if (collision.name != name )
            {

                SceneManager.LoadScene("gameover");
                PlayerPrefs.SetString("currentscore", scoretext.text);
         
            }
           

        }
        if (collision.tag== "destroyer")
        {
            SceneManager.LoadScene("gameover");

        }
        else if(collision.tag == "ColorChanger")
        {
            Destroy(collision.gameObject);
            
            playersprite = GetComponent<SpriteRenderer>();

            //if yellow
            if (name== "Yellow")
            {

                int ran = Random.Range(0, 3);
                switch (ran)
                {
                    case 0:
                        //red 
                        playersprite.color = colorRed;
                        name = "Red";
                        break;
                 
                    case 1:
                        //magenta

                        playersprite.color = colorMagenta;
                        name = "Magenta";
                        break;
                    case 2:
                        //cyan
                        playersprite.color = colorCyan;
                        name = "Cyan";
                        break;
                }


            }

            //if red 
            if (name == "Red")
            {
                int ran = Random.Range(0, 3);
                switch (ran)
                {
                    
                    case 1:
                        //yellow 
                        playersprite.color = colorYellow;

                        name = "Yellow";
                        break;
                    case 2:
                        //magenta

                        playersprite.color = colorMagenta;
                        name = "Magenta";
                        break;
                    case 0:
                        //cyan
                        playersprite.color = colorCyan;
                        name = "Cyan";
                        break;
                }
             }

            


            //if Cyan
            if (name == "Cyan")
            {
                int ran = Random.Range(0, 3);
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

                        playersprite.color = colorMagenta;
                        name = "Magenta";
                        break;
                   
                }

            }

            //if Magenta
            if (name == "Magenta")
            {
                int ran = Random.Range(0, 3);
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
                        //cyan
                        playersprite.color = colorCyan;
                        name = "Cyan";
                        break;
                }
                 
            }




        }
        else if (collision.tag == "Point")
        {
            Destroy(collision.gameObject);
            scoretext.text = System.Convert.ToString(System.Convert.ToInt32(scoretext.text) + 1);

        }
    }
}
