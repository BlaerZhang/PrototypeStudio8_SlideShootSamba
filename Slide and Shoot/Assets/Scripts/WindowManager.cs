using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WindowManager : MonoBehaviour
{
    public GameObject window1;
    private SpriteRenderer[] window1Sprites;
    private TextMeshPro window1Text;
        
    public GameObject window2;
    private SpriteRenderer[] window2Sprites;
    private TextMeshPro window2Text;
    
    public GameObject window3;
    private SpriteRenderer[] window3Sprites;
    private TextMeshPro window3Text;
    
    public GameObject window4;
    private SpriteRenderer[] window4Sprites;
    private TextMeshPro window4Text;

    private float timer;
    public float windowDuration;
    public int currentActiveWindow;

    public List<int> windowLoopOrder;
    private int windowLoopOrderIndex;

    void Start()
    {
        currentActiveWindow = 1;
        windowLoopOrderIndex = 0;
        timer = windowDuration;

        window1Sprites = window1.GetComponentsInChildren<SpriteRenderer>();
        window2Sprites = window2.GetComponentsInChildren<SpriteRenderer>();
        window3Sprites = window3.GetComponentsInChildren<SpriteRenderer>();
        window4Sprites = window4.GetComponentsInChildren<SpriteRenderer>();

        window1Text = window1.GetComponentInChildren<TextMeshPro>();
        window2Text = window2.GetComponentInChildren<TextMeshPro>();
        window3Text = window3.GetComponentInChildren<TextMeshPro>();
        window4Text = window4.GetComponentInChildren<TextMeshPro>();

    }

    // Update is called once per frame
    void Update()
    {
        switch (currentActiveWindow)
        {
            case 1:
                timer -= Time.deltaTime;
                window1Text.text = "window shuts in: " + timer.ToString("0") + "s";
                window2Text.text = "";
                window3Text.text = "";
                window4Text.text = "";
                DisplayWindowText();
                
                foreach (var sprite in window1Sprites)
                {
                    sprite.color = new Color32(0, 0, 255, 128);
                    sprite.gameObject.layer = default;
                }
                
                foreach (var sprite in window2Sprites)
                {
                    sprite.color = Color.white;
                    sprite.gameObject.layer = 8;
                }
                
                foreach (var sprite in window3Sprites)
                {
                    sprite.color = Color.white;
                    sprite.gameObject.layer = 8;
                }
                
                foreach (var sprite in window4Sprites)
                {
                    sprite.color = Color.white;
                    sprite.gameObject.layer = 8;
                }
                break;
            
            case 2:
                timer -= Time.deltaTime;
                window1Text.text = "";
                window2Text.text = "window shuts in: " + timer.ToString("0") + "s";
                window3Text.text = "";
                window4Text.text = "";
                DisplayWindowText();

                foreach (var sprite in window2Sprites)
                {
                    sprite.color = new Color32(0, 0, 255, 128);
                    sprite.gameObject.layer = default;
                }
                
                foreach (var sprite in window1Sprites)
                {
                    sprite.color = Color.white;
                    sprite.gameObject.layer = 8;
                }
                
                foreach (var sprite in window3Sprites)
                {
                    sprite.color = Color.white;
                    sprite.gameObject.layer = 8;
                }
                
                foreach (var sprite in window4Sprites)
                {
                    sprite.color = Color.white;
                    sprite.gameObject.layer = 8;
                }
                break;
            
            case 3:
                timer -= Time.deltaTime;
                window1Text.text = "";
                window2Text.text = "";
                window3Text.text = "window shuts in: " + timer.ToString("0") + "s";
                window4Text.text = "";
                DisplayWindowText();

                foreach (var sprite in window3Sprites)
                {
                    sprite.color = new Color32(0, 0, 255, 128);
                    sprite.gameObject.layer = default;
                }
                
                foreach (var sprite in window1Sprites)
                {
                    sprite.color = Color.white;
                    sprite.gameObject.layer = 8;
                }
                
                foreach (var sprite in window2Sprites)
                {
                    sprite.color = Color.white;
                    sprite.gameObject.layer = 8;
                }
                
                foreach (var sprite in window4Sprites)
                {
                    sprite.color = Color.white;
                    sprite.gameObject.layer = 8;
                }
                break;
            
            case 4:
                timer -= Time.deltaTime;
                window4Text.text = "window shuts in: " + timer.ToString("0") + "s";
                window1Text.text = "";
                window2Text.text = "";
                window3Text.text = "";
                DisplayWindowText();

                foreach (var sprite in window4Sprites)
                {
                    sprite.color = new Color32(0, 0, 255, 128);
                    sprite.gameObject.layer = default;
                }
                
                foreach (var sprite in window1Sprites)
                {
                    sprite.color = Color.white;
                    sprite.gameObject.layer = 8;
                }
                
                foreach (var sprite in window2Sprites)
                {
                    sprite.color = Color.white;
                    sprite.gameObject.layer = 8;
                }
                
                foreach (var sprite in window3Sprites)
                {
                    sprite.color = Color.white;
                    sprite.gameObject.layer = 8;
                }
                break;
        }

        if (timer <= 0)
        {
            windowLoopOrderIndex = (windowLoopOrderIndex + 1) % windowLoopOrder.Count;
            currentActiveWindow = windowLoopOrder[windowLoopOrderIndex];
            timer = windowDuration;
        }
        
    }

    void DisplayWindowText()
    {
        switch (windowLoopOrder[(windowLoopOrderIndex + 1) % windowLoopOrder.Count])
        {
            case 1:
                window1Text.text = "window opens in: " + timer.ToString("0") + "s";
                break;
            case 2:
                window2Text.text = "window opens in: " + timer.ToString("0") + "s";
                break;
            case 3:
                window3Text.text = "window opens in: " + timer.ToString("0") + "s";
                break;
            case 4:
                window4Text.text = "window opens in: " + timer.ToString("0") + "s";
                break;
        }
    }
}
