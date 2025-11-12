using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            EnemyRigBody enemy =  other.GetComponent<EnemyRigBody>();
            if (enemy == null)
                return;
            enemy.Health--;
        }
        else if (other.gameObject.CompareTag("Ground"))
        {
            Destroy(this.gameObject);
        }
    }
}
