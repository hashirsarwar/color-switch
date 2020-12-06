using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rFactor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rFactor * Time.deltaTime);
    }
}
