using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class CanvasTextImpl : AbstractText
{
    public Text m_textUI;

    public override void SetText(string s)
    {
        m_textUI.text = s;
    }
    public override void SetColor(Color c)
    {
        m_textUI.color = c;
    }
}
