using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCoolDown : MonoBehaviour
{
    public float coolDownTime;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    private void OnDisable()
    {
        Invoke("ResetItem", coolDownTime);
    }

    private void ResetItem()
    {
        gameObject.SetActive(true);
    }
}
