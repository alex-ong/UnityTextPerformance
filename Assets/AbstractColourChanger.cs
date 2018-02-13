using UnityEngine;
using System.Collections;

public abstract class AbstractColourChanger : MonoBehaviour {
    protected abstract Color getColor();
    protected abstract void SetColor(Color c);

    float timer = 5.0f;
    protected float getPerc()
    {
        timer -= Time.deltaTime;
        timer = Mathf.Clamp01(timer);
        return 1.0f - timer + 0.1f;
    }
	
	// Update is called once per frame
	void Update () {
        Color c = getColor();
        c.a = getPerc();
        SetColor(c);
	}
}
