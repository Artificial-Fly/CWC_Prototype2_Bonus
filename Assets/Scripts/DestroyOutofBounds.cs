using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Globals;
public class DestroyOutofBounds : MonoBehaviour
{
    //global variables
    Globals globals;
    private GameObject globalVars;
    private float boundary = 20.0f;
    private float center = 10.0f; //center of visible part of the scene
    // Start is called before the first frame update
    void Start()
    {
        globalVars = GameObject.FindWithTag("GlobalVariables");
        globals = globalVars.GetComponent<Globals>();
    }

    // Update is called once per frame
    void Update()
    {
        if((transform.position.z>(center+boundary))||(transform.position.z<(center-boundary))||(transform.position.x>(center/2+boundary)*2)||(transform.position.x<(-center/2-boundary)*2)){
            if(transform.position.z<(center-boundary)){
                globals.lives = globals.lives -1;
                Debug.Log("LIVES: "+ globals.lives);
            }//Debug.Log("Game Over!");//send message to console that game is over if animals reached the lower boundary
            Destroy(gameObject);
        }
        
    }
}
