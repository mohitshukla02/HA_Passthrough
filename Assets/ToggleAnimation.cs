using UnityEngine;
using UnityEngine.UI;

public class ToggleAnimation : MonoBehaviour
{
    [SerializeField] RectTransform uiHandleRectTransform;
    [SerializeField] Color backgroundActiveColor;
    [SerializeField] Color handleActiveColor;

    Image backgroundImage, handleImage;

    Color backgroundDefaultColor, handleDefaultColor;

    Toggle toggle;

    Vector2 handlePosition;

    private bool isOn = false;

    void Awake()
    {
        toggle = GetComponent<Toggle>();

        handlePosition = uiHandleRectTransform.anchoredPosition;

        backgroundImage = uiHandleRectTransform.parent.GetComponent<Image>();
        handleImage = uiHandleRectTransform.GetComponent<Image>();

        backgroundDefaultColor = backgroundImage.color;
        handleDefaultColor = handleImage.color;

        toggle.onValueChanged.AddListener(OnSwitch);

        if (toggle.isOn)
            OnSwitch(true);
    }

    public void OnSwitch(bool on)
    {
        isOn = !isOn;

            uiHandleRectTransform.anchoredPosition = on ? handlePosition * -1 : handlePosition;

            backgroundImage.color = on ? backgroundActiveColor : backgroundDefaultColor;
            handleImage.color = on ? handleActiveColor : handleDefaultColor;

    }

    void OnDestroy()
    {
        toggle.onValueChanged.RemoveListener(OnSwitch);
    }
}