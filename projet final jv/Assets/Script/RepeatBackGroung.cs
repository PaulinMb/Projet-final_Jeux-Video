using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackGroung : MonoBehaviour
{

    private Vector3 startPos;
    private float repeatWidth;


    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x * transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
