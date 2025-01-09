using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShaderController : MonoBehaviour
{
    public Material matriel;
    public Slider Slider;
    public Toggle Toggle;

    void Start()
    {
        Slider.onValueChanged.AddListener(value => matriel.SetFloat("_NumberOfBands", value));
        Toggle.onValueChanged.AddListener(value => matriel.SetFloat("_UsePhong", value ? 1f : 0f));
    }
}
