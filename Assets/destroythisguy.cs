using UnityEngine;

public class destroythisguy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("smeg"))
        {
            Destroy(collision.gameObject);
            //destroy dat thang
        }
    }
}
