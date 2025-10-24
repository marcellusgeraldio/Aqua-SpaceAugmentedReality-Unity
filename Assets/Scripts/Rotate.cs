using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
        Rotation();
    }

    private void Rotation()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime, Space.Self);
    }
}