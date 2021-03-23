# StudyDesktopApp
C# 데스크톱 앱 개발 학습 리포지터리(WPF도 추가해라!@), Mahappdesign도 추가
--------------
## StudyDesktopApp에 대하여!
~~~
해당 챕터는 윈폼과 WPF를 이용한 것이다. object에 pix 태그를 달아서 알아보기 쉽게 표현해놓았지만
직관적이지 않다!
따라서 비주얼적으로 이를 관찰해야 학습에 도움이 될 것이다. 
내 생각엔 솔루션을 각각 켜서 해당 어플을 실행시켜보는 것이 복습에 도움이 될 거 같다!
~~~

~~~
현재 내가 구현한 솔루션은 프로그램의 기능적인 부분들이다. 비즈니스 로직이 없다. 비즈니스 로직이
없는 데도 구현하는 데 16시간정도 소요되었다. 또한 난잡한 메서드를 internal 접근 생성자를 통해
Secure coding하고, 중복되는 연산을 메서드화 해서 캡슐화하는 것도 따로 시간이 소요되었다.
현재는 코드를 읽으면서 그 내용을 이해할 수 있는 수준까지는 된다.

그러나 알고리즘을 통해 직접적으로 코딩하는 것은 고급 수준의 프로그래머가 가능하다는 것을 
깨닫게 되었다. 

Inflearn을 통해 블록체인이라던가, 다른 언어에 대한 이해 습득도 필요할 것으로 생각되며, 특히
코딩테스트를 통해 알고리즘을 습득해서 좀 더 양질의 코딩을 할 수 있어야 한다는 것을 깨닫게 되었다.

SQL 서버와의 연결, 서버의 정보를 읽어 오고, 호출하고, 반환하는 것이 가장 중요하든 것을 알게 되었다.
내가 배운 것을 총합적으로 엮어놓은 것이 BookRentalShop인데, 요것도 오류가 많이 발생한다.

오류가 중요한 것이 아니라 왜 발생했느냐가 더 중요하다. 어차피 지금은 배우는 시기고 책임지는 프로젝트도
아니기 때문이다. 따라서 오류를 디버깅잡고 시스템이 참조를 따라가는 것을 읽는 기능을 발달시키는 것이
좋다고 판단한다.

대체로 private void는 메서드 기능을 생성할 때, 쓰는 접근생성자이며 public을 쓰지 않는 이유는
다른 namespace에서 같은 커스텀 키워드를 생성하기 위함이다. 같은 커스텀 키워드일 수록, DB연동이 개발하는
입장에서 편하기 때문이다.
public을 쓰면 해당 키워드를 한 솔루션안에서 단 한번밖에 쓸 수 없는 단점이 있다.

실무에서 빠르게 코드를 읽고 해당 기업의 코딩 로직을 빠르게 잡을 수 있는 역량이 중요하지, 현재 시점에서
기능 구현이 중요한 것은 아니라고 생각한다.

쿼리문을 C#에서 sql연결을 통해 문자열로 날리는 것이기 때문에 오류가 발생할 수 있으므로 디버깅 창을 통해서
계속 확인해보는 것이 중요하다.

그리고 프로젝트 복사 붙여넣기로 재활용 시에 바꿔줘야 할 부분은 cs의 파티션 2부분과 디자이너 부분의
참조 부분 1개로 총 3개의 파티션만 고쳐주면 된다.

sql 상에서 테이블 스크립팅을 이용하는 것이 오탈자를 줄일 수 있어서 좋다.
그리고 코딩을 할 때, 화면을 넓게 쓰는 것이 유리하기 때문에 필요한 도구창만 활성시켜서 쓰는 것이 편하다.

실무역량을 쌓기 위해서는 C#200제를 다 풀어볼 필요가 있다고 생각함.
Metro를 통해서 UI를 좀 더 친숙하게 꾸밀 수 있다.
~~~

~~~
라즈베리파이는 동적 통신으로 데이터를 보내서 해결한다. 데이터를 모아서 DB로 모은다. clr은 dll을 참조한다는 의미이다.
DLL
[ dynamic linking library ]

OS/2, 윈도즈 등의 운영 체계(OS) 본래 기능으로, 소프트웨어의 루틴을 몇 개의 파일로 나누어 디스크에 두고 필요한 것만을 실행 메모리에 실어서 사용하기 위한 파일. DLL로 사용되는 파일은 확장자가 ‘dll’로 되어 있기 때문에 ‘DLL 파일’이라고 부른다. DLL의 장점은 루틴을 공통으로 사용하는 것이다. 루틴의 함수 집단을 자료집이라고 하는데, 보통 실행 파일을 작성할 때 자료집을 포함해서 컴파일하는 경우가 많다. 그러나 이 방법은 동일 루틴을 다수의 실행 파일이 갖게 되어 비효율적이다. DLL은 다수의 실행 파일에 공유될 수 있기 때문에 디스크 용량이나 메모리를 절약할 수 있다. 또 프로그램을 수정하려는 경우, DLL 파일만을 수정함으로써 완료되는 경우도 있다. 윈도즈 등에서는 OS 기능은 물론 DLL을 애플리케이션과 공유할 수도 있으나, DLL 파일 등의 애플리케이션이 공유되고 있는지는 이용자 수준에서는 판단하기가 어렵다.
[네이버 지식백과] DLL [dynamic linking library] (IT용어사전, 한국정보통신기술협회)
+= 텝을 눌러서 메서드를 만들어야 참조가 올바르게 된다.

트래픽은 네트워크를 왔다갔따하는 것을 일컫는 것이다. Nlog를 써야 유지보수가 쉬워진다. 로그가 가장 중요하다.
~~~
---------------
## 목차
1. ![ListViewApp](https://github.com/ochestra365/StudyDesktopApp/tree/main/ListViewApp)
2. ![RestaurantSelApp](https://github.com/ochestra365/StudyDesktopApp/tree/main/RestaurantSelApp)
3. ![TimerApp](https://github.com/ochestra365/StudyDesktopApp/tree/main/TimerApp)
4. ![TravelWishApp](https://github.com/ochestra365/StudyDesktopApp/tree/main/TravelWishApp)
5. ![WPFApp](https://github.com/ochestra365/StudyDesktopApp/tree/main/WPFApp)
6. ![WinformApp](https://github.com/ochestra365/StudyDesktopApp/tree/main/WinformApp)
7. ![WPFApp](https://github.com/ochestra365/StudyDesktopApp/tree/main/WPFApp)<br><br>
소스코드는 해당 목차에서 확인할 수 있다!!
-------------
###ListViewApp 구동화면!<br>
리스트 화면이다.<br>
<img src="https://github.com/ochestra365/StudyDesktopApp/blob/main/ListViewApp/Images/%EB%A6%AC%EC%8A%A4%ED%8A%B8.png" width="40%" height="30%" ><br>
자세히 화면이다.<br>
<img src="https://github.com/ochestra365/StudyDesktopApp/blob/main/ListViewApp/Images/%EC%9E%90%EC%84%B8%ED%9E%88.png" width="40%" height="30%" ><br>
작은 아이콘 화면이다.<br>
<img src="https://github.com/ochestra365/StudyDesktopApp/blob/main/ListViewApp/Images/%EC%9E%91%EC%9D%80%EC%95%84%EC%9D%B4%EC%BD%98.png" width="40%" height="30%" ><br>
큰 아이콘 화면이다.<br>
<img src="https://github.com/ochestra365/StudyDesktopApp/blob/main/ListViewApp/Images/%ED%81%B0%20%EC%95%84%EC%9D%B4%EC%BD%98.png" width="40%" height="30%" ><br>

