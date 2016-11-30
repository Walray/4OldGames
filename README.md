# 4OldGames
[제1회 동국 SW 공모대전] 디비디비딥 - 추억의 고전게임 4선 

팀 : 디비디비딥
구성원 : 김일엽, 정초록, 김서빈, 임윤미

모든 소스폴더는 8Old_Games 디렉토리 밑에 있습니다.
해당 디렉토리 하부에는 두 디렉토리가 존재하는데 다음과 같습니다.
_8Old_Games : 프로그램 소스코드
ㅣ
ㅣ-- Program.cs : 프로그램의 진입점입니다.
ㅣ-- MainSelector.cs : 네 개의 게임을 enum Selector로 관리하는 통합 클래스입니다.
ㅣ-- Clock.cs : 시간 표기를 위한 보조 클래스입니다.
ㅣ-- Games
     ㅣ      
     ㅣ-- Frogger : 프로거 게임을 관리하는 프로그램 폴더입니다.
         ㅣ-- Frogger.cs : 프로거 게임을 enum State로 관리하는 통합 클래스입니다.
         ㅣ-- Map.cs : 프로거의 맵 데이터를 관리하는 클래스입니다.
         ㅣ-- Object : Turtle, Car, Frog, LastCroc, Log, Frog 등의 오브젝트 클래스들에 대한 폴더입니다.
         ㅣ-- Sequence : 게임의 시퀀스(화면진행)에 대한 클래스들의 폴더입니다.(Start->Load->Play->Menu->Fail->Clear)
     ㅣ-- MineSweeper : 지뢰찾기 게임을 관리하는 프로그램 폴더입니다.
         ㅣ-- MineSweeper.cs : 지뢰찾기 게임을 enum State로 관리하는 통합 클래스입니다.
         ㅣ-- Grid.cs : 지뢰찾기 각 칸의 정보에 대한 클래스입니다.
         ㅣ-- Sequence : 게임의 시퀀스(화면진행)에 대한 클래스들의 폴더입니다.(Start->Selection->Play->Menu)
     ㅣ-- Sudoku : 스도쿠 게임을 관리하는 프로그램 폴더입니다.
         ㅣ-- Sudoku.cs : 스도쿠 게임을 enum State로 관리하는 통합 클래스입니다.
         ㅣ-- MapData.cs : 스도쿠 맵(Easy-Normal-Hard-Extreme당 다섯 스테이지)에 대한 클래스에 대한 폴더입니다.
         ㅣ-- Cell.cs : 스도쿠 각 칸에 정보에 대한 클래스입니다.
         ㅣ-- Sequence : 게임의 시퀀스(화면진행)에 대한 클래스들의 폴더입니다.(Start->Selection->Play->Menu->Load)
     ㅣ-- TicTacToe : 틱택토 게임을 관리하는 프로그램 폴더입니다.
         ㅣ-- TicTacToe.cs : 틱택토 게임을 enum State로 관리하는 통합 클래스입니다.
         ㅣ-- Sequence : 게임의 시퀀스(화면진행)에 대한 클래스들의 폴더입니다.(Start->Selection->Play1(Play2)->Menu1(Menu2))
 
_8Old_GamesContent : 프로그램 리소스(폰트, 그림 등)
