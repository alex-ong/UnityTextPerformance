using UnityEngine;
using System.Text;
using System.Collections;

public class Cloner : MonoBehaviour
{
    private GameObject toClone;
    private GameObject toCloneBackground;

    public GameObject TextMesh; //Unity TextMesh
    public GameObject TextMeshIntegratedQuadBG; //Unity Textmesh with a quad background.
    public GameObject CanvasBackground; //GUI Object with just background
    public GameObject TextCanvas; //GUI Object with just text;
    public GameObject TextCanvasBackground; //GUI object with Text and Background;

    public enum CloneMode {
        TextMeshWithUIBackground, //TextMesh with canvas background
        TextMeshWithQuadBackground, //TextMesh with quad backgrounds
        SingleCanvas, //One canvas with Text and background
        SeparateCanvas, //Two canvas', one text one background        
    }

    public CloneMode cloneMode;

    private StringBuilder m_stringBuilder = new StringBuilder();
    private const string alphabet = "abcdefghijklmnopqrstuvwxyz";
    // Use this for initialization
    void Start()
    {
        switch (cloneMode)
        {
            case CloneMode.SeparateCanvas:
                toClone = TextCanvas;
                toCloneBackground = CanvasBackground;
                break;
            case CloneMode.SingleCanvas:
                toClone = TextCanvasBackground;
                break;
            case CloneMode.TextMeshWithUIBackground:
                toClone = TextMesh;
                toCloneBackground = CanvasBackground;
                break;
            case CloneMode.TextMeshWithQuadBackground:
                toClone = TextMeshIntegratedQuadBG;
                break;
        }
    }

    public int count = 1000;

    protected GameObject createTextClone()
    {
        GameObject go = GameObject.Instantiate(toClone);

        go.SetActive(true);
        go.transform.SetParent(this.transform);
        go.transform.localPosition = new Vector3(Random.value * 20f,
                                                Random.value * 5f,
                                                Random.value * 5f);
        if (go.transform.position != Vector3.zero)
            go.transform.rotation = Quaternion.LookRotation(go.transform.position);

        AbstractText at = go.GetComponent<AbstractText>();
        at.SetText(RandomString());
        at.SetColor(new Color(Random.value,
                                Random.value,
                                Random.value));
        return go;
    }

    protected GameObject CreateBackground(GameObject textClone)
    {
        GameObject go = GameObject.Instantiate(toCloneBackground);
        go.SetActive(true);
        go.transform.SetParent(this.transform);

        AbstractText at = textClone.GetComponent<AbstractText>();
        go.GetComponent<ImageBackground>().Setup(at);        
        return go;
    }

    // Update is called once per frame
    void Update()
    {
        if (count > 0)
        {
            count--;
            GameObject textClone = createTextClone();
            if (toCloneBackground != null)
            {
                CreateBackground(textClone);
            }
        
        }
    }



    public string RandomString()
    {
        m_stringBuilder.Length = 0;
        for (int i = 0; i < 10; i++)
        {
            m_stringBuilder.Append(alphabet[(int)(Random.value * 26)]);
        }
        return m_stringBuilder.ToString();
    }
}
