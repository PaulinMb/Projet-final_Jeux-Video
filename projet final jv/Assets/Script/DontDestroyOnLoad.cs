using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{

    // Awake est appellé quand le script est loadé
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }


}
