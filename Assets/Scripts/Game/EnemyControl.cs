using UnityEngine;
public class EnemyControl : MonoBehaviour
{
    private Vector2 positionToMove;
    public float speedMove;

    private NodeControl currentNode;



    private void Start()
    {

        SetInitialNode();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, positionToMove, speedMove * Time.deltaTime);
    }

    private void SetInitialNode()
    {
        currentNode = FindObjectOfType<NodeControl>();
        if (currentNode != null)
        {
            positionToMove = currentNode.transform.position;
        }
    }

    private void MoveAlongPath()
    {
        if (Vector2.Distance(transform.position, positionToMove) < 0.1f)
        {
            NodeControl nextNode = currentNode.GetAdjacentNode();
            if (nextNode != null)
            {
                positionToMove = nextNode.transform.position;
                currentNode = nextNode;
            }
            else
            {


                SetInitialNode();
            }
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, positionToMove, speedMove * Time.deltaTime);
        }
    }

    public void SetNewPosition(Vector2 newPosition)
    {
        positionToMove = newPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Node"))
        {
            SetNewPosition(collision.GetComponent<NodeControl>().GetAdjacentNode().transform.position);
        }
    }
}
