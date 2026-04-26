# 📅 Maver Calendar — 일정관리 프로그램

<p align="center">
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white"/>
  <img src="https://img.shields.io/badge/WinForms-512BD4?style=for-the-badge&logo=.net&logoColor=white"/>
  <img src="https://img.shields.io/badge/MySQL-4479A1?style=for-the-badge&logo=mysql&logoColor=white"/>
  <img src="https://img.shields.io/badge/Visual%20Studio-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white"/>
</p>

<p align="center">
  <b>C# WinForms + MySQL 기반 데스크톱 일정 관리 프로그램</b><br/>
  개인 일정 관리부터 공유 캘린더, 반복 일정, 날씨 API, Google 연동까지 지원합니다.
</p>

---

## 📌 프로젝트 개요

**Maver Calendar**는 C# WinForms와 MySQL을 기반으로 제작한 데스크톱 일정 관리 프로그램입니다. 사용자는 개인 캘린더와 공유 캘린더를 통해 일정을 등록·수정·삭제할 수 있으며, 반복 일정, 연속 일정, 일정 검색, 날씨 확인, Google 연동 기능까지 사용할 수 있습니다.

특히 팀 단위 일정 공유를 위한 **공유 캘린더 시스템**과 날짜별 일정이 겹치지 않도록 표시되는 **일정 시각화 기능**을 중점적으로 구현했습니다.

---

## 🎬 시연 영상

<p align="center">
  <a href="demo/maver_calendar_demo.mp4">
    ▶️ 시연 영상 보기 (클릭하여 다운로드)
  </a>
</p>

---

## 📸 화면 구성

### 🌸 계절별 캘린더 테마

| Spring | Summer | Autumn | Winter |
|:------:|:------:|:------:|:------:|
| <img src="images/01_spring.png" width="220"/> | <img src="images/02_summer.png" width="220"/> | <img src="images/03_autumn.png" width="220"/> | <img src="images/04_winter.png" width="220"/> |

> 봄·여름·가을·겨울에 따라 캘린더 색상이 자동으로 변경됩니다.

---

### 📝 일정 관리

| 일정 등록 | 일정 상세 | 반복 일정 | 일정 삭제 |
|:---------:|:---------:|:---------:|:---------:|
| <img src="images/10_plan_add.png" width="220"/> | <img src="images/08_plandetail.png" width="220"/> | <img src="images/09_repeat.png" width="220"/> | <img src="images/12_delete.png" width="220"/> |

---

### 👥 공유 캘린더

| 공유 캘린더 생성 | 팀원 추가 | 공유 일정 표시 |
|:---------------:|:---------:|:-------------:|
| <img src="images/05_share_form.png" width="220"/> | <img src="images/06_team_add.png" width="220"/> | <img src="images/07_shard_plan.png" width="220"/> |

---

### 🔐 회원 기능 · 외부 연동

| 로그인 | 비밀번호 찾기 | 날씨 API | Google 연동 |
|:------:|:------------:|:--------:|:-----------:|
| <img src="images/13_login.png" width="220"/> | <img src="images/14_updatepassword.png" width="220"/> | <img src="images/15_weather.png" width="220"/> | <img src="images/18_google.png" width="220"/> |

---

### 📅 기타 기능

| 오늘 이동 | 공휴일 표시 | 일정 시각화 |
|:---------:|:-----------:|:-----------:|
| <img src="images/17_today.png" width="220"/> | <img src="images/16_holiday.png" width="220"/> | <img src="images/19_calendar.png" width="220"/> |

---

## ⚙️ 주요 기능

<table>
  <tr>
    <th width="50%">📆 캘린더 · 일정</th>
    <th width="50%">🤝 공유 · 연동</th>
  </tr>
  <tr>
    <td>
      ✅ 월별 캘린더에서 일정 한눈에 확인<br/>
      ✅ 날짜 클릭으로 일정 등록 · 수정 · 삭제<br/>
      ✅ 매일 / 매주 / 매월 / 매년 반복 일정 등록<br/>
      ✅ 여러 날짜에 걸친 연속 일정 시각적 표시<br/>
      ✅ 일정명 · 기간 기준 검색 기능<br/>
      ✅ 공휴일 및 주말 색상 구분<br/>
      ✅ 오늘 버튼으로 현재 날짜 빠른 이동<br/>
      ✅ 계절별 캘린더 테마 자동 변경
    </td>
    <td>
      ✅ 그룹 기반 공유 캘린더 생성 · 관리<br/>
      ✅ 멤버 초대 및 관리자/일반 권한 분리<br/>
      ✅ 개인 · 공용 캘린더 TreeView 분리<br/>
      ✅ 선택된 캘린더 기준 일정 필터링<br/>
      ✅ OpenWeather API 실시간 날씨 표시<br/>
      ✅ Google OAuth 기반 로그인 · 캘린더 연동<br/>
      ✅ 회원가입 · 로그인 · 비밀번호 찾기
    </td>
  </tr>
</table>

---

## 🤝 공유 캘린더 시스템

사용자 간 협업을 위해 **그룹 기반 공유 캘린더 기능**을 구현했습니다.

<table>
  <tr>
    <th>기능</th>
    <th>구현 포인트</th>
  </tr>
  <tr>
    <td>
      • 개인 / 공용 캘린더 분리<br/>
      • 공유 그룹 생성 및 멤버 초대<br/>
      • 관리자 / 일반 사용자 권한 분리<br/>
      • 그룹 탈퇴 및 삭제<br/>
      • 선택된 캘린더 기준 일정 필터링
    </td>
    <td>
      • <code>share_group</code>, <code>share_member</code> 테이블 기반 관계형 DB 설계<br/>
      • 로그인한 사용자 ID 기준 접근 가능 캘린더 조회<br/>
      • TreeView를 활용한 개인 / 공용 캘린더 UI 구성<br/>
      • 선택된 캘린더의 일정만 화면에 표시
    </td>
  </tr>
</table>

---

## 🔄 시스템 흐름

```
로그인
│
├─ 회원 인증
│
└─ 메인 캘린더 진입
   │
   ├─ 개인 일정 관리
   │   ├─ 날짜 선택 → 일정 등록
   │   ├─ 일정 수정 / 삭제
   │   └─ 반복 주기 · 종료일 설정 → 캘린더 자동 표시
   │
   ├─ 공유 캘린더
   │   ├─ 그룹 생성 → 멤버 초대
   │   ├─ 권한 관리 (관리자 / 일반)
   │   └─ 공유 일정 표시
   │
   └─ 외부 연동
       ├─ OpenWeather API (실시간 날씨)
       └─ Google OAuth (캘린더 연동)
```

---

## 🗂️ 프로젝트 구조

```
Maver_Calendar/
├── README.md
├── Maver_Calendar.sln
├── Project_Maver/
│   ├── Program.cs              # 진입점
│   ├── View/                   # UI 및 폼 (캘린더, 로그인, 공유 등)
│   ├── Common/                 # 비즈니스 로직 (DB, 날씨, 세션 등)
│   └── Resources/              # 리소스 및 에셋
├── images/                     # 스크린샷
└── demo/                       # 시연 영상
```

---

## 🛠️ 기술 스택

| 구분 | 기술 |
|------|------|
| **Language** | C# |
| **Framework** | .NET Framework / WinForms |
| **Database** | MySQL |
| **IDE** | Visual Studio 2022 |
| **API** | OpenWeather API, Google OAuth |
| **Collaboration** | GitHub, Sourcetree |

---

## 🚀 실행 방법

```bash
# 1. 저장소 클론
git clone https://github.com/your-username/Maver_Calendar.git

# 2. Visual Studio에서 Maver_Calendar.sln 열기

# 3. MySQL DB 연결 정보 설정 (Common/ 내 설정 파일)

# 4. F5 또는 Ctrl + F5로 실행
```

---

## 📈 기대 효과

<table>
  <tr>
    <th width="33%">🙋 사용자 편의성</th>
    <th width="33%">🤝 협업 효율성</th>
    <th width="33%">🚀 확장 가능성</th>
  </tr>
  <tr>
    <td>
      월별 캘린더에서 일정을 직관적으로 확인<br/>
      반복 · 연속 일정을 한 번에 관리<br/>
      오늘 날짜, 공휴일, 날씨를 함께 확인
    </td>
    <td>
      공유 캘린더로 팀원 간 일정 공유<br/>
      그룹별 일정 관리로 협업 효율 향상<br/>
      개인 · 공용 일정 분리 관리
    </td>
    <td>
      Google Calendar 연동 확장 가능<br/>
      알림 기능 및 통계 리포트 추가 가능<br/>
      모바일 · 웹 버전으로 확장 가능
    </td>
  </tr>
</table>

---

## 🔮 향후 개선 사항

<table>
  <tr>
    <th width="33%">📱 사용자 기능</th>
    <th width="33%">🤝 협업 · 연동</th>
    <th width="33%">🎨 UI · 고도화</th>
  </tr>
  <tr>
    <td>
      ☐ 일정 알림 기능 추가<br/>
      ☐ 모바일 캘린더 연동<br/>
      ☐ 월간 리포트 · 통계 기능
    </td>
    <td>
      ☐ Google Calendar 양방향 동기화<br/>
      ☐ 공유 캘린더 권한 세분화
    </td>
    <td>
      ☐ 일정 색상 커스터마이징 고도화<br/>
      ☐ 다크모드 지원
    </td>
  </tr>
</table>

---

## 👥 팀 구성

| 이름 | 역할 |
|------|------|
| 김영현 | 팀장 · 캘린더 UI 및 공유 캘린더 관리 |
| 강은비 | DB 설계 및 캘린더 구현 |
| **김수영** | **UI 디자인 · API 연동 · 연속 및 반복 일정 로직 · 일정 시각화** |
| 이승환 | 일정 CRUD 및 기능 연동 |
| 정서현 | 로그인 및 회원 기능 |

---

<p align="center">
  <sub>© 2025 Maver Calendar Team. All rights reserved.</sub>
</p>
