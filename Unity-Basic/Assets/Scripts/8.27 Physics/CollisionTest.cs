using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Enter : {collision.gameObject.name}"); // �浹�� ������Ʈ�� �̸��� ���

        //if(collision.gameObject.tag == "Player") // �±׸� ����
        //{
        //    Destroy(gameObject);
        //}
        // Destroy(gameObject);

    }
    void OnCollisionStay(Collision collision)
    {
        Debug.Log($"Stay : {collision.gameObject.name}");
    }
    void OnCollisionExit(Collision collision)
    {
        Debug.Log($"Exit : {collision.gameObject.name}");
    }
}
