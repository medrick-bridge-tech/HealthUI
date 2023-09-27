using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using DG.Tweening;


public class HealthView : MonoBehaviour
{
    [SerializeField] private Image _fillImage;
    [SerializeField] private Image.FillMethod _fillMethod;
    [SerializeField] private Color _fillColor;
    [SerializeField] private float _fillDuration;
    [SerializeField] private Ease _easeType;
    

    public Image FillImage
    {
        get => _fillImage;
        set => _fillImage = value;
    }

    public void SetupView()
    {
        _fillImage.color = _fillColor;
        _fillImage.fillMethod = _fillMethod;
    }
    
    public void UpdateView(float currentHealth, float maxHealth)
    {
        var damage = (_fillImage.fillAmount * maxHealth) - currentHealth;
        var duration = damage * _fillDuration / maxHealth;
        
        _fillImage.DOFillAmount(currentHealth / maxHealth, duration).SetEase(_easeType);
        // DOVirtual.Float(_fillImage.fillAmount, currentHealth / maxHealth, .1f, value =>
        // {
        //     _fillImage.fillAmount = value;
        // });
    }
}