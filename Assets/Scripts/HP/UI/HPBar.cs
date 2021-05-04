using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public class HPBar : MonoBehaviour
{
    [SerializeField]private Image bar1;
    [SerializeField]private Image bar2;
    private int maxHP;

    private void Start()
    {
        var hpManager = HPManager.Instance;
        maxHP = hpManager.GetMaxtHP();
        hpManager.HpUpdateEvent.AddListener(UpdateHP);
    }

    private void UpdateHP(int hp1,int hp2) 
    {
        bar1.fillAmount = hp1 / (float)maxHP;
        bar2.fillAmount = hp2 / (float)maxHP;
    }
}
