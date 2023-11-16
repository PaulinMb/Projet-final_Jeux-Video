using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 0;

    //cette variable est la position à laquelle l'objet disparait

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
        {
            if (!PlayerController.isShooting) { 
                     transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
        }

}
