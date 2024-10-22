# 2DOF Plugin Unity

[RU](README.md) | [EN](README_ENG.md)

## Logitech G29 Steering Wheel and Gearbox Shifter

### Installation Guide

* Import assets: Import the necessary files into your Unity project.

* Install Input System package: Open Package Manager, go to the Unity Registry tab, find Input System and install it.

* Connect to InputControllerReader: Create a script for processing input data, create a reference to the InputControllerReader instance, attach the script to a game object and bind the instance.

* Write input data processing logic: In your script, write the logic for processing input results using events and methods of InputControllerReader.

## 2DOF Mobile Platform

### Mobile Platform Setup Guide

* Import assets: Import the necessary files into your Unity project.

* Configure game object for reading data: Create/add a car to the scene, add a Rigidbody component, add the CarTelemetryHandler script to the game object and connect Transform and Rigidbody components.
