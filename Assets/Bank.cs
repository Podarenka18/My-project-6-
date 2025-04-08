using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Bank : MonoBehaviour 
{
    [Header("Bank Info")]
    [SerializeField] private int MaxMoney = 100;
    [SerializeField] private int MinMoney = 50;
    
    [Header("UI References")]
    [SerializeField] private TextMeshProUGUI MoneText;
    
    private void UpdateCashUI()
    {
        if (MoneText != null)
        {
            MoneText.text = $"{MaxMoney} $";
        }
        
    }
    
    public void Mone(int WasteMoney)
    {
        
        if (MinMoney < MaxMoney)
        {
            
            MaxMoney -= WasteMoney;
            if (MinMoney > MaxMoney)
            {
                MinMoney = MaxMoney;
            }
            
            
            Debug.Log($"Healed for {WasteMoney}. Current health: {MinMoney}/{MaxMoney}");
            UpdateCashUI();
        }
        else
        {
            Debug.Log("Already at full Cash!");
        }
    }
    
    private void Start()
    {
        UpdateCashUI();
    }
}