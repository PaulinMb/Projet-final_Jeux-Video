using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{

    // Awake est appell� quand le script est load�
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }


}
