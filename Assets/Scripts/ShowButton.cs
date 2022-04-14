using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowButton : MonoBehaviour
{

    public GameObject StartButton;

    public void ButtonShow()
    {
        StartButton.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke ("ButtonShow", 7F);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
