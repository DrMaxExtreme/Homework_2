using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnersEnemy : MonoBehaviour
{
    [SerializeField] private Transform _enemySpawner;
    [SerializeField] private int _seconsdPerSpawn;

    public GameObject Enemy;

    private Transform[] _spawners;
    private int _currentSpawner;

    void Start()
    {
        _spawners = new Transform[_enemySpawner.childCount];

        for(int i = 0; i < _enemySpawner.childCount; i++)
        {
            _spawners[i] = _enemySpawner.GetChild(i);
        }

        StartCoroutine(Spawning());
    }

    private IEnumerator Spawning()
    {
        while (true)
        {
            Instantiate(Enemy, _spawners[Random.Range(Math.Round(_enemySpawner.childCount))]);//?

            yield return new WaitForSeconds(_seconsdPerSpawn);
        }
    }
}
