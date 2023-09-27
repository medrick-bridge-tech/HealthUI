using System;
using UnityEngine;
using UnityEngine.Serialization;

public class DamageDealer : MonoBehaviour
{
    [FormerlySerializedAs("healthService")] [SerializeField] private HealthService _healthService;
    [FormerlySerializedAs("damageCount")] [SerializeField] private float _damageAmount;
    
    
    private void DealDamage(float amount)
    {
        _healthService.HealthModel.ModifyHealth(-amount);    
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            DealDamage(_damageAmount);
        }
    }
}