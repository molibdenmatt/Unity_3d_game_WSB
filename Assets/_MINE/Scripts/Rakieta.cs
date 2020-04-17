using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rakieta : MonoBehaviour
{

    private Animator AtomRocket;
    private bool isAnimating = false;

    // Start is called before the first frame update
    public void ReactToHit()
    {
        if (isAnimating == false)
        {
            Debug.Log("ROCKET START!");
            Debug.Log("SHOOT THE ROCKET!");
            AtomRocket.SetBool("startowac", true);
            isAnimating = true;
        }

        else if(isAnimating == true)
        {
            Debug.Log("ROCKET DOWN!");
            AtomRocket.SetBool("startowac", false);
            isAnimating = false;
        }
    }


    void Start()
    {
        AtomRocket = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
