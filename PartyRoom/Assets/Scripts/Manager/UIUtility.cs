using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIUtility : MonoBehaviour
{
    // Start is called before the first frame update
    public static void SetTextRectSize(Text textComponent, RectTransform rectTransform)
    {
        /*�ؽ�Ʈ �ֺ� ����*/
        float paddingWidth = 20f;
        float paddingHeight = 10f;
       
        if (textComponent == null || rectTransform == null) return;

        // �ؽ�Ʈ�� ��ȣ �ʺ�� ���� + �е�
        float preferredWidth = textComponent.preferredWidth + paddingWidth;
        float preferredHeight = textComponent.preferredHeight + paddingHeight;

        // RectTransform ũ�� ����
        rectTransform.sizeDelta = new Vector2(preferredWidth, preferredHeight);
    }
}
