using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsDisplay : MonoBehaviour
{
    private TextMeshProUGUI pointsText;
    void Start()
    {
        pointsText = GameObject.Find("Points").GetComponent<TextMeshProUGUI>();
        MoreMountains.TopDownEngine.GameManager.Instance.Points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = MoreMountains.TopDownEngine.GameManager.Instance.Points.ToString();
    }
}
