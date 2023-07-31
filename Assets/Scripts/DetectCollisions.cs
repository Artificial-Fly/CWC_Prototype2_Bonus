using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Globals;
public class DetectCollisions : MonoBehaviour
{
    //global variables
    Globals globals;
    private GameObject globalVars;
    public GameObject hungerBar;
    int hunger = 100;
    float scaleHit;
    // Start is called before the first frame update
    void Start()
    {
        globalVars = GameObject.FindWithTag("GlobalVariables");
        globals = globalVars.GetComponent<Globals>();
        scaleHit = hungerBar.transform.localScale.x/10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag!="Player"){
            if(hunger > 0){
                hunger=hunger-10;
                hungerBar.transform.localScale = new Vector3(hungerBar.transform.localScale.x-scaleHit, hungerBar.transform.localScale.y, hungerBar.transform.localScale.z);
            }else{
                Destroy(gameObject);//destroy this game object
                Destroy(other.gameObject);//destroy other game object
                globals.score = globals.score +1;
                Debug.Log("SCORE: "+ globals.score);
            }
        }else{
            globals.lives = globals.lives -1;
            Debug.Log("LIVES: "+ globals.lives);
        }
    }
}
