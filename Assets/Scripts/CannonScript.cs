using UnityEngine;

public class CannonScript : MonoBehaviour
{
    [SerializeField] float bulletTimeInterval;
    [SerializeField] float speed;
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject cannonPivot;

    float bulletTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void CreateBullet()
    {
        if (bulletTime <= 0f)
        {
            GameObject newBullet = Instantiate(
                bullet,
                cannonPivot.transform.position,
                transform.rotation
            );
            
            Rigidbody rb = newBullet.GetComponent<Rigidbody>();
            if (rb != null)
                rb.AddForce(
                    newBullet.transform.up * speed 
                    + newBullet.transform.forward * speed * 0.5f
                );
            
            bulletTime = bulletTimeInterval;
            Destroy(newBullet, 10f);
        }
        bulletTime -= Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Time.deltaTime * 200f, 0f, 0f);
        CreateBullet();
    }
}
