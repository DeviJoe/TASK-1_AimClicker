using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] 
    private GameObject prefab;
    [SerializeField]
    private float interval;

    [SerializeField]
    private float fromX;
    [SerializeField]
    private float toX;
    [SerializeField]
    private float fromY;
    [SerializeField]
    private float toY;

    [SerializeField] [Tooltip("шанс выпадения 2 шариков вместо 1: значение от 1 до 10")]
    private int randChance;
    
    
    private float _timer;

    private void FixedUpdate()
    {
        _timer -= Time.fixedDeltaTime;

        if (_timer > 0)
            return;

        _timer += interval;
        
        Random random = new Random();
        int chance = Random.Range(1, 11);
        
        var position = new Vector3 {x = Random.Range(fromX, toX), y = Random.Range(fromY, toY), z = -2};
        Instantiate(prefab, position, Quaternion.identity);

        if (chance <= randChance)
        {
            position = new Vector3 {x = Random.Range(fromX, toX), y = Random.Range(fromY, toY), z = -2};
            Instantiate(prefab, position, Quaternion.identity);
        }
        
        
    }
} 
