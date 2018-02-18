using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CopyRect : MonoBehaviour {
    protected RectTransform m_RectTransform;
    public RectTransform m_Root;

    public float borderWidth = 20f;

    // Use this for initialization
    void Awake()
    {
        m_RectTransform = this.GetComponent<RectTransform>();
    }

    public void Synchronize(RectTransform TextRect)
    {        
        if (TextRect != null)
        {
            StartCoroutine(UpdateRect(TextRect));
        }        
    }

    protected IEnumerator UpdateRect(RectTransform toClone)
    {
        yield return null;
        Rect toCloneRect = toClone.rect;
        Vector2 sizeDelta = m_RectTransform.sizeDelta;
        sizeDelta.x = toCloneRect.width + borderWidth;
        sizeDelta.y = toCloneRect.height + borderWidth;
        m_RectTransform.sizeDelta = sizeDelta;        
    }


}
