using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class weapon_button : MonoBehaviour {

    private bool pressed_state = false;
    private Button btn;
    public Color pressed_color;
    private Color original_color;
    // Use this for initialization
    void Start () {
        btn = GetComponent<Button>();
        ColorBlock cb = btn.colors;
        original_color = cb.normalColor;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void weapon_pressed()
    {
        pressed_state = true;

        ColorBlock cb = btn.colors;
        cb.normalColor = pressed_color;
        btn.colors = cb;

    }

    public void weapon_unpressed()
    {
        pressed_state = false;

        ColorBlock cb = btn.colors;
        cb.normalColor = original_color;
        btn.colors = cb;

    }

}
