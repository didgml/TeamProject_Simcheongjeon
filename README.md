# TeamProject_Simcheongjeon

전반적인 코드 오류 재검토 및 수정,  플레이어 이동 제한, 배경음 및 효과음 설정, 스테이지 이동,  게임오버 구현

 주요 구현 기능
✅ 1. 게임 내 마우스 커서 제어 시스템 구현
실제 마우스 커서를 숨기고, 화면 내에 2D 커서를 따로 생성하여 플레이어가 직접 조작.

Camera.main.ScreenToWorldPoint()를 사용해 커서를 월드 좌표로 변환.

커서 위치가 화면 밖으로 나가지 않도록 Mathf.Clamp로 제한.

커서 방향 전환 기능 추가: 마우스 이동 방향에 따라 커서 스프라이트를 좌우 반전(localScale.x 변경).

✅ 2. 사운드 관리 시스템 구축
SoundManager를 통해 버튼 효과음과 배경음의 볼륨을 개별 조절 가능하도록 구조화.

AudioSource 컴포넌트를 활용하여 Play() 및 볼륨 제어 함수 구현.

필요에 따라 SFX 재생 (OnSfx() 메서드 호출) 기능 제공.

✅ 3. 씬 전환 시스템 구현
Seaweed와 충돌 시 "GameOver" 씬으로 전환.

"GameOver" 씬에서는 스페이스 키 입력 시 "SampleScene"으로 재시작.

SceneManager.LoadScene(string name)을 통해 유연한 씬 관리 가능.

하드코딩된 문자열 대신 SceneNames 클래스를 사용해 씬 이름 상수로 관리 → 유지보수성 향상.

✅ 4. 코드 품질 개선 및 유지보수성 향상
transform, AudioSource 등 Unity의 내장 클래스/변수와 혼동되는 이름들을 사용자 정의 이름으로 변경하여 충돌 방지.

Null 체크 및 예외 상황을 고려한 코드 안정성 향상 (if (audioSource != null) 등).

메서드 분리 및 주석을 통해 가독성을 높이고 기능별 책임 분리.

