#Requirements
- .NET 7.0
- Java (for plant uml export)
- plantuml.jar (for plant uml export)
	- Download: take GPL compiled jar [PlantUML Downloads and Source Code](https://plantuml.com/download)
	- Help: [Command line](https://plantuml.com/command-line)

# Run
- Compile target solution before run. Without that some wierd things happen. Roslyn can't find IConsumer interface symbol
- Compile tool
- Configure run.cmd
- Run run.cmd


Надо восстанавливать из скомплированного кода

#Todo
- Integration events diagram. Разделить интеграционные эвенты и request/response на разные диаграммы
- Plantuml скачивать svg
- Добавить для каждого компонента ссылку src на исходник в гитхабе
- Отрендерить html
- Plantuml при наведении мыши менять толщину или цвет линии соединяющей компоненты
- Использовать короткое имя для компонента, при этом выводить длинное имя каким то образом
- Добавить футер с описанием