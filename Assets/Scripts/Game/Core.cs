using UnityEngine;
using UnityEngine.Events;
using UnityEditor;

public class Core : MonoBehaviour
{
    [SerializeField] private Item currentItem;

    public UnityEvent takeRightItemEvent;
    public UnityEvent takeNotRightItemEvent;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (currentItem.ID == other.gameObject.GetComponent<Item>().ID)
        {
            takeRightItemEvent?.Invoke();
        }
        else
        {
            takeNotRightItemEvent?.Invoke();
        }
    }
}