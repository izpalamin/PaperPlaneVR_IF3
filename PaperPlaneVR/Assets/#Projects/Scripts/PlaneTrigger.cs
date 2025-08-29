using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlaneTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Avion"))
        {
            Debug.Log("L'avion est passé dans le cerceau ");
            Destroy(gameObject);

            ScoreManager.instance.AddPoint();

        }
    }
}
