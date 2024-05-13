using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIUtility : MonoBehaviour
{
    // Start is called before the first frame update
    public static void SetTextRectSize(Text textComponent, RectTransform rectTransform)
    {
        /*텍스트 주변 여백*/
        float paddingWidth = 20f;
        float paddingHeight = 10f;
       
        if (textComponent == null || rectTransform == null) return;

        // 텍스트의 선호 너비와 높이 + 패딩
        float preferredWidth = textComponent.preferredWidth + paddingWidth;
        float preferredHeight = textComponent.preferredHeight + paddingHeight;

        // RectTransform 크기 조정
        rectTransform.sizeDelta = new Vector2(preferredWidth, preferredHeight);
    }
}
