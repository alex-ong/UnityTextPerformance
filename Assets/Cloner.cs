using UnityEngine;
using System.Text;
using System.Collections;

public class Cloner : MonoBehaviour
{
    public GameObject toClone;
    private StringBuilder m_stringBuilder = new StringBuilder();
    private const string alphabet = "abcdefghijklmnopqrstuvwxyz";
    // Use this for initialization
    void Start()
    {

    }
    public int count = 1000;

    // Update is called once per frame
    void Update()
    {
        if (count > 0)
        {
            count--;
            GameObject go = GameObject.Instantiate(toClone);

            go.SetActive(true);
            go.transform.SetParent(this.transform);
            go.transform.localPosition = new Vector3(Random.value * 20f,
                                                    Random.value * 5f,
                                                    Random.value * 5f);
            AbstractText at = go.GetComponent<AbstractText>();
            at.SetText(RandomString());
            at.SetColor(new Color(Random.value,
                                    Random.value,
                                    Random.value));
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
