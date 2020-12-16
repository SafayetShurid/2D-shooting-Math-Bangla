using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    public GameObject spawnObject;
    float fix = 3.5f;

    void Start () {
        StartCoroutine(Spawn());
    }
	
	// Update is called once per frame
	void Update () {

      
	}


    IEnumerator Spawn()
    {
        while (true)
        {
           
            yield return new WaitForSeconds(fix);
            Instantiate(spawnObject, new Vector2(Random.Range(-7.5f, 7.5f), 6.37f), Quaternion.identity);
            fix = 1f;
        }
    }
}
