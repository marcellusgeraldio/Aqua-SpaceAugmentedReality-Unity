# 🪐 SpaceAR - Solar System Education

Created by: **Marcellus Geraldio Florenta (2702262816)**
<br>
BINUS University - Computer Science

---

## 📖 Project Description

**SpaceAR** is an educational application based on *Augmented Reality* (AR), built using **Unity** and **Vuforia**. This application allows users to scan 8 physical planet cards (from Mercury to Pluto) using their smartphone's camera.

Once a card is detected, the application will spawn a 3D model of the corresponding planet on top of the card, complete with an educational information panel displaying interesting facts.

## 🎯 Project Objective

This project was created to understand and implement:
* The fundamental concepts of Augmented Reality (AR) using Image Targets.
* Interactive 3D mobile application development using the Unity Engine.
* C# scripting logic for manipulating Game Objects and UI elements.

## ✨ Key Features

* **Image Recognition:** Scans 8 different planet cards as Image Targets.
* **3D Model Spawning:** Renders a low-poly 3D model of the corresponding planet on top of the card.
* **Automatic Planet Rotation:** Each planet model automatically rotates on its axis using a C# script.
* **Dynamic Information Panel:** A UI Canvas appears displaying the name, 2D image, description, and unique facts of the detected planet.

## 🌌 List of Planets (Image Targets)

<img width="1329" height="190" alt="image" src="https://github.com/user-attachments/assets/858c8500-ef9e-4f94-8a65-c03935e410bc" />

This application can recognize the following 9 Image Targets:
1.  Mercury
2.  Venus
3.  Earth
4.  Mars
5.  Jupiter
6.  Saturn
7.  Uranus
8.  Neptune

## ⚙️ Project Architecture

* **Unity Engine:** Used as the primary engine for 3D and AR development.
* **Vuforia Engine:** The library used for Augmented Reality functionality, specifically Image Target Recognition.
* **Main Scene (SampleScene):** Contains the `ARCamera`, 8 `ImageTarget` Game Objects, prefabs for the 8 planets, and a single `Canvas` for the UI.
* **Planet Rotation Script (C#):** A simple C# script attached to each planet prefab to make it rotate constantly.
* **Manager Script (`KangAtur.cs`):** A centralized C# script placed on the `KangAtur` Game Object. This script is solely responsible for:
    * Detecting which Image Target is currently active.
    * Managing the UI Canvas (activating/deactivating the panel).
    * Populating the correct data (name, description, facts) into the UI elements (Text, Image) based on the detected planet.

## 🧠 Technical Concepts Used

* **Augmented Reality (AR):** Merging 3D digital objects with the real-world environment.
* **Image Target Recognition:** Using 2D images (cards) as markers to trigger AR content.
* **C# Scripting (OOP):** Using the C# language for all application logic, object rotation, and UI management.
* **UI Management (Unity UI):** Controlling and manipulating Canvas elements (Text, Image, Panel) via scripts.
* **Prefab Management:** Using prefabs for each planet for easy management and spawning.

