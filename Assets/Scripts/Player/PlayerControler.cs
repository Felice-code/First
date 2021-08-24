using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    
    void Start()
    {
        
    }
    public GameObject BulletPrefabs;
    public float speed = 0.02f;
    public float bulletspeed = 100f;
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(BulletPrefabs);
            bullet.transform.position = transform.position;
            bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bulletspeed);
        }
    }
}
