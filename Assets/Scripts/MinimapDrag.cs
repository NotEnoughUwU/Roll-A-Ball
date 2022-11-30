using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MinimapDrag : MonoBehaviour, IDragHandler
{
    public RectTransform Rect;
    public PauseMenu pause;

    private void Awake()
    {
        Rect = transform as RectTransform;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!pause.isPaused)
            return;
        if (RectTransformUtility.ScreenPointToWorldPointInRectangle(Rect, eventData.position, eventData.pressEventCamera, out var globalMousePosition))
        {
            Rect.position = globalMousePosition;
        }
    }
}