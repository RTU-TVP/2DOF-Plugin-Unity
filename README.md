# 2DOF Plugin Unity

[Rus](README.md) | [ENG](README_ENG.md)

## Руль Logitech G29 и Коробка передач

### Руководство по установке

* Импорт asset: Импортируйте необходимые файлы в ваш Unity проект.

* Установка пакета Input System: Откройте Package Manager, перейдите во вкладку Unity Registry, найдите Input System и установите его.

* Подключение к InputControllerReader: Создайте скрипт для обработки входных данных, создайте ссылку на экземпляр InputControllerReader, закрепите скрипт на игровом объекте и привяжите экземпляр.

* Пропишите логику обработки входных данных: В вашем скрипте напишите логику для обработки результатов ввода, используя события и методы InputControllerReader.

### При проблемах в создаваемой сборки игры, что часть функционала руля не работает 

#### Внесите небольшое изменение в код:

В файле, расположенном по пути: "Library\PackageCache\com.unity.inputsystem@1.7.0\InputSystem\InputManager.cs"

В строке 2333, внутри блока catch, необходимо внести изменения:

Вместо `Debug.LogError("Could not create a device for '{description}' (exception: {exception})");`
использовать `Debug.Log("Could not create a device for '{description}' (exception: {exception})");`


## Подвижная платформа 2DOF

### Руководство по установке подвижной платформы

* Импорт asset: Импортируйте необходимые файлы в ваш Unity проект.

* Настройка игрового объекта для считывания данных: Создайте/добавьте автомобиль на сцену, добавьте компонент Rigidbody, добавьте скрипт CarTelemetryHandler на игровой объект и подключите Transform и Rigidbody.
