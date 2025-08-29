using Unity.Mathematics;
using UnityEngine;
 
public class Gliding : MonoBehaviour
{
    public static float BaseThrustSpeed = 30f;
    [SerializeField] private float MaxThrustSpeed;
    [SerializeField] private float MinThrustSpeed;
    [SerializeField] private float ThrustFactor;
    private float CurrentThrustSpeed = BaseThrustSpeed;
 
    private Rigidbody Rbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rbody = GetComponent<Rigidbody>();
    }
 
    void FixedUpdate()
    {
        GlidingMouvement();
    }
    // Update is called once per frame
    void Update()
    {
 
    }
 
    private void GlidingMouvement()
    {
        float pitchInRads = transform.eulerAngles.x * Mathf.Deg2Rad;
        float mappedPitch = Mathf.Sin(pitchInRads) * ThrustFactor;
        Vector3 glidingForce = Vector3.forward * CurrentThrustSpeed;
        CurrentThrustSpeed += mappedPitch * Time.deltaTime;
        CurrentThrustSpeed = Mathf.Clamp(CurrentThrustSpeed, 0, MaxThrustSpeed);
 
        
        Rbody.AddRelativeForce(glidingForce);
    }
}