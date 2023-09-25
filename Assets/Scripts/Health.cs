using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health
{
    private float _minHealth;
    private float _maxHealth;

    private float _currentHealth;
    
    public Action onHealthChanged;

    public float MinHealth => _minHealth;

    public float MaxHealth => _maxHealth;

    public float CurrentHealth => _currentHealth;


    public Health(float minHealth, float maxHealth)
    {
        _minHealth = minHealth;
        _maxHealth = maxHealth;
    }

    public void IncreaseHealth(float amount)
    {
        if (_currentHealth + amount <= _maxHealth)
        {
            _currentHealth += amount;
        }
        else
        {
            RestoreHealth();
        }

        UpdateHealth();
    }
    
    public void DecreaseHealth(float amount)
    {
        if (_currentHealth - amount >= _minHealth)
        {
            _currentHealth -= amount;
        }
        else
        {
            _currentHealth = _minHealth;
        }

        UpdateHealth();
    }

    public void RestoreHealth()
    {
        _currentHealth = _maxHealth;
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        onHealthChanged?.Invoke();
    }
}
