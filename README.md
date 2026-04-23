# 📅 일정관리 프로그램 — Maver Calendar

<p align="center">
  <img src="https://img.shields.io/badge/C%23-239120?style=flat&logo=csharp&logoColor=white"/>
  <img src="https://img.shields.io/badge/WinForms-512BD4?style=flat&logo=.net&logoColor=white"/>
  <img src="https://img.shields.io/badge/MySQL-4479A1?style=flat&logo=mysql&logoColor=white"/>
</p>

<p align="center">
  C# WinForms + MySQL 기반 데스크톱 일정 관리 프로그램<br/>
  개인 일정 관리뿐만 아니라 <b>공유 캘린더 기반 협업 기능</b>까지 지원합니다.
</p>

---

## 📌 프로젝트 개요

WinForms와 MySQL을 기반으로, 누구나 쉽고 안정적으로 사용할 수 있는 일정 관리 프로그램입니다.  
개인 캘린더와 공유 캘린더를 통합하여 월별 일정을 한눈에 확인하고,  
반복 일정 및 협업 기능까지 지원하는 데스크톱 애플리케이션입니다.

---

## ⚙️ 주요 기능

| 기능 | 설명 |
|------|------|
| **캘린더 메인** | 계절별 테마 색상 자동 변경, 공휴일·오늘 날짜 표시 |
| **일정 CRUD** | 날짜 클릭으로 일정 등록, 상세보기·수정·삭제 지원 |
| **반복 일정** | 매주·매월·매년 단위 반복 설정 및 종료일 관리 |
| **연속 일정** | 동적 슬롯 할당으로 날짜 겹침 없이 멀티데이 일정 표시 |
| **카테고리 관리** | 개인/공용 캘린더 분리 |
| **공유 캘린더** | 그룹 기반 캘린더 생성, 멤버 초대 및 권한 관리 |
| **일정 검색** | 일정명 및 기간 기반 필터링 |
| **날씨 API** | OpenWeather API 연동으로 실시간 날씨 표시 |
| **소셜 로그인** | Google OAuth 2.0 기반 로그인 |
| **회원 관리** | 회원가입, 로그인, 비밀번호 찾기 |

---

## 🤝 공유 캘린더 시스템

사용자 간 협업을 위한 **그룹 기반 공유 캘린더 기능**을 구현했습니다.

- 개인 캘린더와 별도로 공용 캘린더 생성
- 사용자 초대를 통한 다중 사용자 일정 공유
- 관리자 / 일반 사용자 권한 분리
- 그룹 탈퇴 및 삭제 기능 제공
- TreeView UI 기반 개인/공용 캘린더 시각적 분리

### 🔧 구현 포인트
- `share_group`, `share_member` 테이블 기반 관계형 DB 설계
- 사용자 ID 기반 캘린더 접근 권한 제어
- 선택된 캘린더에 따라 일정 필터링 표시

---

## 🔄 시스템 흐름

### 로그인
> 랜딩 → 로그인 → 인증 → 메인 진입

### 일정 관리
> 날짜 선택 → 일정 등록 → DB 저장 → UI 반영 → 수정/삭제

### 공유 캘린더
> 캘린더 생성 → 멤버 초대 → 권한 설정 → 일정 공유

---

## 🖥️ 주요 화면

### 📆 메인 캘린더
계절별 테마 색상 적용 및 일정 시각화

![메인](docs/screen_main.png)

### 📝 일정 등록 및 상세보기
일정 추가, 수정, 삭제 기능 제공

![등록](docs/screen_add.png)
![상세](docs/screen_detail.png)

### 🔁 반복 일정
주/월/년 단위 반복 설정 지원

![반복](docs/screen_repeat.png)

### 👥 로그인 / 회원가입
계정 기반 사용자 관리

![로그인](docs/screen_login.png)
![회원가입](docs/screen_join.png)

---

## 📈 기대 효과

- **운영 효율성 향상** : MySQL 기반 안정적인 데이터 관리
- **사용자 편의성 개선** : 직관적인 UI 기반 일정 관리
- **협업 지원** : 공유 캘린더를 통한 팀 단위 일정 관리
- **확장성 확보** : 외부 API 및 소셜 로그인 연동

---

## 🎬 시연 영상

[![시연 영상](docs/thumbnail.png)](https://youtu.be/링크를_여기에_넣어주세요)

---

## 🛠️ 기술 스택

- **Language** : C#
- **Framework** : WinForms (.NET)
- **Database** : MySQL
- **IDE** : Visual Studio
- **Collaboration** : GitHub, Sourcetree

---

## 👥 Team

| 이름 | 역할 |
|------|------|
| 김영현 | 팀장 · 캘린더 UI 및 공유 캘린더 관리 |
| 강은비 | DB 설계 및 캘린더 구현 |
| **김수영** | **UI 디자인 · API 연동 · 반복 일정 로직 · 일정 시각화** |
| 이승환 | 일정 CRUD 및 기능 연동 |
| 정서현 | 로그인 및 회원 기능 |
