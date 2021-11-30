using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LevelScroll : MonoBehaviour,IBeginDragHandler,IEndDragHandler
{
    private ScrollRect scrollRect;
    public float smoothing = 5;
    public Toggle[] toggleArray;
    private float[] pageArray = new float[] {0, 0.4997f, 0.9815f };
    private float targetHorizontalPosition=0;
    private bool isDraging = false;

    // Start is called before the first frame update
    void Start()
    {
        scrollRect = GetComponent<ScrollRect>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDraging == false) { 
            scrollRect.horizontalNormalizedPosition = Mathf.Lerp(scrollRect.horizontalNormalizedPosition, targetHorizontalPosition, Time.deltaTime * smoothing);
        }
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        isDraging = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isDraging = false;
        float posX = scrollRect.horizontalNormalizedPosition; //取得拖曳結尾的座標
        int index = 0;
        float offset = Mathf.Abs(pageArray[index] - posX);
        for(int i=1; i < pageArray.Length; i++)
        {
            float offsetTemp = Mathf.Abs(pageArray[i] - posX);
            if (offsetTemp < offset)
            {
                index = i;
                offset = offsetTemp;
            }
        }
        targetHorizontalPosition = pageArray[index];
        toggleArray[index].isOn = true;
        //scrollRect.horizontalNormalizedPosition = pageArray[index];
    }

    public void TurnToPage1(bool isOn)
    {
        if (isOn)
        {
            targetHorizontalPosition = pageArray[0];
        }
    }
    public void TurnToPage2(bool isOn)
    {
        if (isOn)
        {
            targetHorizontalPosition = pageArray[1];
        }
    }
    public void TurnToPage3(bool isOn)
    {
        if (isOn)
        {
            targetHorizontalPosition = pageArray[2];
        }
    }
}
