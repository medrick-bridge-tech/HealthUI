using System;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] private HealthPresenter _healthPresenter;
    
    private void DealDamage(float amount)
    {
        _healthPresenter.Health.DecreaseHealth(amount);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DealDamage(2.5f);
        }
    }
}