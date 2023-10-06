using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]

public class Enemy : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer; 
    [SerializeField] private float _speed;
    private Rigidbody2D _rigidbody;
    private int _direction;
    private Transform _target;
 
    public void SetTarget(Transform target) =>  
             _target = target;
    
    private void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (transform.position.x > _target.position.x)
        {
            _renderer.flipX = true;
            _direction = -1;
        }
        else
        {
            _renderer.flipX= false;
            _direction = 1;
        }

        _rigidbody.velocity = new Vector2(_speed * _direction, _rigidbody.velocity.y); 
    }
}