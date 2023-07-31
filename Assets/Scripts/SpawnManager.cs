using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalsPrefabs;
    //private float spawnPosZ = 20;
    private float spawnOffsetX = 8.5f;
    private float spawnInterval = 3.5f;
    private float startDelay = 2;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Spawn());//starting coroutine to not bother with pressing key
        //or use InvokeRepeating ;>
        InvokeRepeating("SpawnAnimal",startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        //spawn first animal on s key at SpawnManager position
        if(Input.GetKeyDown(KeyCode.Return)){
            Vector3 spawnPos = new Vector3(Random.Range(-spawnOffsetX, spawnOffsetX),0,spawnPosZ);
            int animalIndex=Random.Range(0, animalsPrefabs.Length);
            Instantiate(animalsPrefabs[animalIndex], spawnPos, animalsPrefabs[animalIndex].transform.rotation);
        }*/
        
    }

    /*IEnumerator Spawn(){
        while(true){
            yield return new WaitForSeconds(spawnInterval);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnOffsetX, spawnOffsetX),0,spawnPosZ);
            int animalIndex=Random.Range(0, animalsPrefabs.Length);
            Instantiate(animalsPrefabs[animalIndex], spawnPos, animalsPrefabs[animalIndex].transform.rotation);
        }
        
    }*/
    void SpawnAnimal(){
        int animalIndex=Random.Range(0, animalsPrefabs.Length);
        if(gameObject.name=="SpawnManager"){
            Instantiate(animalsPrefabs[animalIndex], new Vector3(transform.position.x+Random.Range(-spawnOffsetX, spawnOffsetX),transform.position.y,transform.position.z), gameObject.transform.rotation);
        }else{
            Instantiate(animalsPrefabs[animalIndex], new Vector3(transform.position.x,transform.position.y,transform.position.z+Random.Range(-spawnOffsetX, spawnOffsetX)), gameObject.transform.rotation);
        }
    }
}
