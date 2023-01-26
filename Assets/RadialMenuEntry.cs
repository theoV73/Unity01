using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;
using UnityEngine.UIElements;

public class RadialMenuEntry : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] TextMeshProUGUI Label;

    [SerializeField] RawImage Icon;

    RectTransform rect;

    private void Start()
    {
        rect = GetComponent<RectTransform>();
    }

    public void SetLabel(string pText)
    {
        Label.text = pText;
    }

    // THEO C : meme fonctionnement que pour les scriptableObjs
    public void SetIcon(Texture pIcon)
    {
        Icon.texture = pIcon;
    }

    public Texture GetIcon()
    {
        return (Icon.texture);
    }
    public void OnPointerClick(PointerEventData eventData)
    {

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        rect.DOComplete();
        rect.DOScale(Vector3.one * 1.5f, .3f).SetEase(Ease.OutQuad);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        rect.DOComplete();
        rect.DOScale(Vector3.one, .3f).SetEase(Ease.OutQuad);
    }
}
