using UnityEngine;
using System.Collections;

public class ImageBackground : MonoBehaviour {
    public CopyRect cr;

    public void Setup(AbstractText text)
    {
        //place this behind the text by 1cm.
        this.GetComponent<RectTransform>().position = text.GetWorldPosition() + text.Forward() * 0.001f;
        this.GetComponent<RectTransform>().rotation = text.GetQuaternion();
        //synchronize text boxes...
        //cr.Synchronize(text);
    }
}
