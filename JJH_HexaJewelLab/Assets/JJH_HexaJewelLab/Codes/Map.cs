using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public float Raidus = 1f;

    public float blockw = 0f;
    public float blockh = 0f;

    // Start is called before the first frame update
    void Start()
    {
        blockw = Raidus * 0.5f * Mathf.Sqrt(3);
        blockh = Raidus;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
