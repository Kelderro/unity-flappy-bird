using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -28;

    void Update()
    {
        transform.position = transform.position + (moveSpeed * Time.deltaTime * Vector3.left);

        if (transform.position.x < deadZone) {
            Debug.Log("Pipe deleted");
            Destroy(gameObject);
        }
    }
}
