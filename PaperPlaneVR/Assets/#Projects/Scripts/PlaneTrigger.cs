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
<<<<<<< HEAD
            ScoreManager.instance.AddPoint();
            // score ??
=======
        }

        if (gameObject == null)
        {

>>>>>>> 72f4554119d65a96a04a2347b6c8b01fa230e303
        }
    }

}
