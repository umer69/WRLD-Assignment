using UnityEngine;

public class FollowHelipcopter : MonoBehaviour
{
    [SerializeField] private Transform helicopter;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float followSpeed = 5f;
    private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (helicopter == null)
            return;

        transform.position = Vector3.Lerp(transform.position, helicopter.transform.position + offset, followSpeed * Time.deltaTime);
    }
}
