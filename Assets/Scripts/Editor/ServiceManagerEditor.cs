using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Editor
{
    public class ServiceManagerEditor : UnityEditor.Editor
    {
        [MenuItem("Services/Health Service")]
        public static void CreateHealthService()
        {
            GameObject UI = new GameObject();
            UI.name = "HealthUI";
            Canvas canvas = UI.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            CanvasScaler canvasScaler = UI.AddComponent<CanvasScaler>();
            canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            UI.AddComponent<GraphicRaycaster>();
            HealthView healthView = UI.AddComponent<HealthView>();

            GameObject eventSystem = new GameObject();
            eventSystem.name = "EventSystem";
            eventSystem.AddComponent<EventSystem>();
            eventSystem.AddComponent<StandaloneInputModule>();
            eventSystem.transform.SetParent(UI.transform);

            GameObject border = new GameObject();
            border.name = "Border";
            Image borderImage = border.AddComponent<Image>();
            border.AddComponent<CanvasRenderer>();
            border.transform.SetParent(UI.transform);

            GameObject background = new GameObject();
            background.name = "Background";
            background.AddComponent<Image>();
            background.AddComponent<CanvasRenderer>();
            background.transform.SetParent(border.transform);

            GameObject fill = new GameObject();
            fill.name = "Fill";
            Image fillImage = fill.AddComponent<Image>();
            fillImage.sprite = UnityEditor.AssetDatabase.GetBuiltinExtraResource<Sprite>("UI/Skin/UISprite.psd");
            fill.AddComponent<CanvasRenderer>();
            fill.transform.SetParent(border.transform);

            GameObject icon = new GameObject();
            icon.name = "Icon";
            icon.AddComponent<Image>();
            icon.AddComponent<CanvasRenderer>();
            icon.transform.SetParent(border.transform);

            healthView.FillImage = fillImage;

            GameObject healthService = new GameObject();
            healthService.name = "HealthService";
            HealthService healthServiceScript = healthService.AddComponent<HealthService>();
            healthServiceScript.HealthView = healthView;
            healthService.transform.SetParent(UI.transform);
            
            
            GameObject serviceManager = new GameObject();
            serviceManager.name = "ServiceManager";
            ServiceManager serviceManagerScript = serviceManager.AddComponent<ServiceManager>();

            serviceManagerScript.Services = new List<Service>();
            serviceManagerScript.Services.Add(healthServiceScript);
            
            Debug.Log("Health Service Created!");
        }
    }
}