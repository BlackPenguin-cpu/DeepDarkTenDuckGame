using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GoogleSheetImport : MonoBehaviour
{
    string URL = "https://docs.google.com/spreadsheets/d/1RvibsVXEDGXlfVKYRA_1oLIjVxekg0dZqQiIvxrXb_c/export?format=tsv&range=A2:F";

    [SerializeField] private Items ItemData;
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
                SAttackItemDictionary atkItem = ItemData.attackItems[i];
                atkItem.itemName = column[0];
                atkItem.type = (EItemType)(int.Parse(column[1]));
                atkItem.dmg = float.Parse(column[2]);
                atkItem.range = int.Parse(column[3]);
                atkItem.cost = float.Parse(column[4]);
                atkItem.cleanHitPoint = float.Parse(column[5]);

            }
        }
    }
}
