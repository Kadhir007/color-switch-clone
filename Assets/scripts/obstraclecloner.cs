using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstraclecloner : MonoBehaviour
{
    public GameObject colorchangerprefab;
    public GameObject colorchangerspawn;


    public GameObject smallcircleprefab;
    public GameObject smallcircleSpawnpoint;


    public GameObject smallrectangleprefab;
    public GameObject smallrectangleSpawnpoint;


    public GameObject pointprefab;
    public GameObject pointspawn;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "spawner")
        {
            int ran = Random.Range(0, 2);
            switch (ran)
            {
                case 0 :
                    
                    
                    Instantiate(colorchangerprefab,colorchangerspawn.transform.position  , colorchangerspawn.transform.rotation);
                    Instantiate(smallcircleprefab, smallcircleSpawnpoint.transform.position, smallcircleSpawnpoint.transform.rotation);
                    Instantiate(pointprefab, pointspawn.transform.position, pointspawn.transform.rotation);


                    break;

                case 1 :
                    Instantiate(colorchangerprefab, colorchangerspawn.transform.position, colorchangerspawn.transform.rotation);
                    Instantiate(smallrectangleprefab, smallrectangleSpawnpoint.transform.position, smallrectangleSpawnpoint.transform.rotation);
                    Instantiate(pointprefab, pointspawn.transform.position, pointspawn.transform.rotation);

                    break;

            }
            
        }
    }
}
