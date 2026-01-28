using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject PipePrefab;
    [SerializeField] private Transform Spawner;
    private int RandomY;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipe", 1.0f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPipe()
    {
        RandomY = Random.Range(1,4);
        Vector2 SpawnLocation = new Vector2(Spawner.position.x, RandomY);
        GameObject NewPipe = Instantiate(PipePrefab, SpawnLocation, Spawner.rotation);
        Destroy(NewPipe, 7f); 
    }

    
}
