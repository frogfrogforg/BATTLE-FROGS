using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogSpawn : MonoBehaviour
{
    public GameObject frog;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(frog, transform.position, transform.rotation);
        }
    }
}
