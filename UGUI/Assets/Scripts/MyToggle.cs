using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyToggle : MonoBehaviour
{
    public GameObject isOnGameObejct;
    public GameObject isOffGameObejct;
    private Toggle toggle;
    // Start is called before the first frame update
    void Start()
    {
        toggle = GetComponent<Toggle>();
        OnValueChange(toggle.isOn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnValueChange(bool isOn)
    {
        isOnGameObejct.SetActive(!isOn);
        isOffGameObejct.SetActive(isOn);
    }

}
