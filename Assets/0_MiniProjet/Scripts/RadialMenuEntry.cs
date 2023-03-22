using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.UIElements;

public class RadialMenuEntry : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] TextMeshProUGUI Label;

    [SerializeField] RawImage Icon;

    RectTransform rect;

    Item _linckedItem;
    public Item LinckedItem
    {
        get { return _linckedItem; }
        set
        {
            SetLabel(value.GetName);
            SetIcon(value.GetTexture);
            _linckedItem = value;
        }
    }

    private void Awake()
    {
        Label.enabled = false;
        Icon.enabled = false;
        rect = GetComponent<RectTransform>();
    }

    public void SetLabel(string pText)
    {
        Label.enabled = true;
        Label.text = pText;
    }

    // THEO C : meme fonctionnement que pour les scriptableObjs
    public void SetIcon(Texture pIcon)
    {
        Icon.enabled = true;
        Icon.texture = pIcon;
    }

    public Texture GetIcon()
    {
        return (Icon.texture);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (LinckedItem != null)
        {

        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(LinckedItem != null)
        {
            rect.DOComplete();
            rect.DOScale(Vector3.one * 1.5f, .3f).SetEase(Ease.OutQuad);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (LinckedItem != null)
        {
            rect.DOComplete();
            rect.DOScale(Vector3.one, .3f).SetEase(Ease.OutQuad);
        }
    }
}
