using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    float hAxis;
    float vAxis; // Input Axis 값을 받을 전역변수
    bool wDown;

    Vector3 moveVec;

    Animator anim;

    void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        hAxis = Input.GetAxisRaw("Horizontal"); // Axis 값을 정수로 반환하는 함수 = GetAxisRaw
        vAxis = Input.GetAxisRaw("Vertical");
        wDown = Input.GetButton("Walk");

        moveVec = new Vector3(hAxis, 0, vAxis).normalized; // x,y,z값으로 이동하는 함수, normalized = 방향값이 1로 보정된 벡터

        transform.position += moveVec * speed * (wDown ? 0.3f : 1f) * Time.deltaTime; // 캐릭터의 이동속도, wDown이 true이면 0.3, false면 1의 속도

        anim.SetBool("isRun", moveVec != Vector3.zero);
        anim.SetBool("isWalk", wDown);


        transform.LookAt(transform.transform.position + moveVec); // LookAt = 지정된 벡터를 향해서 회전시켜주는 함수
    }
}
