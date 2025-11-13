using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            EnemyRigBody enemy =  collision.gameObject.GetComponent<EnemyRigBody>();
            enemy.Health--;
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(this.gameObject);
        }
    }
}
