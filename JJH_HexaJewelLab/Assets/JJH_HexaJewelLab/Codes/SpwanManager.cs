using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    public List<GameObject> prefabs = new List<GameObject>(); // 여러 프리팹을 저장할 리스트

    float PosX = -1.7125f;
    float PosY = 4f;
    bool InitialSetting = true;
    int Line = 5;
    int LineC = 11;

    public float WaitSec = 0.2f;

    private Rigidbody2D rb;

    void Start()
    {
        //SpawnPrefab();
        rb = GetComponent<Rigidbody2D>();

        StartCoroutine(CrateLineCortouine());
    }

    //void CreateBlock()
    //{
    //    PosX = -1.7125f;
    //    float tempposx = PosX;

    //    for (int i = 0; i < Line; i++)
    //    {
    //        SpawnPrefab(tempposx, PosY );
    //        tempposx += 0.3425f;
    //    }

    //}

    IEnumerator CrateLineCortouine()
    {
        if (InitialSetting)
        {
            for (int i = 0; i < 11; i++)
            {
                if (Line < LineC)
                {
                    Line++;
                }
                else
                {
                    Line--;
                    LineC--;
                }
                for (int j = 0; j < Line; j++)
                {
                    SpawnPrefab(PosX, PosY);
                    yield return new WaitForSeconds(WaitSec);
                }
                PosX += 0.3425f;
            }
            InitialSetting = false;
        }

    }


    protected List<MatchCheck> AllCheckList = new List<MatchCheck>();

    void SpawnPrefab(float p_x, float p_y)
    {
        if (prefabs.Count > 0)
        {
            int randomIndex = Random.Range(0, prefabs.Count); // 0부터 프리팹 개수 사이의 랜덤한 인덱스를 선택
            GameObject prefabToSpawn = prefabs[randomIndex]; // 선택한 인덱스의 프리팹을 가져옴

            Vector3 spawnPosition = new Vector3(p_x, p_y, 0); // 지정된 좌표로 설정
            var cloneobj = Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
            cloneobj.name = $"Block_[{p_x},{p_y}]";

            AllCheckList.Add( cloneobj.GetComponent<MatchCheck>() );
        }
        else
        {
            Debug.LogError("No prefabs assigned in the Inspector.");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 충돌 감지 시 물리 운동 멈추기
        if (rb != null)
        {
            rb.velocity = Vector2.zero;
            rb.angularVelocity = 0f;
            rb.isKinematic = true;
        }
    }


    private void Update()
    {
        //foreach (var item in AllCheckList)
        //{
        //    if (item.GetComponent<Rigidbody2D>().velocity.sqrMagnitude >= 0.01f)
        //        return;
            
        //}


    }
}
