using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsTabs : MonoBehaviour {

    public Transform visualsTab;
    public Transform controlsTab;
    public Transform audioTab;
    
	void Start () {
        visualsTab = transform.Find("SettingsVisualsTab");
        controlsTab = transform.Find("SettingsControlsTab");
        audioTab = transform.Find("SettingsAudioTab");
        visualsTab.gameObject.SetActive(true);
        controlsTab.gameObject.SetActive(false);
        audioTab.gameObject.SetActive(false);
	}
	
	void Update () {
		
	}

    public void ClickVisuals()
    {
        visualsTab.gameObject.SetActive(true);
        controlsTab.gameObject.SetActive(false);
        audioTab.gameObject.SetActive(false);
    }

    public void ClickControls()
    {
        visualsTab.gameObject.SetActive(false);
        controlsTab.gameObject.SetActive(true);
        audioTab.gameObject.SetActive(false);
    }

    public void ClickAudio()
    {
        visualsTab.gameObject.SetActive(false);
        controlsTab.gameObject.SetActive(false);
        audioTab.gameObject.SetActive(true);
    }
}
