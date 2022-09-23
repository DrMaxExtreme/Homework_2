using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnersEnemy : MonoBehaviour
{
    [SerializeField] private Transform _enemySpawner;
    [SerializeField] private int _seconsdPerSpawn;
    [SerializeField] private Enemy _enemy;

    private Transform[] _spawners;

    private void Start()
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
        var waitForSeconds = new WaitForSeconds(_seconsdPerSpawn);

        while (true)
        {
            int tempNum = Mathf.RoundToInt(Random.Range(0, _enemySpawner.childCount));

            Instantiate(_enemy, new Vector3(_spawners[tempNum].position.x, _spawners[tempNum].position.y), Quaternion.identity );

            Debug.Log(tempNum);

            yield return waitForSeconds;
        }
    }
}
