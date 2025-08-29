using UnityEngine;

public class PlaneTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Avion"))
        {
            Debug.Log("L'avion est passé dans le cerceau ");
            Destroy(gameObject);
        }

        if (gameObject == null)
        {

        }
    }
}
