using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    CharacterController characterController;
    public Transform cameraTransform;
    GameObject gun;
    public TextMeshProUGUI textMeshProUGUI;
    public TextMeshProUGUI textMeshProUGUI2;
    int finalScore;
    bool gameOver = false;
    public int score = 0;
    public int life;
    
    // Start is called before the first frame update
    void Start()
    {

        characterController = gameObject.GetComponent<CharacterController>();
        gun = gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject;
        score = 0;
        life = 3;
        textMeshProUGUI.text = "Score: " + score;
        finalScore = score;
    }

    public void shoot()
    {
        StartCoroutine("Shoot");
    }
    IEnumerator Shoot()
    {
       // gun.GetComponent<Animation>().Play();
        yield return new WaitForSeconds(1f);
        score += 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        textMeshProUGUI.text = "Score: " + score;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collide");

    }
}
