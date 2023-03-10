# 넥서스 디펜스 게임 만들기
- 작 성 자: 정진호 
- 제작기간: 23.02.19 ~ 23.03.05

## 개요
- 유저는 캐릭터를 상하로 움직이면서 막을 수 있는 몬스터를 막아 넥서스를 지킵니다.
- 캐릭터가 이기면 승리하여 레벨이 상승하고 넥서스를 수리합니다.
- 넥서스 내구도가 0이되거나 몬스터가 캐릭터보다 강하면 패배하게됩니다.

## 게임설명
1. 상하 방향키를 이용하여 자신의 캐릭터를 이동시킬 수 있습니다.
2. 캐릭터는 경기장을 벗어날 수 없습니다.
3. 자신보다 낮은 몬스터와 충돌하면 1~3 레벨 업 되고, 넥서스 내구도 +1이 수리 됩니다.
4. 자신보다 레벨 1이 낮은 몬스터와 충돌하면 각성하여 추가로 3~9 레벨 업 되고, 넥서스 내구도 +3이 수리 됩니다.
5. 자신과 동일한 몬스터와 충돌하면 -1 레벨 다운 됩니다.
6. 자신보다 높은 몬스터와 충돌하면 게임오버 됩니다.
7. 캐릭터 레벨이 올라갈 수록 가까운 곳에서 몬스터가 리젠됩니다.
8. 충돌하지 않은 몬스터는 넥서스 내구도를 -1 감소 시키고, 넥서스 내구도가 0이되면 게임오버 됩니다.
9. 넥서스와 충돌 없이 몬스터와 전투를 2번 이상 이어갈 경우 콤보가 됩니다.


## 게임제작순서
### 클래스 
1. 첫 화면 게임설명 게임시작 대기
- ![image](https://user-images.githubusercontent.com/123847819/224242638-01933daf-3fd9-4284-960f-e12f383c2b8d.png)

2. 게임판
- ![image](https://user-images.githubusercontent.com/123847819/224243213-5ebfc7e9-d865-4047-bd1c-cf38646b23a9.png)

3. 몬스터리젠
- ![image](https://user-images.githubusercontent.com/123847819/224243326-1c9b78a6-06f8-4a64-ace4-ed40feeae600.png)

4. 캐릭터 레벨에 따른 몬스터 리젠 위치를 앞으로 이동
- ![image](https://user-images.githubusercontent.com/123847819/224244811-d9e5e8c1-28a2-4658-b559-8377b235913f.png)

5. 캐릭터 조작
- ![image](https://user-images.githubusercontent.com/123847819/224244343-91751fbb-7ded-4833-b6da-478e454d3c6b.png)

6. 결과창
- ![image](https://user-images.githubusercontent.com/123847819/224244461-08e830bd-ac76-4ea6-a67f-054468254f99.png)

### 메인코드
1. 몬스터가 넥서스 공격 및 몬스터 리젠
- ![image](https://user-images.githubusercontent.com/123847819/224245979-bb804c42-b3cd-428f-8131-8a87ff3ce460.png)

2. 몬스터 리젠시 겹치지 않도록 처리
- ![image](https://user-images.githubusercontent.com/123847819/224246154-b433ee9a-e294-4fd8-9bd1-cd2c7408d3d8.png)

3. 충돌 체크 캐릭터 승리와 각성
- ![image](https://user-images.githubusercontent.com/123847819/224246398-2fa2439c-0115-4367-897b-b034e32b55b4.png)


3. 무승부 및 캐릭터 패배
- ![image](https://user-images.githubusercontent.com/123847819/224246569-56778732-326b-4e0c-bd5e-a7d6e2e6d179.png)

4. 몬스터 좌측으로 이동
- ![image](https://user-images.githubusercontent.com/123847819/224246604-7bad4a5d-2d6f-4b12-b7df-5d5b854ef420.png)

5. 넥서스 파괴 체크
- ![image](https://user-images.githubusercontent.com/123847819/224246666-fd4a83d6-0fc5-42da-a4ff-d44827aad0b1.png)

6. 게임 다시하기 처리
- ![image](https://user-images.githubusercontent.com/123847819/224247793-bf62a5af-5ed9-4b6e-99a2-9bf7eacbc371.png)

## 게임동영상
- https://user-images.githubusercontent.com/123847819/224244683-03ea0c6a-8ed0-41eb-a8fd-1fa92eb7a330.mp4

## 제작과정 리뷰
1. goto문을 사용하여 게임 다시하기를 만들었었는데 강사님이 절대 사용하지 말라고 하여 while문으로 변경
- goto문을 사용하면 안되는 이유는 아직 잘 모르겠습니다.
2. 몬스터 5마리를 따로 제작했다가 for문을 사용하여 코드를 정리
3. 클래스 없이 모든 main에 모든 내용을 담았다가 class로 정리
- gameinfo.cs : 게임설명 및 시작대기
- gameGroundUI.cs : 게임판 그리기
- gameOverUI.cs : 게임종료 정리
- monsterRegen.cs : 몬스터 리젠 처리
- CharacterDeadMotion.cs : 캐릭터 사망시 넥서스쪽으로 날아가는 모션
- Movement.cs : 캐릭터 이동 처리
- NexusCollapsingMotion.cs : 넥서스 붕괴되는 처리
4. 기본 게임을 제작하면서 밸런스와 폴리싱을 했습니다.
- 캐릭터가 경기장을 벗어나면 게임 오버처리했다가 경기장을 벗어나지 못하도록 수정
- 자신보다 1낮은 몬스터와 충돌하면 각성하여 추가 레벨업을 하도록 수정
- 캐릭터가 성장함에 따라 난이도를 높이기 위해 몬스터를 점점 가까운 곳에서 리젠되도록 수정
- 몬스터에 속도 변화를 주려고 작업했으나 게임이 난잡해서 롤빽처리
- 넥서스를 추가하여 몬스터를 많이 놓치면 넥서스가 파괴 되도록 수정
- 몬스터 리젠시 겹치지 않도록 수정
- 캐릭터 사망시 날아가는 모션 및 넥서스 붕괴 모션 추가
- 넥서스가 공격받지 않고 캐릭터와 충돌하여 이기거나 비기면 콤보가 되도록 수정
5. 다시 시작할때 입력이 원활하게 되지 않는 점을 발견하였으나 아직 수정하지 못했습니다.

이상입니다.


