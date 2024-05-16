<br/>
<br/>

# <p align="center"> **W4_PartyRoom**  </p>

##### <p align="center"> <b> 내일 배움 캠프 4주차 개인프로젝트 </b>

<br/>
<br/>

<br/>

### ✨자기소개

- 정승연 
- A3: 삼조미포함 팀장
- 블로그: https://better-constructor123.tistory.com

---
```
asdf
```

### ✨프로젝트  

 `Info` **Unity를 활용한 메타버스 공간 만들기**

 `Stack` C#, Unity-2022.3.17f, Visual Studio2022-17.9.6   

 `Made by` **정승연** 
 
`Team Notion`  **https://www.notion.so/teamsparta/79b1b72369d8460a94c0b6b4ee5c9fd1** 

---

### ✨깃 컨벤션
아직 익숙하지 않아 조금 늦게 시작했다.

- commit 규칙
    - init: 최초 커밋: Unity 프로젝트 생성
    - feat: 기능 추가
    - refactor: 기능 개선
    - add: 에셋, .cs 등 파일 추가
    - move: 단순 파일 이동
    - remove: 파일 삭제
    - art: UI 개선
    - fix: 버그 수정
    - chore: 기타 잡일
    - docs: 리드미 수정(다른 문서가 없어서...?)
 
- branch
    - dev는 따로 만들지 않음. (규모 작음 + 1인 개발이라 conflict날 일이 없음.)
    - branch는 기능마다 1개씩.
        - 기능 추가 시: feat/(기능 이름)
        - UI 추가 시: UI/(추가하는 UI)

---

### ✨ 이행한 요구사항 소개

- **필수요구사항**
    - 캐릭터 만들기
        - 외부 그림파일을 추가하여 2D 캐릭터를 추가합니다.
            - 유니티 입문 학습 과정에서 사용한 이미지
            - AssetStore 에서 다운 받은 이미지 등

    - 캐릭터 이동
        - 키보드 A/W/S/D 를 이용하여 캐릭터가 움직입니다.
        - 캐릭터는 마우스 방향을 바라봅니다. (좌/우)
         
    - 방 만들기
        - 타일맵을 이용하여 맵을 만듭니다.
            - 유니티 입문 학습 과정에서 사용한 이미지
            - AssetStore 에서 다운 받은 이미지 등
        - 콜라이더를 이용해 벽을 넘어가지 못합니다.
          
    - 카메라 따라가기
        - 카메라는 움직임에 따라 캐릭터를 따라갑니다.

    - 캐릭터 애니메이션 추가
        - 실행하면 캐릭터가 애니메이션을 반복합니다.
        - 가만히 서있을때와 움직일때 애니메이션을 구분하지는 않아도 됩니다.
          
    - 이름 입력 시스템
        - 실행시 글자를 입력을 받을 수 있는 UI 를 만듭니다.
            - 2~10 글자 사이
                - 아니라면 Join 버튼이 눌리지 않습니다.
        - Join 을 누르면 맵으로 이동하여 캐릭터 위에 이름표가 나타납니다.
            - 이름표는 캐릭터가 움직이면 따라 다닙니다.
              
    - 캐릭터 선택 시스템
       - 맵으로 들어가기 전 캐릭터가 표시되는 UI 가 나타납니다.
        - 캐릭터를 클릭하면 캐릭터 선택 팝업이 나타납니다.
        - 캐릭터를 선택하면 팝업이 닫힙니다.
        - 선택했던 캐릭터가 표시됩니다.

          
- **선택요구사항**
    - 시간 표시 (난이도 - ★★☆☆☆)
      - 왼쪽 상단에 현재 시간을 표시하는 UI 를 만듭니다.
        
    - 인게임 이름 바꾸기 (난이도 - ★★★☆☆)
       - 하단 메뉴 오른쪽에 이름 바꾸기 버튼을 만듭니다.
            - 입력하면 캐릭터 위쪽 이름과 오른쪽 메뉴 이름이 변경됩니다.
              
    - 참석 인원 UI (난이도 - ★★★☆☆)
        - UI 는 캐릭터가 움직여도 화면에 고정됩니다.
        - 화면 오른쪽에 현재 맵에 있는 사람의 목록을 보여줍니다.
            - NPC 를 더 추가한다면 이 목록에 이름이 보이도록 해보세요.
            - x 버튼을 누르면 UI 가 꺼집니다.
        - 화면 하단에는 파란색 UI 가 있습니다.
            - 참석인원 아래에 버튼을 부르면 목록이 다시 생깁니다.
              
    - 인게임 캐릭터 선택 (난이도 - ★★★★☆)
      - 하단 메뉴 오른쪽에 캐릭터 선택 버튼을 만듭니다.
            - 캐릭터 선택시 게임화면의 캐릭터가 바로 반영 됩니다.
        
    - NPC 대화 (난이도 - ★★★★★)
        - 튜터에게 가까이 가면 대화 걸기 버튼이 생깁니다.
        - 튜터에게 멀어지면 다시 버튼이 사라집니다.
        - 버튼을 누른다면 대화가 시작됩니다.

--- 
