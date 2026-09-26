# AR-StoryWorld-Bridging-Imagination-and-Reality


## 📌 Overview
**AR StoryWorld** is an innovative augmented reality (AR) project that combines the timeless charm of traditional storybooks with the captivating allure of modern technology. By leveraging Unity's AR capabilities, this project transforms static pages into interactive, immersive experiences for children. 

Through image tracking technology, pointing an Android device at specific images within the book unlocks a vibrant world of digital content. Animated characters and immersive sound effects bring the narrative to life, stimulating imagination and fostering a deeper, more engaging connection to the story.



<p align="center">
  <img width="400" height="400" alt="image" src="https://github.com/user-attachments/assets/c6bf8f49-8fe3-434f-846d-7c7c72c7b927" />
</p>

This project was developed as part of the **Robot Kinematics and Dynamics** course.
---

## 🚀 Features
* **Image-Based AR Tracking:** Instantly recognizes book pages and anchors 3D objects to them.
* **Immersive 3D Animations:** Brings static characters to life with scaled and properly oriented 3D models.
* **Interactive Storytelling:** Enhances reading comprehension and engagement through visual and auditory feedback.

---

## 🛠️ Technologies & Requirements
* **Game Engine:** Unity (Version `2022.3.26f1`)
* **Programming Language:** C#
* **Target Platform:** Android Devices

---

## 🧮 Computer Vision & Kinematics Approach
The core of this AR experience relies on precise mathematical transformations to bridge the 2D image plane and the 3D augmented world. The system pipeline consists of two main phases:

### 1. Marker Detection
* **ORB Feature Extraction:** Identifies unique keypoints in the camera frame.
* **Feature Matching:** Correlates features from the physical marker to the database.
* **Projective Transformation:** Calculates the initial homography.

### 2. Marker Tracking & Pose Estimation
* **FAST Keypoints & Optical Flow:** Tracks the marker smoothly across sequential frames.
* **ESM-based Refinement:** Refines the transformation for high stability.

### The Mathematics of Camera Pose
To correctly position 3D objects, the camera pose relative to the object's coordinate system must be retrieved. We find the correspondence between 3D object points $M = [X, Y, Z]^T$ and their 2D projections $m = [x, y]^T$ on the image plane.

---

## 🔮 Future Improvements
We aim to continuously evolve AR StoryWorld to provide a richer educational tool:
* **🕹️ Interactive Games:** Integrating mini-games and puzzles within the AR experience to enhance learning playfully.
* **🗣️ Text-to-Speech Integration:** Allowing children to listen to the story being read aloud, catering to various learning styles.
* **🔦 Highlighting Text:** Syncing the narration with visual text highlights to reinforce word recognition.
* **📖 Interactive Word Definitions:** Enabling children to tap individual words to hear pronunciation and definitions, promoting vocabulary growth.

---

## 👤 Devolper
**Lamia Faisal Alhelayl**
* **Course:** Robot Kinematics and Dynamics
