using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthPresenter
{
    private HealthModel _healthModel;
    private HealthView _healthView;


    public HealthPresenter(HealthModel healthModel, HealthView healthView)
    {
        _healthView = healthView;
        _healthModel = healthModel;
        SubscribeToModelEvents();
    }
    
    private void SubscribeToModelEvents()
    {
        _healthModel.OnHealthChanged += HandleHealthChange;
    }

    private void HandleHealthChange(float currentHealth, float maxHealth)
    {
        _healthView.UpdateView(currentHealth, maxHealth);
    }
}