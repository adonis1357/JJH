using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDelete : MonoBehaviour
{
    //public Check childScript; // �ڽ� ��ũ��Ʈ ���� ����

    public bool tftf = true;

    void Update()
    {
        // �ڽ� ������Ʈ �̸����� ã��
        Transform child0 = transform.Find("MatchCheck (0)");
        Transform child1 = transform.Find("MatchCheck (1)");
        Transform child2 = transform.Find("MatchCheck (2)");
        Transform child3 = transform.Find("MatchCheck (3)");
        Transform child4 = transform.Find("MatchCheck (4)");
        Transform child5 = transform.Find("MatchCheck (5)");


        Check childScript0 = child0.GetComponent<Check>();
        Check childScript1 = child1.GetComponent<Check>();
        Check childScript2 = child2.GetComponent<Check>();
        Check childScript3 = child3.GetComponent<Check>();
        Check childScript4 = child4.GetComponent<Check>();
        Check childScript5 = child5.GetComponent<Check>();

        bool childBool0 = childScript0.tf;
        bool childBool1 = childScript1.tf;
        bool childBool2 = childScript2.tf;
        bool childBool3 = childScript3.tf;
        bool childBool4 = childScript4.tf;
        bool childBool5 = childScript5.tf;

        bool childBool00 = childScript0.tf2;
        bool childBool11 = childScript1.tf2;
        bool childBool22 = childScript2.tf2;
        bool childBool33 = childScript3.tf2;
        bool childBool44 = childScript4.tf2;
        bool childBool55 = childScript5.tf2;


        Debug.Log("Child Bool: " + childBool0);
        Debug.Log("Child Bool: " + childBool1);
        Debug.Log("Child Bool: " + childBool2);
        Debug.Log("Child Bool: " + childBool3);
        Debug.Log("Child Bool: " + childBool4);
        Debug.Log("Child Bool: " + childBool5);

        if (childBool00 && childBool11 && childBool22 && childBool33 && childBool44 && childBool55)
            return;

        if ((childBool0 == false && childBool1 == false) || (childBool1 == false && childBool2 == false) || (childBool2 == false && childBool3 == false) || (childBool3 == false && childBool4 == false) || (childBool4 == false && childBool5 == false) || (childBool5 == false && childBool0 == false))
        {
            tftf = false;
            Destroy(gameObject);
        }

        //if (child0 != null)
        //{
        //    // �ڽ� ������Ʈ�� ��ũ��Ʈ ������Ʈ ��������
        //    ChildScript childScript0 = child0.GetComponent<ChildScript>();

        //    if (childScript0 != null)
        //    {
        //        // �ڽ� ��ũ��Ʈ�� ������ ����
        //        bool childBool = childScript.tf;
        //        Debug.Log("Child Bool: " + childBool);
        //    }
        //}
    }

    // �ڽ� ������Ʈ�� ��ũ��Ʈ ������Ʈ ��������
    //childScript = GetComponentInChildren<Check>();

    //    if (childScript != null)
    //    {
    //        // �ڽ� ��ũ��Ʈ�� ������ ����
    //        bool childBool = childScript.tf;
    //        Debug.Log("Child Bool: " + childBool);
    //    }
    //}

    //private void Update()
    //{
    //    // �ڽ� ������Ʈ�� ��ũ��Ʈ ������Ʈ ��������
    //    childScript = GetComponentInChildren<Check>();

    //    if (childScript != null)
    //    {
    //        // �ڽ� ��ũ��Ʈ�� ������ ����
    //        bool childBool = childScript.tf;
    //        Debug.Log("Child Bool: " + childBool);
    //    }
    //}
}
