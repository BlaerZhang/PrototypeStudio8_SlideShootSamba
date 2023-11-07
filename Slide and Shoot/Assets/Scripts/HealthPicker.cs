using System;
using System.Collections;
using System.Collections.Generic;
using MoreMountains.Feedbacks;
using MoreMountains.TopDownEngine;
using UnityEngine;

public class HealthPicker : MonoBehaviour
{
    private Health playerHealth;
    public float healthRecovered;
    private MMF_Player feedback;
    
    void Start()
    {
        feedback = GetComponentInChildren<MMF_Player>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            playerHealth = col.GetComponent<Health>();
            if (playerHealth != null)
            {
                playerHealth.ReceiveHealth(healthRecovered, gameObject);
                feedback.PlayFeedbacks();
                gameObject.SetActive(false);
            }
        }
    }
}
