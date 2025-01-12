# 2DOF Plugin Unity

[Рус](README.md) | [ENG](README.en.md)

## Logitech G29 Wheel and Gearbox

### Installation Guide

You can install the plugins using any of the following methods:

* **Download the unitypackage**:
  * Download one of the public plugin versions available in the [Releases](https://github.com/RTU-TVP/2DOF-Plugin-Unity/releases) section.
  * Import the unitypackage into your Unity project.

* **Clone the repository**:
  * Clone the repository into your Unity project.
  * Go to the **Plugins/LogitechG29** folder and import the plugins into your Unity project.

* **Using the Package Manager (for Unity 2019.3 and higher)**:
  * Open the Package Manager in Unity.
  * Click the **+** button in the top-left corner of the Package Manager window.
  * Select **Add package from git URL**.
  * Enter the plugin repository link:  
    `https://github.com/RTU-TVP/2DOF-Plugin-Unity.git?path=src/2DOF-Plugin-Unity/Assets/Plugins/LogitechG29`.

### Using the Plugin

1. **Install the Input System package.**  
2. **Connect to the InputControllerReader**: Create a script to handle input data, create a reference to the InputControllerReader instance, attach the script to a GameObject, and link the instance.
3. **Define the logic for processing input**: In your script, write the logic for handling the input results using events and methods from InputControllerReader.

### If there are issues in the built game where some wheel functionality does not work

#### Make a small code change

In the file located at:  
`Library\PackageCache\com.unity.inputsystem@1.7.0\InputSystem\InputManager.cs`

On line **2333**, inside the **catch** block, replace:

```csharp
Debug.LogError("Could not create a device for '{description}' (exception: {exception})");
```

with

```csharp
Debug.Log("Could not create a device for '{description}' (exception: {exception})");
```

---

## 2DOF Motion Platform

### Motion Platform Installation Guide

You can install the motion platform plugin using any of the following methods:

* **Download the unitypackage**:
  * Download one of the public plugin versions available in the [Releases](https://github.com/RTU-TVP/2DOF-Plugin-Unity/releases) section.
  * Import the unitypackage into your Unity project.

* **Clone the repository**:
  * Clone the repository into your Unity project.
  * Go to the **Plugins/2DOF** folder and import the plugins into your Unity project.

* **Using the Package Manager (for Unity 2019.3 and higher)**:
  * Open the Package Manager in Unity.
  * Click the **+** button in the top-left corner of the Package Manager window.
  * Select **Add package from git URL**.
  * Enter the repository link:  
    `https://github.com/RTU-TVP/2DOF-Plugin-Unity.git?path=src/2DOF-Plugin-Unity/Assets/Plugins/2DOF`.

### Using the 2DOF Motion Platform Plugin

1. **Configure the GameObject to read data**:
   * Create/add a car to your scene.
   * Add a **Rigidbody** component.
   * Add the **CarTelemetryHandler** script to the GameObject.
   * Link the corresponding **Transform** and **Rigidbody** in the script.
