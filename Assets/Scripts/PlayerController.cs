using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //global variables
    Globals globals;
    private GameObject globalVars;
    //else
    public GameObject projectilePrefab;
    private float horizontalInput;
    private float verticalInput;
    private float speed = 13.5f;
    private float horizontalBoundary = 10.5f;
    private float verticalBoundary = 12.5f;
    // Start is called before the first frame update
    void Start()
    {
        globalVars = GameObject.FindWithTag("GlobalVariables");
        globals = globalVars.GetComponent<Globals>();
    }

    // Update is called once per frame
    void Update()
    {
        //get input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //moving player left/right
        if((transform.position.x < horizontalBoundary && transform.position.x > -horizontalBoundary)){//move if player is with boundaries
            transform.Translate(Vector3.right*horizontalInput*Time.deltaTime*speed);
        }else if((!(transform.position.x < horizontalBoundary)&&(horizontalInput<0))||(!(transform.position.x > -horizontalBoundary)&&(horizontalInput>0))){//move if player is returning within boundaries
            transform.Translate(Vector3.right*horizontalInput*Time.deltaTime*speed);
        }
        //moving player forward/backwards
        if((transform.position.z < verticalBoundary && transform.position.z > (verticalBoundary-12))){//move if player is with boundaries
            transform.Translate(Vector3.forward*verticalInput*Time.deltaTime*speed);
        }else if((!(transform.position.z < verticalBoundary)&&(verticalInput<0))||(!(transform.position.z > (verticalBoundary-12))&&(verticalInput>0))){//move if player is returning within boundaries
            transform.Translate(Vector3.forward*verticalInput*Time.deltaTime*speed);
        }
        //shoting projectile on space-bar key
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);//spawning projectile
        }
        
    }
}