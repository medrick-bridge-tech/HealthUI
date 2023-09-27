using UnityEngine;
using UnityEngine.Serialization;

public class Healer : MonoBehaviour
{
    [FormerlySerializedAs("healthService")] [SerializeField] private HealthService _healthService;
    [FormerlySerializedAs("healCount")] [SerializeField] private float _healAmount;
    
    
    private void Heal(float amount)
    {
        _healthService.HealthModel.ModifyHealth(amount);    
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Heal(_healAmount);
        }
    }
}