using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    //public LayerMask targetLayer; // ��� ���̾�
    //public Collider2D selfCollider; // ���� ������Ʈ�� �ݶ��̴�

    //private void Update()
    //{
    //    // ��ħ üũ
    //    CheckOverlap();
    //}

    //private void CheckOverlap()
    //{
    //    // ���� ������Ʈ�� �ݶ��̴��� ��� ���� ��������
    //    Bounds selfBounds = selfCollider.bounds;

    //    // ��ġ�� ��� 2D �ݶ��̴� ��������
    //    Collider2D[] overlappingColliders = Physics2D.OverlapAreaAll(selfBounds.min, selfBounds.max);

    //    foreach (Collider2D overlappingCollider in overlappingColliders)
    //    {
    //        // �ٸ� ������Ʈ�� �ݶ��̴��� �ִ� ��� ó��
    //        if (overlappingCollider != selfCollider)
    //        {
    //            // ó�� ���� �ۼ�
    //            // ���÷δ� ��ģ ������Ʈ�� ������ ���
    //            Debug.Log("Overlap with: " + overlappingCollider.gameObject.name);
    //        }
    //    }
    //}

    public LayerMask targetLayer; // ��� ���̾�
    public bool tf = true;
    public bool tf2 = true;

    private void Update()
    {
        if (tf)
        {
            // ��ħ üũ
            CheckOverlap();
        }
    }

    private void CheckOverlap()
    {
        // ���� ������Ʈ�� �ݶ��̴��� ��� ���� ��������
        Bounds selfBounds = GetComponent<Collider2D>().bounds;

        // ��ġ�� ��� 2D �ݶ��̴� ��������
        Collider2D[] overlappingColliders = Physics2D.OverlapAreaAll(selfBounds.min, selfBounds.max);

        foreach (Collider2D overlappingCollider in overlappingColliders)
        {
            // �ٸ� ������Ʈ�� ���̾� üũ
            if (IsTargetLayer(overlappingCollider.gameObject))
            {
                tf = false;
                // Ư�� ���̾�� ��ģ ��� ó��
                Debug.Log("Overlap with target layer: " + overlappingCollider.gameObject.name);
            }
        }
        tf2 = false;
    }

    private bool IsTargetLayer(GameObject gameObject)
    {
        // ���̾� üũ
        return (targetLayer.value & (1 << gameObject.layer)) != 0;
    }

    
}
