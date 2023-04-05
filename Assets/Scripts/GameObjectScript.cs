using UnityEngine;

public class GameObjectScript : MonoBehaviour
{

    [SerializeField] GameObject cube;
    [SerializeField] GameObject bullet;
    [SerializeField] float bulletTimeInterval;


    float bulletTime = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GetHoldOfGameObjects();
        
        CreateBullet();
    }

    void CreateBullet()
    {
        if (bulletTime <= 0f)
        {
            GameObject newBullet = Instantiate(
                bullet, transform.position, Quaternion.Euler(Time.time * 100, 0, 0)
            );
            bulletTime = bulletTimeInterval;
            Destroy(newBullet, 2f);
            // newBullet.SetActive(false);
        }
        bulletTime -= Time.deltaTime;
    }

	void GetHoldOfGameObjects()
	{
        Vector3 velocity = new Vector3(2f * Time.deltaTime, 0, 0);
        if (cube != null)
        {
            cube.transform.position += velocity;
        }
        GameObject cube2 = GameObject.Find("TestCube2");
        if (cube2 != null)
        {
            cube2.transform.position += velocity * 0.5f;
        }
        Transform child1 = transform.GetChild(0);
        if (child1 != null)
        {
            child1.position += velocity * 0.1f;
        }
        Transform child2 = transform.Find("Cylinder");
        if (child2 != null)
        {
            child2.position += velocity * 0.2f;
        }
        if (transform.parent != null)
        {
            transform.parent.position -= velocity * 3f;
        }

        //gameObject.transform.gameObject.transform.gameObject.transform

        //this.gameObject.transform.position += velocity;
	}
}
