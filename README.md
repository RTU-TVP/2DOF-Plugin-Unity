# Platform-With-Steering-Wheel-Plugin

## Руль Logitech G29 и Коробка передач

[Документация](https://shutovks.notion.site/2DOF-8ffe2cc6af724077b89215dd924b8afa?pvs=4)

### Руководство по установке

* Импорт asset: Импортируйте необходимые файлы в ваш Unity проект.

* Установка пакета Input System: Откройте Package Manager, перейдите во вкладку Unity Registry, найдите Input System и установите его.

* Подключение к InputControllerReader: Создайте скрипт для обработки входных данных, создайте ссылку на экземпляр InputControllerReader, закрепите скрипт на игровом объекте и привяжите экземпляр.

* Пропишите логику обработки входных данных: В вашем скрипте напишите логику для обработки результатов ввода, используя события и методы InputControllerReader.

## Подвижная платформа 2DOF

[Документация](https://shutovks.notion.site/Logitech-G29-Driving-Force-Shifter-9a790d89fdbc43e5bf92de01b779f480?pvs=4)

### Руководство по установке подвижной платформы

* Импорт asset: Импортируйте необходимые файлы в ваш Unity проект.

* Настройка игрового объекта для считывания данных: Создайте/добавьте автомобиль на сцену, добавьте компонент Rigidbody, добавьте скрипт CarTelemetryHandler на игровой объект и подключите Transform и Rigidbody.
