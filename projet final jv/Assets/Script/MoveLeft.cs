using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public GameObject joueur;
    public float speed = 0;
    public PlayerController playerController;

    //cette variable est la position à laquelle l'objet disparait

    // Start is called before the first frame update
    void Start()
    {
        playerController = joueur.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!playerController.isShooting) { 
                 transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
            
    }

}
