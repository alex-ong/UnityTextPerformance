using UnityEngine;
using System.Collections;

public class TextMeshImpl : AbstractText {
    public TextMesh tm;

    public override void SetText(string s)
    {
        tm.text = s;
    }
    public override void SetColor(Color c)
    {
        tm.color = c;
    }
}
