using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthService : Service
{
    [SerializeField] private HealthView _healthView;

    public HealthView HealthView
    {
        get => _healthView;
        set => _healthView = value;
    }

    [SerializeField] private float _maxHealth;

    private HealthModel _healthModel;
    private HealthPresenter _healthPresenter;

    public HealthModel HealthModel => _healthModel;
    
    
    public override void Setup()
    {
        _healthView.SetupView();
        _healthModel = new HealthModel(_maxHealth);
        _healthPresenter = new HealthPresenter(_healthModel, _healthView);
    }
}