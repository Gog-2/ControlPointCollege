using UnityEngine;
using UnityEngine.UI;

public class AnimationChange : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private bool _swapped = false;
    [SerializeField]private float timer = 2f;
    private float timertrue = 0f;
    void Start()
    {
        
    }
    
    void Update()
    {
        Movment();
    }

    private void Movment()
    {
        timertrue += Time.deltaTime;
        if (timertrue > timer && !_swapped)
        {
            timertrue = 0f;
            _swapped = true;
            _animator.SetBool("swaped", true);
        }
        else if (timertrue > timer && _swapped)
        {
            timertrue = 0f;
            _swapped = false;
            _animator.SetBool("swaped", false);
        }
    }
}
