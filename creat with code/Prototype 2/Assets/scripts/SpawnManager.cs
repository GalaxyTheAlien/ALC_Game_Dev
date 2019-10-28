using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
<<<<<<< Updated upstream
    public int animalIndex;
=======

>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
<<<<<<< Updated upstream
    void Update(){
        if (Input.GetKeyDown(KeyCode.S)) { 
         Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 20),
         animalPrefabs[animalIndex].transform.rotation);
=======
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int animalindex = Random.Range(0, 3);

            Instantiate(animalPrefabs[animalindex], new Vector3(0, 0, 20), animalPrefabs[animalindex].transform.rotation);
>>>>>>> Stashed changes
        }
    }
}
