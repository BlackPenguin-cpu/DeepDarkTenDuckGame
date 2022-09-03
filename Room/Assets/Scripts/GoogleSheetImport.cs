using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GoogleSheetImport : MonoBehaviour
{
    string URL = "https://docs.google.com/spreadsheets/d/1RvibsVXEDGXlfVKYRA_1oLIjVxekg0dZqQiIvxrXb_c/export?format=tsv&range=A2:G";

    private IEnumerator Start()
    {
        UnityWebRequest www = UnityWebRequest.Get(URL);
        yield return www.SendWebRequest();
        SetItemSO(www.downloadHandler.text);
        
    }
    void SetItemSO(string tsv)
    {
        string[] row = tsv.Split('\n');
        int rowSize = row.Length;
        int columnSize = row[0].Split('\t').Length;

        for (int i = 0; i < rowSize; i++)
        {
            string[] column = row[i].Split('\t');
            for (int j = 0; j < columnSize; j++)
            {
                print(column[j]);
            }
        }
    }
}
