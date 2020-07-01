using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public List<GameObject> descriptions = new List<GameObject>();
    public List<GameObject> views = new List<GameObject>();
    public Button Desc, View;

    private void Start()
    {
        Desc.interactable = false;
        Setup();
        SetDescOn();
    }
    public void ToggleToView()
    {
        Desc.interactable = true;
        View.interactable = false;
        SetViewsOn();
    }

    public void ToggleToDesc()
    {
        View.interactable = true;
        Desc.interactable = false;
        SetDescOn();
    }

    public void Setup()
    {
        //findDescs();
        //findViews();
        Desc.interactable = false;
    }

    public void findDescs()
    {
        foreach (GameObject _desc in GameObject.FindGameObjectsWithTag("Description"))
        {
            descriptions.Add(_desc);
        }
    }

    public void findViews()
    {
        foreach (GameObject _views in GameObject.FindGameObjectsWithTag("3DView"))
        {
            descriptions.Add(_views);
        }
    }

    public void SetDescOn()
    {
        foreach (GameObject view in views)
        {
            view.SetActive(false);
        }

        foreach (GameObject desc in descriptions)
        {
            desc.SetActive(true);
        }
    }

    public void SetViewsOn()
    {
        foreach (GameObject desc in descriptions)
        {
            desc.SetActive(false);
        }

        foreach (GameObject view in views)
        {
            view.SetActive(true);
        }
    }
}
