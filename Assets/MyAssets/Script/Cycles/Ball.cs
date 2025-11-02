using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private GameObject _ball;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Transform _lowPosition;
    [SerializeField]private Rigidbody2D _rb;
    [SerializeField]private float _threshold = 13;
    [SerializeField] private float _force = 3;
    private static  float _timeBelowThreshold = 0f;
    private static  bool _haveSpeed = true;
    
    void Start()
    {
    }

    private void BallStatus(float threshold,Rigidbody2D rb)
    {
        float speed = rb.linearVelocity.magnitude;
        if (speed < threshold)
        {
            _spriteRenderer.color = Color.red;
        }
        else
        {
            _spriteRenderer.color = Color.white;
        }
        Debug.Log($"Время ниже порога: {_timeBelowThreshold} секунд");
    }

    private void Force()
    {
        _rb.AddForce(_lowPosition.up * _force);
    }
    void Update()
    {
        if (_ball.transform.position.y <= _lowPosition.position.y)
        {
            Force();
        }

        if (_haveSpeed)
        {
            BallStatus(_threshold, _rb);
        }
    }
}
