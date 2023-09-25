using UnityEngine;

public class Healer : MonoBehaviour
{
    [SerializeField] private Health _health;

    
    private void Heal(float amount)
    {
        _health.IncreaseHealth(amount);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Heal(2.5f);
        }
    }
}