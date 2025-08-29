using UnityEngine;

public class RestartGround : MonoBehaviour
{
    // if avion touch ground alors on fait apparaitre le canva
    public GameObject restartMenu;
    void Start()
    {
        if (restartMenu != null)
        {
            restartMenu.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // if (Collision..CompareTag("Ground"))
        // {

        // }
    }

    void Update()
    {
        
    }
}
