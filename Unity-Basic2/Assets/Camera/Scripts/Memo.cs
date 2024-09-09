using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memo : MonoBehaviour
{
    /*

    // 플레이어 머리방향을 위해 달아준 큐브가 카메라 앞을 가림
    // ㄴ 눈에 Invisible 레이어를 달아준 후 카메라의 컬링마스크로 보이지 않게 설정함

    // 플레이어의 이동을 플레이어쪽에 구현하고.. 보는것을 카메라에서 구현하면 
    // 회전은 결국 한쪽에서 구현해야하는데 둘 다 구현하려면 여기저기 왔다갔다 해야해서 일단 플레이어에 구현함
    // 저번에 FPS 구현한것처럼

    되긴 하는데 뭔가 이상함
    굳이 플레이어의 회전을 바꿔줄 필요는 없는거같음 , x축 회전만 주면 좀 자연스럽나?
    이동과 회전을 플레이어 중심으로 줘볼 필요가 있을거같다
    플레이어의 시야각도에 제한을 줄 필요가 있을거같다. 
    ㄴ 제한주는게 Mathf.Clamp 였나 // 아니 제한 안줘도 될거같다
    의도한대로 잘 되는데 한가지 문제가 있다면 
    플레이어가 취한것같이 시점이 기울어진채로라는것
    ㄴ 과제내용을 보면 Y축 회전 시점만 있으면 될거같다
    아 이거 1인칭 과제가 아니었지..
    카메라 위치만 지금 상태에서 플레이어와 위치가 일정하게 뒤로 좀 빼주면 되려나
    매번 코드상에서 시점 지정해주기 번거로우니 오프셋으로 시리얼라이즈 해자

    transform.position = playerTransform.position + offset;
    transform.rotation = playerTransform.rotation;
    이렇게 했더니 카메라가 플레이어의 회전을 그대로 따라가서 플레이어가 카메라의 고정된 위치에서 벗어나버림
    Lookat으로 플레이어의 포지션을 바라보도록 함
    플레이어 무버에서만 마우스 입력값을 받고 update에서 이동을 시켜줄거라 
    플레이어 무버에서 계산된 값을 카메라컨트롤러에서 받아야함
    
    두 클래스 모두에서 마우스 입력을 받도록 했더니 충돌이 났는지 시점이 이상하게 움직인다 계속 돌아오려함
    플레이어를 기준으로 회전하게 만들었지만 LookAt 때문인지 계속 플레이어쪽으로 시점이 다시 돌아와버린다
    가장 최근의 로테이션 값을 저장해서 유지하도록 하면 될까?

    카메라의 방향대로 플레이어의 시점이 이동하지 않음

    rotateAround가 제일 원하던 회전에 근접하긴 하는데 카메라에 따라 플레이어의 시점이 이동해야하고..
    플레이어가 카메라를 바라보게하는 Look 메서드를 만들었지만 플레이어가 바닥에 박힌다
    리지드바디를 달아서 y축을 고정해주려 했는데 아주 날아다닌다.. 끼얏호우..
     
    추가 과제로 벽뒤로 들어가면 카메라가 당겨져야하는데 음..
    카메라에서 레이캐스트를 쏴서 플레이어가 아닌 벽에 쏘면 카메라를 당겨주는 로직을 추가하면 되나?

    악 코루틴 yield return 안하고 while(true) 했더니 프로젝트가 터졌다!!!!

    좋아 레이캐스트로 장애물 감지까진 됐다
    이제 카메라를 어떻게하지..?
    if(hit.collider.CompareTag("Obstacle"))
            {
                Debug.Log("장애물에 막힘!");
                //transform.position = playerTransform.position - rayDirection * hit.distance;
                // 계산이 잘못됨
                transform.position =  playerTransform.position + playerTransform.position -(rayDirection*hit.distance);
                transform.LookAt(playerTransform.position);
            }

    이렇게 하려했는데 안되네
    벽의 유격때문에 그런가?
    사실 더 큰 문제는 장애물에 막혔을때 카메라 위치가 플레이어를 중앙에 두던것을 벗어나버린다는것..



     */

}
