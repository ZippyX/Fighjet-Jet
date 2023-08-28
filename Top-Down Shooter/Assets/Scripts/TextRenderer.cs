using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextRenderer : MonoBehaviour
{
    private Text _canvas;
    public Player controller;
    void Start()
    {
        _canvas = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _canvas.text = "HP: "+ controller.HealtPoint.ToString();
    }
}
