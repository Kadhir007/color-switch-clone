using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playbutton : MonoBehaviour
{
    // changes scence when play is pressed

    public void OnMouseDown()
    {
        SceneManager.LoadScene("playscence");
    }
}
