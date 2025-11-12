using UnityEngine;

public class EnemyRigBody : MonoBehaviour
{
    public int Health = 1;

    public void OnTriggerEnter(Collider other)
    {
        PlayerController player = other.GetComponent<PlayerController>();
        if (player != null)
            return;
        player.Health--;
    }
}
