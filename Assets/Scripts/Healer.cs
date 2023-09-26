using UnityEngine;

public class Healer : MonoBehaviour
{
    [SerializeField] private HealthPresenter _healthPresenter;
    [SerializeField] private float healAmount;
    
    private void Heal(float amount)
    {
        _healthPresenter.Health.IncreaseHealth(amount);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Heal(healAmount);
        }
    }
}