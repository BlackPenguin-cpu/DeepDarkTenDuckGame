using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GoogleSheetImport : MonoBehaviour
{
    string atkURL = "https://docs.google.com/spreadsheets/d/1RvibsVXEDGXlfVKYRA_1oLIjVxekg0dZqQiIvxrXb_c/export?format=tsv&range=A2:G";
    string defURL = "https://docs.google.com/spreadsheets/d/1RvibsVXEDGXlfVKYRA_1oLIjVxekg0dZqQiIvxrXb_c/export?format=tsv&range=A2:G&gid=1885389343";
    [SerializeField] private Items ItemData;
    private IEnumerator Start()
    {
        UnityWebRequest wwwAtk = UnityWebRequest.Get(atkURL);
        UnityWebRequest wwwDef = UnityWebRequest.Get(defURL);
        yield return wwwAtk.SendWebRequest();
        SetItemSO(wwwAtk.downloadHandler.text, true);
        yield return wwwDef.SendWebRequest();
        SetItemSO(wwwDef.downloadHandler.text, false);
        
    }
    void SetItemSO(string tsv , bool _isAtkData)
    {
        string[] row = tsv.Split('\n');
        int rowSize = row.Length;
        int columnSize = row[0].Split('\t').Length;

        for (int i = 0; i < rowSize; i++)
        {
            string[] column = row[i].Split('\t');
            for (int j = 0; j < columnSize; j++)
            {
                if (_isAtkData)
                {
                    SAttackItemDictionary atkItem = ItemData.attackItems[i];
                    atkItem.itemName = column[0];
                    atkItem.shopLevel = int.Parse(column[1]);
                    atkItem.type = (EItemType)(int.Parse(column[2]));
                    atkItem.dmg = float.Parse(column[3]);
                    atkItem.range = int.Parse(column[4]);
                    atkItem.cost = float.Parse(column[5]);
                    atkItem.cleanHitPoint = float.Parse(column[6]);

                }
                else
                {
                    SShilldItemDictionary defItem = ItemData.shilldItems[i];
                    defItem.itemName = column[0];
                    defItem.shopLevel = int.Parse(column[1]);
                    defItem.type = (EItemType)(int.Parse(column[2]));
                    defItem.dmgReduction = float.Parse(column[3]);
                    defItem.defCnt = int.Parse(column[4]);
                    defItem.cost = float.Parse(column[5]);
                    defItem.defSuccess = float.Parse(column[6]);

                }
            }
        }
    }
}
