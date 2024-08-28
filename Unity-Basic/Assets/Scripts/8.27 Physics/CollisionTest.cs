using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Enter : {collision.gameObject.name}"); // 충돌된 오브젝트의 이름을 출력

        //if(collision.gameObject.tag == "Player") // 태그를 쓰기
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
