using System;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] private Health _health;

    
    private void DealDamage(float amount)
    {
        _health.DecreaseHealth(amount);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DealDamage(2.5f);
            Debug.Log(_health.CurrentHealth);
        }
    }
}