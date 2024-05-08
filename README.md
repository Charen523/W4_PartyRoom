<br/>
<br/>

# <p align="center"> ** W4_PartyRoom **  </p>

##### <p align="center"> <b> _with 내일 배움 캠프 4주차 개인프로젝트 </b>

<br/>
<br/>

<br/>

## ✨자기소개
| 정승연 | 팀원 |https://better-constructor123.tistory.com

---

## ✨프로젝트  

 `Info` **C#을 이용하여 만든 턴제 Text RPG**

 `Stack` **C#**   

 `Made by` **A-15조** 
 
`Team Notion`  **[SA 페이지](https://www.notion.so/teamsparta/15-1c24062ca6b64910843483d1ec282867)** 

---

## ✨깃 컨벤션

---

## ✨ 이행한 요구사항 소개
- **필수요구사항**
    - 1. 캐릭터 만들기
        
        ![Untitled](https://prod-files-secure.s3.us-west-2.amazonaws.com/83c75a39-3aba-4ba4-a792-7aefe4b07895/2294a4a1-ac75-4bd4-a5fb-63dff4ee0d79/Untitled.png)
        
        - 외부 그림파일을 추가하여 2D 캐릭터를 추가합니다.
            - 유니티 입문 학습 과정에서 사용한 이미지
            - AssetStore 에서 다운 받은 이미지 등
            - 예제에 사용된 캐릭터 에셋 - [Link](https://assetstore.unity.com/packages/2d/characters/2d-character-sprite-animation-penguin-236747)
    - 2. 캐릭터 이동
        
        ![CleanShot 2023-09-01 at 02.59.31.gif](https://prod-files-secure.s3.us-west-2.amazonaws.com/83c75a39-3aba-4ba4-a792-7aefe4b07895/0f59366f-c57c-4c1e-ab24-ce5127be12eb/CleanShot_2023-09-01_at_02.59.31.gif)
        
        - 키보드 A/W/S/D 를 이용하여 캐릭터가 움직입니다.
        - 캐릭터는 마우스 방향을 바라봅니다. (좌/우)
    - 3. 방 만들기
        
        ![Untitled](https://prod-files-secure.s3.us-west-2.amazonaws.com/83c75a39-3aba-4ba4-a792-7aefe4b07895/8393e60d-e49a-43ea-8bee-7325b6cf455e/Untitled.png)
        
        - 타일맵을 이용하여 맵을 만듭니다.
            - 유니티 입문 학습 과정에서 사용한 이미지
            - AssetStore 에서 다운 받은 이미지 등
            - 예제에 사용된 배경 에셋 - [Link](https://assetstore.unity.com/packages/2d/environments/rogue-fantasy-castle-164725)
        - 콜라이더를 이용해 벽을 넘어가지 못합니다.
    - 4. 카메라 따라가기
        
        ![CleanShot 2023-09-01 at 03.08.14.gif](https://prod-files-secure.s3.us-west-2.amazonaws.com/83c75a39-3aba-4ba4-a792-7aefe4b07895/0a25641d-9e8f-4048-86b7-ba636a670e5c/CleanShot_2023-09-01_at_03.08.14.gif)
        
        - 카메라는 움직임에 따라 캐릭터를 따라갑니다.
    - 5. 캐릭터 애니메이션 추가
        
        ![CleanShot 2023-09-01 at 03.12.49.gif](https://prod-files-secure.s3.us-west-2.amazonaws.com/83c75a39-3aba-4ba4-a792-7aefe4b07895/a2a5b83f-77a8-49e9-9029-f5c3faa8f9df/CleanShot_2023-09-01_at_03.12.49.gif)
        
        - 실행하면 캐릭터가 애니메이션을 반복합니다.
        - 가만히 서있을때와 움직일때 애니메이션을 구분하지는 않아도 됩니다.
    - 6. 이름 입력 시스템
        
        ![CleanShot 2023-09-01 at 03.38.46.gif](https://prod-files-secure.s3.us-west-2.amazonaws.com/83c75a39-3aba-4ba4-a792-7aefe4b07895/fada223d-cf7a-4f48-9a94-bfa2ab44f670/CleanShot_2023-09-01_at_03.38.46.gif)
        
        - 실행시 글자를 입력을 받을 수 있는 UI 를 만듭니다.
            - 2~10 글자 사이
                - 아니라면 Join 버튼이 눌리지 않습니다.
        - Join 을 누르면 맵으로 이동하여 캐릭터 위에 이름표가 나타납니다.
            - 이름표는 캐릭터가 움직이면 따라 다닙니다.
    - 7. 캐릭터 선택 시스템
        
        ![CleanShot 2023-09-01 at 03.58.29.gif](https://prod-files-secure.s3.us-west-2.amazonaws.com/83c75a39-3aba-4ba4-a792-7aefe4b07895/45b4e1ba-5925-42f3-b51a-b4dd99048095/CleanShot_2023-09-01_at_03.58.29.gif)
        
        - 맵으로 들어가기 전 캐릭터가 표시되는 UI 가 나타납니다.
        - 캐릭터를 클릭하면 캐릭터 선택 팝업이 나타납니다.
        - 캐릭터를 선택하면 팝업이 닫힙니다.
        - 선택했던 캐릭터가 표시됩니다.
- **선택요구사항**
    - 1. 시간 표시 (난이도 - ★★☆☆☆)
        
        ![CleanShot 2023-09-01 at 04.40.28@2x.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/83c75a39-3aba-4ba4-a792-7aefe4b07895/2baeb606-bc68-4ea9-91c5-1f3b2ae79307/CleanShot_2023-09-01_at_04.40.282x.png)
        
        - 왼쪽 상단에 현재 시간을 표시하는 UI 를 만듭니다.
    - 2. 인게임 이름 바꾸기 (난이도 - ★★★☆☆)
        
        ![CleanShot 2023-09-01 at 04.36.00.gif](https://prod-files-secure.s3.us-west-2.amazonaws.com/83c75a39-3aba-4ba4-a792-7aefe4b07895/cba9dc8f-76fa-4853-b00b-336fa46bfff2/CleanShot_2023-09-01_at_04.36.00.gif)
        
        - 하단 메뉴 오른쪽에 이름 바꾸기 버튼을 만듭니다.
            - 입력하면 캐릭터 위쪽 이름과 오른쪽 메뉴 이름이 변경됩니다.
    - 3. 참석 인원 UI (난이도 - ★★★☆☆)
        
        ![CleanShot 2023-09-01 at 04.32.22.gif](https://prod-files-secure.s3.us-west-2.amazonaws.com/83c75a39-3aba-4ba4-a792-7aefe4b07895/73614b35-8386-4d5a-9a66-3a8b4c03263c/CleanShot_2023-09-01_at_04.32.22.gif)
        
        - UI 는 캐릭터가 움직여도 화면에 고정됩니다.
        - 화면 오른쪽에 현재 맵에 있는 사람의 목록을 보여줍니다.
            - 예제에서는 2명 있습니다.
                - 염예찬 튜터
                - 학생 - Chad
            - NPC 를 더 추가한다면 이 목록에 이름이 보이도록 해보세요.
            - x 버튼을 누르면 UI 가 꺼집니다.
        - 화면 하단에는 파란색 UI 가 있습니다.
            - 참석인원 아래에 버튼을 부르면 목록이 다시 생깁니다.
    - 4. 인게임 캐릭터 선택 (난이도 - ★★★★☆)
        
        ![CleanShot 2023-09-01 at 04.33.15.gif](https://prod-files-secure.s3.us-west-2.amazonaws.com/83c75a39-3aba-4ba4-a792-7aefe4b07895/e9d4ec9b-e4ba-4525-8e60-b7ee8a71cd42/CleanShot_2023-09-01_at_04.33.15.gif)
        
        - 하단 메뉴 오른쪽에 캐릭터 선택 버튼을 만듭니다.
            - 캐릭터 선택시 게임화면의 캐릭터가 바로 반영 됩니다.
    - 5. NPC 대화 (난이도 - ★★★★★)
        
        ![CleanShot 2023-09-01 at 04.58.54.gif](https://prod-files-secure.s3.us-west-2.amazonaws.com/83c75a39-3aba-4ba4-a792-7aefe4b07895/60bbbd6d-d4bb-4f92-b463-ebc69cb9b067/CleanShot_2023-09-01_at_04.58.54.gif)
        
        - 튜터에게 가까이 가면 대화 걸기 버튼이 생깁니다.
        - 튜터에게 멀어지면 다시 버튼이 사라집니다.
        - 버튼을 누른다면 대화가 시작됩니다.

--- 

## ✨ 추가 구현 사
