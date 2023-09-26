using System;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] private HealthPresenter _healthPresenter;
    [SerializeField] private float damageAmount;
    
    private void DealDamage(float amount)
    {
        _healthPresenter.Health.DecreaseHealth(amount);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DealDamage(damageAmount);
        }
    }
}