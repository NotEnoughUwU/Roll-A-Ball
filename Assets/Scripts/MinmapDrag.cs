using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MinmapDrag : MonoBehaviour, IDragHandler
{
    RectTransform draggingObjectRectTransform;
    public PauseMenu pauseMenu;

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
        if (!pauseMenu.isPaused)
            return;
        if (RectTransformUtility.ScreenPointToWorldPointInRectangle(draggingObjectRectTransform, eventData.position, eventData.pressEventCamera, out var globalMousePosition))
        {
            draggingObjectRectTransform.position = globalMousePosition;
        }
    }

    void Awake()
    {
        draggingObjectRectTransform = transform as RectTransform;
    }
}
