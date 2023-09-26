using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthPresenter : MonoBehaviour
{
    
    [SerializeField] private Image _healthBarFill;
    [SerializeField] private float _minHealth;
    [SerializeField] private float _maxHealth;
    private Health _health;
    
    public Health Health => _health;
    
    
    private void Awake()
    {
        _health = new Health(_minHealth, _maxHealth);
        _health.RestoreHealth();
    }
    
    private void OnEnable()
    {
        if (_health != null)
        {
            _health.onHealthChanged += UpdateHealthBar;
        }
    }
    
    private void OnDisable()
    {
        if (_health != null)
        {
            _health.onHealthChanged -= UpdateHealthBar;
        }
    }

    private void UpdateHealthBar()
    {
        _healthBarFill.fillAmount = _health.CurrentHealth / _health.MaxHealth;
    }
}