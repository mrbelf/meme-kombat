using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelectorManager : MonoBehaviour
{
    public void SelectChar(int i) 
    {
        CharSelector.GetInstance().Select(i);
        this.gameObject.SetActive(false);
    }
}
