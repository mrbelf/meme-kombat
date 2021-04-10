using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public class HPBar : MonoBehaviour
{
    private Image bar;
    private int maxHP;

    private void Start()
    {
        bar = GetComponent<Image>();
        var hpManager = HPManager.GetInstance();
        maxHP = hpManager.GetMaxtHP();
        hpManager.HpUpdateEvent.AddListener(UpdateHP);
    }

    private void UpdateHP(int currentHP) 
    {
        bar.fillAmount = currentHP / (float)maxHP; 
    }
}
