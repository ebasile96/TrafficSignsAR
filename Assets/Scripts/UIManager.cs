using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button Desc, View;
    public GameObject DescObj, ViewObj;

    private void Start()
    {
        Desc.interactable = false;
        DescObj.SetActive(true);
    }
    public void ToggleToView()
    {
        Desc.interactable = true;
        View.interactable = false;
        DescObj.SetActive(false);
        ViewObj.SetActive(true);
    }

    public void ToggleToDesc()
    {
        View.interactable = true;
        Desc.interactable = false;
        ViewObj.SetActive(false);
        DescObj.SetActive(true);

    }
}
