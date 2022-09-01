using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GoogleSheetImport : MonoBehaviour
{
    string URL = "https://docs.google.com/spreadsheets/d/1RvibsVXEDGXlfVKYRA_1oLIjVxekg0dZqQiIvxrXb_c/export?format=csv&range=A2:G";

    private IEnumerator Start()
    {
        UnityWebRequest www = UnityWebRequest.Get(URL);
        yield return www.SendWebRequest();

        string data = www.downloadHandler.text;
        data.TrimEnd();
        print(data);
        char[] delimiterChars = { ',' };
        string[] Txts = data.Split(delimiterChars);
        for (int i = 0; i < Txts.Length; i++)
        {
            print(Txts[i]);
        }
    }
}
