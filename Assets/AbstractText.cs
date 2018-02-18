using UnityEngine;
using System.Collections;

public abstract class AbstractText : MonoBehaviour
{

    public abstract void SetText(string s);
    public abstract void SetColor(Color c);
    protected abstract TransformType transformType { get; }

    public void Setup()
    {
        this.transform.rotation = Quaternion.LookRotation(Vector3.zero);
    }

    public Vector3 GetWorldPosition()
    {
        if (transformType == TransformType.RectTransform)
            return GetPositionRectTransform();
        else
            return GetPositionTransform();
    }

    public Quaternion GetQuaternion()
    {
        if (transformType == TransformType.RectTransform)
            return GetQuaternionRectTransform();
        else
            return GetQuaternionTransform();
    }

    public Vector3 Forward()
    {
        if (transformType == TransformType.RectTransform)
            return GetForwardRectTransform();
        else
            return GetForwardTransform();
    }

    public enum TransformType
    {
        RectTransform,
        Transform
    }

    //used if this component has a rectTransform
    protected Quaternion GetQuaternionRectTransform()
    {
        return this.GetComponent<RectTransform>().rotation;
    }
    protected Vector3 GetPositionRectTransform()
    {
        return this.GetComponent<RectTransform>().position;
    }
    protected Vector3 GetForwardRectTransform()
    {
        return this.GetComponent<RectTransform>().forward;
    }

    //used if this component has a transform.
    protected Quaternion GetQuaternionTransform()
    {
        return this.GetComponent<Transform>().rotation;
    }
    protected Vector3 GetPositionTransform()
    {
        return this.GetComponent<Transform>().position;
    }
    protected Vector3 GetForwardTransform()
    {
        return this.GetComponent<Transform>().forward;
    }

}
