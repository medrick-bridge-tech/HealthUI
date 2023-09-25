using UnityEngine;

public class Healer : MonoBehaviour
{
    [SerializeField] private HealthPresenter _healthPresenter;
    
    private void Heal(float amount)
    {
        _healthPresenter.Health.IncreaseHealth(amount);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Heal(2.5f);
        }
    }
}