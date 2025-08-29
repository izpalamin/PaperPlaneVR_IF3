using UnityEngine;

public class PlaneTrigger : MonoBehaviour
{
    [SerializeField] private string tagName;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagName))
        {
            Debug.Log($"{other.name} est passé dans le cerceau ");
        }
    }
}
