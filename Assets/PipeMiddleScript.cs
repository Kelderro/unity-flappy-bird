using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic")
                          .GetComponent<LogicScript>();
        Debug.Log(logic);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collision is with the bird layer (3)
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
    }
}
