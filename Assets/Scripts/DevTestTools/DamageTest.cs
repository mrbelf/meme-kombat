using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTest : MonoBehaviour
{
    public void Take10Damage() 
    {
        HPManager.GetInstance().TakeDamage(10);
    }

    public void ResetHP() 
    {
        HPManager.GetInstance().ResetHP();
    }
}
