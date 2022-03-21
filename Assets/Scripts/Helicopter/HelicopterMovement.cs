using UnityEngine;

public class HelicopterMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float turnSpeed = 10f;
    [SerializeField] private string inputHorizontal = "Horizontal";
    [SerializeField] private string inputVertical = "Vertical";

    private float horizonatalMovement = 0;
    private float verticalMovement = 0;
    private Rigidbody heliRigidbody;
    private bool canStart = false;

    // Start is called before the first frame update
    void Start()
    {
        GetHelicopterComponents();
    }

    private void Update()
    {
        horizonatalMovement = Input.GetAxis(inputHorizontal); // Getting Left and right input
        verticalMovement = Input.GetAxis(inputVertical); // getting up and down input
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!canStart)
            return;

        MoveHelicopter();
    }

    private void GetHelicopterComponents()
    {
        heliRigidbody = GetComponent<Rigidbody>();
        if (heliRigidbody == null)
            Debug.LogError("Error! no rigidbody was attached to " + gameObject.name);
        else
            canStart = true;
    }

    private void MoveHelicopter()
    {
       transform.position += transform.forward * verticalMovement * Time.deltaTime * moveSpeed;
       transform.Rotate(0, horizonatalMovement * Time.deltaTime*turnSpeed, 0);

    }
}
