using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject item;
    // Start is called before the first frame update
    void Start()
    {
        float randoposy = Random.Range(-4.78f, 4.77f);
        float randoposx = Random.Range(-8f, 8.34f);
        float randoposz = 0;
        Vector3 randompos = new Vector3(randoposx, randoposy, randoposz);
        Instantiate( item , randompos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
