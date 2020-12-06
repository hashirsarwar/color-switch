using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject[] circles;
	[SerializeField] GameObject cchanger;
	[SerializeField] Transform bpos;
    [SerializeField] GameObject sliderRef;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawner()
    {
        int index = Random.Range(0, 5);

        GameObject acircle = Instantiate(circles[index]);
		acircle.transform.position = new Vector3(0, bpos.position.y + 6, 0);
        
        GameObject acchanger = Instantiate(cchanger);
        acchanger.transform.position = new Vector3(0, bpos.position.y + 12, 0);

        sliderRef.transform.position = new Vector3(0, bpos.position.y, 0);
    }
}
