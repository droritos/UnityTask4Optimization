using UnityEngine;

public class ArrowObject : MonoBehaviour
{
    public float speed;
    
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
