using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnersEnemy : MonoBehaviour
{
    [SerializeField] private Transform _enemySpawner;
    [SerializeField] private int _seconsdPerSpawn;

    public GameObject Enemy;

    private Transform[] _spawners;

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
            int tempNum = Mathf.RoundToInt(Random.Range(0, _enemySpawner.childCount));

            Instantiate(Enemy, new Vector3(_spawners[tempNum].position.x, _spawners[tempNum].position.y), Quaternion.identity );

            Debug.Log(tempNum);

            yield return new WaitForSeconds(_seconsdPerSpawn);
        }
    }
}
