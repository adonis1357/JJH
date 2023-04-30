using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    //public LayerMask targetLayer; // 대상 레이어
    //public Collider2D selfCollider; // 현재 오브젝트의 콜라이더

    //private void Update()
    //{
    //    // 겹침 체크
    //    CheckOverlap();
    //}

    //private void CheckOverlap()
    //{
    //    // 현재 오브젝트의 콜라이더의 경계 상자 가져오기
    //    Bounds selfBounds = selfCollider.bounds;

    //    // 겹치는 모든 2D 콜라이더 가져오기
    //    Collider2D[] overlappingColliders = Physics2D.OverlapAreaAll(selfBounds.min, selfBounds.max);

    //    foreach (Collider2D overlappingCollider in overlappingColliders)
    //    {
    //        // 다른 오브젝트의 콜라이더가 있는 경우 처리
    //        if (overlappingCollider != selfCollider)
    //        {
    //            // 처리 로직 작성
    //            // 예시로는 겹친 오브젝트의 정보를 출력
    //            Debug.Log("Overlap with: " + overlappingCollider.gameObject.name);
    //        }
    //    }
    //}

    public LayerMask targetLayer; // 대상 레이어
    public bool tf = true;
    public bool tf2 = true;

    private void Update()
    {
        if (tf)
        {
            // 겹침 체크
            CheckOverlap();
        }
    }

    private void CheckOverlap()
    {
        // 현재 오브젝트의 콜라이더의 경계 상자 가져오기
        Bounds selfBounds = GetComponent<Collider2D>().bounds;

        // 겹치는 모든 2D 콜라이더 가져오기
        Collider2D[] overlappingColliders = Physics2D.OverlapAreaAll(selfBounds.min, selfBounds.max);

        foreach (Collider2D overlappingCollider in overlappingColliders)
        {
            // 다른 오브젝트의 레이어 체크
            if (IsTargetLayer(overlappingCollider.gameObject))
            {
                tf = false;
                // 특정 레이어와 겹친 경우 처리
                Debug.Log("Overlap with target layer: " + overlappingCollider.gameObject.name);
            }
        }
        tf2 = false;
    }

    private bool IsTargetLayer(GameObject gameObject)
    {
        // 레이어 체크
        return (targetLayer.value & (1 << gameObject.layer)) != 0;
    }

    
}
