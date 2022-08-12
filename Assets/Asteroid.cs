using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Asteroid : MonoBehaviour
{
    
 
    public GameObject player;
    Player ps;
    int numberOfAsteriod;
    [SerializeField]
    float tumble;

    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
        player = GameObject.Find("Player");
        ps = player.GetComponent<Player>();
    }

    void Update()
    {
        var user = GameObject.FindGameObjectsWithTag("player");
        Vector3 userPosition = player.transform.position;
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, userPosition, 3 * Time.deltaTime);
    }


    public void asteroidDestroy()
    {
     
        GetComponent<AudioSource>().Play();
        numberOfAsteriod = GameObject.FindGameObjectsWithTag("asteroid").Length;
        if(numberOfAsteriod<=10)
        {
            GameObject asteroid = Instantiate(Resources.Load("Asteroid1")) as GameObject;
            float x = Random.Range(-35f, 35f);
            float z = Random.Range(45f, 100f);
            float y = Random.Range(10f, 20f);
            asteroid.transform.position = new Vector3(x, y, z);
        }
        
        ps.shoot();
        Destroy(gameObject, .5f);

    }
}
