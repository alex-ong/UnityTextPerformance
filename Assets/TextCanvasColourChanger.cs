using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class TextCanvasColourChanger : AbstractColourChanger {
    private Text t;
    protected override Color getColor()
    {
        return t.color;
    }

    protected override void SetColor(Color c)
    {
        t.color = c;
    }
    
    protected void Awake()
    {
        t = this.GetComponent<Text>();
    }
}
