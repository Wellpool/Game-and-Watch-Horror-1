using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResolutionController : MonoBehaviour
{
    public Dropdown resolutionDropdown;
    private int[] resolutions = new int[] { 480, 720, 1080, 1440, 3840 };
    
    void Start()
    {
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i] + "p";
            options.Add(option);
            if (resolutions[i] == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }
    public void SetResolution(int resolutionIndex)
    {
        int height = resolutions[resolutionIndex];
        int width = Mathf.RoundToInt(height * (16f / 9f));
        Screen.SetResolution(width, height, Screen.fullScreen);
    }
}
