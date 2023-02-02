using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(StartSpawning());
        Destroy(target);
    }

    IEnumerator StartSpawning()
    {
        Instantiate(target, new Vector3(Random.Range(0, 30), 3, Random.Range(0, 30)), Quaternion.identity);
        yield return new WaitForSeconds(5000);
    }
}
