using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ABOUT RUNNING JS FUNCS
// https://docs.unity3d.com/Manual/webgl-interactingwithbrowserscripting.html

// nethereum
// https://medium.com/@juanfranblanco/nethereum-2-0-0-rc5-unity3d-integration-eb7664664813

public class GetEth : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern string SendTransaction(string to, string data);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I'm attached to " + gameObject.name);
        gameObject.GetComponent<TextMesh>().text = "PWND";

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetText(string arg)
    {
        gameObject.GetComponent<TextMesh>().text = arg;

    }
}
