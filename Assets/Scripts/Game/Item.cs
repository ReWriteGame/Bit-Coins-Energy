using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour
{
  [SerializeField] private int id;

  public int ID => id;

  public UnityEvent touchCoreEvent;
  public UnityEvent touchProtectionEvent;
  
  private void OnTriggerEnter2D(Collider2D other)
  {
    if(other.gameObject.GetComponent<Core>())
      touchCoreEvent?.Invoke();
  }

  private void OnCollisionEnter2D(Collision2D other)
  {
    if(other.gameObject.GetComponent<Core>())
      touchCoreEvent?.Invoke();
    
    if(other.gameObject.GetComponent<Protection>())
      touchProtectionEvent?.Invoke();
  }
}
