using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthModel
{
    private float _currentHealth;
    private float _maxHealth;

    public event Action<float, float> OnHealthChanged; 
    
    
    public HealthModel(float maxHealth)
    {
        _maxHealth = maxHealth;
        _currentHealth = maxHealth;
    }

    public void ModifyHealth(float amount)
    {
        _currentHealth = Mathf.Clamp(_currentHealth + amount, 0f, _maxHealth);
        OnHealthChanged?.Invoke(_currentHealth, _maxHealth);
    }
}
