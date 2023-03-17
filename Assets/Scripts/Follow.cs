using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset; // 고정값 offset

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = target.position + offset; // 카메라가 고정값에 의해 캐릭터 따라가기
    }
}
