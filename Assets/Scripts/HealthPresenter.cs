using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthPresenter : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Image _healthBarFill;

    
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