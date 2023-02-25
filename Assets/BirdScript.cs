using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flatStrength;
    private LogicScript logic;
    public bool birdIsAlive = true;
    private float sceneMax = 10.5f;

    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic")
                  .GetComponent<LogicScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidBody.velocity = Vector2.up * flatStrength;
        }
          
        if (transform.position.y > sceneMax) {
            transform.position = new Vector3(transform.position.x, sceneMax);
            myRigidBody.velocity = Vector2.zero;
        } else if (transform.position.y < sceneMax * -1) {
            transform.position = new Vector3(transform.position.x, sceneMax * -1);
            myRigidBody.velocity = Vector2.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
