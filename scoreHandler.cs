using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject currentscore;
    

    private TextMesh currentscoretext;
   

   
    void Start()
    {
        //targeting mesh components
        currentscoretext = currentscore.GetComponent<TextMesh>();
      
        //changing current score
        currentscoretext.text = PlayerPrefs.GetString("currentscore");
        //checking for high score
        
        
    } 


    
}
