using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RGBASliderColorChange : MonoBehaviour
{
    public Image targetImage; // Reference to the image you want to change color
    public Slider redSlider; // Reference to the Red slider
    public Slider greenSlider; // Reference to the Green slider
    public Slider blueSlider; // Reference to the Blue slider
    public Slider alphaSlider; // Reference to the Alpha slider

    private void Start()
    {
        // Subscribe to the OnValueChanged event of each slider
        redSlider.onValueChanged.AddListener(OnSliderValueChanged);
        greenSlider.onValueChanged.AddListener(OnSliderValueChanged);
        blueSlider.onValueChanged.AddListener(OnSliderValueChanged);
        alphaSlider.onValueChanged.AddListener(OnSliderValueChanged);

        // Set the initial color of the image
        UpdateImageColor();
    }

    // Method called when any of the sliders' value changes
    private void OnSliderValueChanged(float value)
    {
        // Update the color of the image
        UpdateImageColor();
    }

    // Update the color of the image based on the slider values
    private void UpdateImageColor()
    {
        // Create a new color using the slider values for each channel
        Color newColor = new Color(redSlider.value, greenSlider.value, blueSlider.value, alphaSlider.value);

        // Apply the new color to the target image
        targetImage.color = newColor;
    }
}

