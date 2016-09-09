# Unity3D-WebSocket-Client
## Eng
This is a simple application for WS demonstartion. It was created only for special server. So after understanding basics you can change it for your goals. It will be easy, I guarantee!
- Unity version: 5.4.0f3
- WebSockets: https://www.assetstore.unity3d.com/en/#!/content/38367
- Server is written via Scala. Sources you can find here: [github.com/DarkDesire/websocket-akka-http](https://github.com/DarkDesire/websocket-akka-http). For start project **you should have installed last Java Runtime Environment**. Then open **cmd**, change dir to desirable folder, and put **java -jar WebSocketServer-assembly-1.0.jar**

i won't continue this project because i created it only for testing socket server, so 

### Exercises for you! 
1. Implement FSM for changing UI states. Remove ui logic from WebSocketHandler.
2. Fix problem in WS library, which says that you connected even uri is wrong.
3. Text area field has problem. It doesn't support scrolling. So, fix it!
4. Imagine any more ....

## Rus
Простое клиентское приложение для демонстрации WebSocketServera. Оно предназначается для специального сервера (специфичный хардкодный путь). После понимание функционирования можно легко заменить путь и использовать уже в своих целях. Это сделать достаточно легко, я гарантирую!
- Unity version: 5.4.0f3
- WebSockets: https://www.assetstore.unity3d.com/en/#!/content/38367
- Сервер написан на Scala. Исходники сервера можно найти тут: [github.com/DarkDesire/websocket-akka-http](https://github.com/DarkDesire/websocket-akka-http). Для запуска проекта **вы должны иметь установленную последнюю Java Runtime Environment**. Идем в поиск, вбиваем **cmd**, меняем директорую на ту, где лежит сервер, и пишем  **java -jar WebSocketServer-assembly-1.0.jar**

я не буду продолжать этот проект, т.к. он был создан для тестирования сервера, так что

### Задания для тебя! 
1. Добавить конечный автомат для UI. И соответственно удалить всю view логику из WebSocketHandler.
2. Решить проблему с WS библиотекой, которая пишет, что вы присоединены даже, если на самом деле путь неправильный. Видимо, в библиотеке тупо проверяется на регулярку подходит ли путь или нет.
3. Проблема с текстовым полем. По умолчанию он не поддерживает скроллинг и нужны шаманства. Реализуй это!
4. Придумайте еще больше заданий...

## Гифка для наглядности / Gif for clarity
![1](http://storage9.static.itmages.ru/i/16/0909/h_1473463001_4820244_0e5233ffdc.gif)
