﻿using UnityEngine;
using UnityEngine.EventSystems;

public class MoveToFront : MonoBehaviour, IPointerDownHandler
{
    RectTransform panelRectTransform;

    void Start()
    {
        panelRectTransform = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData data)
    {
        panelRectTransform.SetAsLastSibling();
    }
}