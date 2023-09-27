using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ServiceManager : MonoBehaviour
{

    [SerializeField] private List<Service> _services;

    public List<Service> Services
    {
        get => _services;
        set => _services = value;
    }


    private void Awake()
    {
        foreach (var service in _services)
        {
            service.Setup();
        }
    }
}