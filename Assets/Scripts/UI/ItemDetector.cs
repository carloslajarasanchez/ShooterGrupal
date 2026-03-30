using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ItemDetector : MonoBehaviour
{
    [SerializeField] private Sprite _handSprite;

    private Image _icon;
    private RectTransform _rectTransform;
    private Sprite _defaultSprite;

    void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
        _icon = GetComponent<Image>();
        _defaultSprite = _icon.sprite;

        ServiceLocator.Get<CustomEvents>().OnCatchableDetected?.AddListener(DetectedItem);
        ServiceLocator.Get<CustomEvents>().OnCatchableLost?.AddListener(LostItem);
    }

    private void DetectedItem()
    {
        _rectTransform.localScale = Vector3.one * 2.5f;
        _icon.sprite = _handSprite;
    }

    private void LostItem()
    {
        _rectTransform.localScale = Vector3.one;
        _icon.sprite = _defaultSprite;
    }
}
