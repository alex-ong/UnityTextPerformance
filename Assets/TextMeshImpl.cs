using UnityEngine;
using System.Collections;

public class TextMeshImpl : AbstractText {
    public TextMesh tm;

    protected override TransformType transformType { get { return TransformType.Transform; } }

    public override void SetText(string s)
    {
        tm.text = s;
    }
    public override void SetColor(Color c)
    {
        tm.color = c;
    }
}
