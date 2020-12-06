using UnityEngine;

public class FollowThrough : MonoBehaviour
{
    public Transform ballLoc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ballLoc.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, ballLoc.position.y ,transform.position.z);
        }
    }
}
