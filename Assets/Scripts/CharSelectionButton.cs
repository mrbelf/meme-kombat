using UnityEngine;
using UnityEngine.UI;

public class CharSelectionButton : MonoBehaviour
{
    public GameObject selected;
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(()=> 
        {
            foreach (CharSelectionButton csb in FindObjectsOfType<CharSelectionButton>()) 
            {
                csb.ResetBtn();
            }
            Select();
        });
    }

    public void ResetBtn()
    {
        selected.SetActive(false);
    }

    public void Select()
    {
        selected.SetActive(true);
    }
}
