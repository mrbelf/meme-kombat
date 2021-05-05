using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.Utility.SingletonPattern;

public class CharSelector : Singleton<CharSelector>
{
    public RuntimeAnimatorController [] chars;
    public int selected;

    public void Select(int i)
    {
        selected = i;
    }
}


