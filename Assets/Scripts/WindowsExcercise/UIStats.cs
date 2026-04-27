using TMPro;
using UnityEngine;

public class UIStats : MonoBehaviour
{
    public StatsData statsData;
    public TextMeshProUGUI txtLevel;

    void Start() => UpdateUI();

    public void UpdateUI()
    {
        if (statsData != null)
            txtLevel.text = "Nivel: " + statsData.level;
    }
    public void LevelUp()
    {
        statsData.level++;
        UpdateUI();
    }
}
