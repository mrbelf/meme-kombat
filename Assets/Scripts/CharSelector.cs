using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.Utility.SingletonPattern;

public class CharSelector : Singleton<CharSelector>
{
    public GameObject [] chars;
    public GameObject selected;

    public void Select(int i)
    {
        selected = chars[i];
    }
}


