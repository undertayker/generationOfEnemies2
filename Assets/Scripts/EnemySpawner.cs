using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Transform _spawnPoints;
    [SerializeField] private Transform _target;

    private void Start()
    {
        Enemy enemy = Instantiate(_enemyPrefab,
                _spawnPoints.transform.position,
                Quaternion.identity);

        enemy.SetTarget(_target);
    }
}