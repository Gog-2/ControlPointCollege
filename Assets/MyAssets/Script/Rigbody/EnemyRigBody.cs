using UnityEngine;

public class EnemyRigBody : MonoBehaviour
{
    public int Health = 1;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (Health > 0)
        {
            PlayerController player = other.gameObject.GetComponent<PlayerController>();
            if (player == null) return;
            player.TakeDamage(1);
        }
    }
}
