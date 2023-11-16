using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject arme;
    public bool canShoot = true;
    public Animator animator;
    public bool  isShooting = false;

    // Start is called before the first frame update
    void Start()
    {
        arme.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        
        //s'il a l'arme , onle desactive , s'il ne l'a pas , on l'active
        if (canShoot && Input.GetKeyDown(KeyCode.Space))
        {
            canShoot = false;
            animator.SetTrigger("shoot_trig");
            arme.SetActive(true);
            Invoke(nameof(HideGun), 1f);
            isShooting=true;
     
        }
    }

    public void HideGun() {
        arme.SetActive(false);
        canShoot = true;
        isShooting = false;
    }

}
