using TMPro;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    public InvetoryData data;

    public TextMeshProUGUI txtHP;
    public TextMeshProUGUI txtStr;
    public TextMeshProUGUI txtLife;

    void Start()
    {
        UpdateUI();
    }
    public void UpdateUI()
    {
        if (data == null) return;

        txtHP.text = "HP: " + data.hp;
        txtStr.text = "STR: " + data.str;
        txtLife.text = "Life: " + data.life;
    }
    public void AddHP(int amount)
    {
        if (data == null) return;
        data.hp += amount;
        UpdateUI(); 
    }

    public void AddStr(int amount)
    {
        if (data == null) return;
        data.str += amount;
        UpdateUI(); 
    }
}
