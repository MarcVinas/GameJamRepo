using UnityEngine;

public class ThrowPresent : MonoBehaviour
{

    public Transform initialPosition;
    public Transform destinationPosition;
    public float hight = 25f;
    public float gravity = -18f;

    //public Transform initPosition;
    public GameObject prefabPresent;
  
    private GameObject presentGO;
    private Vector3 velocityCalculated;
    private Rigidbody presentRigidBody;
    //private PresentProjectileController presentPC;
    private void Start()
    {
       
      

    }
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            presentGO = Instantiate(prefabPresent, transform.position, Quaternion.identity);

           
           // presentPC = presentGO.GetComponent<PresentProjectileController>();
            //presentPC.InstantiateVariables(transform, destinationPosition, hight, gravity);
            presentRigidBody = presentGO.GetComponent<Rigidbody>();
            Physics.gravity = Vector3.up * gravity;
            velocityCalculated = MathUtil.CalculatedVelocity(initialPosition.position, destinationPosition.position, hight, gravity);
            presentRigidBody.useGravity = true;
            presentRigidBody.velocity = velocityCalculated;
        }
    }
}
