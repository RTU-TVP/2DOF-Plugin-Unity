# 2DOF Plugin Unity

[Rus](README.md) | [ENG](README.en.md)

## Руль Logitech G29 и Коробка передач

### Руководство по установке

Вы можете установить плагины любым из следующих способов

* Скачать unitypackage:
  * Скачать одну из публичных версий плагина, которые можно найти в разделе [Releases](https://github.com/RTU-TVP/2DOF-Plugin-Unity/releases).
  * Импортировать unitypackage в ваш проект Unity.

* Склонировать репозиторий:
  * Склонировать репозиторий в ваш проект Unity.
  * Перейти в папку "Plugins/LogitechG29" и импортировать плагины в ваш проект Unity.

* С помощью Package Manager (для Unity 2019.3 и выше):
  * Открыть Package Manager в Unity.
  * Нажать на кнопку + в верхнем левом углу окна Package Manager.
  * Выбрать Add package from git URL.
  * Ввести ссылку на репозиторий плагина: `https://github.com/RTU-TVP/2DOF-Plugin-Unity.git?path=src/2DOF-Plugin-Unity/Assets/Plugins/LogitechG29`.

### Использование плагина

1. Установка пакета Input System.
2. Подключение к InputControllerReader: Создайте скрипт для обработки входных данных, создайте ссылку на экземпляр InputControllerReader, закрепите скрипт на игровом объекте и привяжите экземпляр.
3. Пропишите логику обработки входных данных: В вашем скрипте напишите логику для обработки результатов ввода, используя события и методы InputControllerReader.

### При проблемах в создаваемой сборки игры, что часть функционала руля не работает

#### Внесите небольшое изменение в код

В файле, расположенном по пути: `Library\PackageCache\com.unity.inputsystem@1.7.0\InputSystem\InputManager.cs`

В строке 2333, внутри блока catch, необходимо внести изменения:

```csharp
Debug.LogError("Could not create a device for '{description}' (exception: {exception})");
```

на

```csharp
Debug.Log("Could not create a device for '{description}' (exception: {exception})");
```

## Подвижная платформа 2DOF

### Руководство по установке подвижной платформы

* Скачать unitypackage:
  * Скачать одну из публичных версий плагина, которые можно найти в разделе [Releases](https://github.com/RTU-TVP/2DOF-Plugin-Unity/releases).
  * Импортировать unitypackage в ваш проект Unity.

* Склонировать репозиторий:
  * Склонировать репозиторий в ваш проект Unity.
  * Перейти в папку "Plugins/2DOF" и импортировать плагины в ваш проект Unity.

* С помощью Package Manager (для Unity 2019.3 и выше):
  * Открыть Package Manager в Unity.
  * Нажать на кнопку + в верхнем левом углу окна Package Manager.
  * Выбрать Add package from git URL.
  * Ввести ссылку на репозиторий плагина: `https://github.com/RTU-TVP/2DOF-Plugin-Unity.git?path=src/2DOF-Plugin-Unity/Assets/Plugins/2DOF`.

### Использование плагина подвижной платформы

1. Настройка игрового объекта для считывания данных:
   * Создайте/добавьте автомобиль на сцену.
   * Добавьте компонент Rigidbody.
   * Добавьте скрипт CarTelemetryHandler на игровой объект.
   * Подключите Transform и Rigidbody.
