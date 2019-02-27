using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestroyAudio : MonoBehaviour
{
    void Awake(){

    	DontDestroyOnLoad(transform.gameObject);
    }
}
