using System.Collections;
using System.Collections.Generic;
using UnityEngine;





enum E_RayTYPE
{
    UP,
    RIGHTUP,
    RIGHTDOWN,
    DOWN,
    LEFTDOWN,
    LEFTUP,

    Max
}

public class MatchCheck : MonoBehaviour
{
    [SerializeField]
    protected Vector2[] RayTypeVecList =
    {
        new Vector2(0, 1)
        , Quaternion.Euler(0,0,60f) * new Vector2(0, 1)
        , Quaternion.Euler(0,0,120f) * new Vector2(0, 1)
        , Quaternion.Euler(0,0,180f) * new Vector2(0, 1)
        , Quaternion.Euler(0,0,240f) * new Vector2(0, 1)
        , new Vector2(0, 1)
    };


    public float proximityDistance = 1f; // 오브젝트가 서로 가까운 거리
    public LayerMask whatIsSameObject; // 같은 오브젝트를 나타내는 레이어 마스크

    void Start()
    {
        m_body2d = GetComponent<Rigidbody2D>();
        DeactivateAllObjects();
    }
    void Update()
    {
        // 현재 오브젝트 주변에 있는 모든 같은 오브젝트 검색
        Collider2D[] nearbyObjects = Physics2D.OverlapCircleAll(transform.position, proximityDistance, whatIsSameObject);

        // 검색된 오브젝트가 3개 이상일 때만 파괴
        if (nearbyObjects.Length >= 3)
        {
            foreach (Collider2D nearbyObject in nearbyObjects)
            {
                Destroy(nearbyObject.gameObject);
            }
        }

        if( m_body2d.velocity.sqrMagnitude >= 0.01f)
        {
            m_ISStop = false;
        }
        else
        {
            m_ISStop = true;
        }

    }

    Rigidbody2D m_body2d;
    public bool m_ISStop = false;


    public List<Transform> m_EraseList = new List<Transform>();

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
        
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {

        Collider[] collarr = Physics.OverlapSphere(transform.position, 0.34f);

        for (int i = 0; i < (int)E_RayTYPE.Max; i++)
        {

            if( ISGroup((E_RayTYPE)i) )
            {

            }
        }

    }

    void DeactivateAllObjects()
    {
        foreach (Transform trans in m_EraseList)
        {
            trans.gameObject.SetActive(false); // 오브젝트를 비활성화합니다.
        }
    }


    bool ISGroup(E_RayTYPE p_raytype)
    {

        int ray1index = (int)p_raytype % (int)E_RayTYPE.Max;
        int ray2index = ((int)p_raytype + 1) % (int)E_RayTYPE.Max;

        int mylayer = gameObject.layer;
        int hitlayer = -1;
        int hitlayer2 = -1;
        Ray2D ray = new Ray2D(transform.position, RayTypeVecList[ray1index] );
        RaycastHit2D hitinfo;
        RaycastHit2D hitinfo2;

        hitinfo = Physics2D.Raycast(ray.origin, ray.direction, 3f);




        // 충돌 1번
        GameObject hitobj = null;
        RaycastHit2D[] hitarr = Physics2D.RaycastAll(transform.position, RayTypeVecList[ray1index], 3f);
        if( hitarr.Length >= 2)
        {
            hitobj = hitarr[1].transform.gameObject;
        }

        // 충돌 2번
        GameObject hitobj2 = null;
        RaycastHit2D[] hitarr2 = Physics2D.RaycastAll(transform.position, RayTypeVecList[ray2index], 3f);
        if (hitarr2.Length >= 2)
        {
            hitobj2 = hitarr2[1].transform.gameObject;
        }

        if(hitobj != null
            && hitobj2 != null)
        {
            if( mylayer == hitobj.layer 
                && mylayer == hitobj2.layer )
            {
                m_EraseList.Add(hitobj.transform);
                m_EraseList.Add(hitobj2.transform);
            }
        }

        for (int i = m_EraseList.Count - 1; i >= 0 ; i--)
        {
            if(m_EraseList[i] == transform)
                m_EraseList.RemoveAt(i);
        }
        

        ////if ( hitinfo )
        ////{
        ////    hitlayer = hitinfo.transform.gameObject.layer;
        ////}


        ////if ( , out hitinfo) )
        ////{
        ////    hitlayer = hitinfo.transform.gameObject.layer;
        ////}


        ////Ray ray2 = new Ray(transform.position, RayTypeVecList[ray2index] );
        ////if (Physics.Raycast(ray2, out hitinfo2))
        ////{
        ////    hitlayer2 = hitinfo2.transform.gameObject.layer;
        ////}


        //hitinfo2 = Physics2D.Raycast(transform.position, RayTypeVecList[ray2index], 3f);
        //if(hitinfo2)
        //{
        //    hitlayer2 = hitinfo2.transform.gameObject.layer;
        //}


        //if ((mylayer == hitlayer)
        //    && (mylayer == hitlayer2))
        //{
        //    m_EraseList.Add( hitinfo.transform );
        //    m_EraseList.Add(hitinfo2.transform);
        //    return true;
        //}

        return false;
    }



}
