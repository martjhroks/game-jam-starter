# game-jam-starter

A Unity starter template containing **various player controllers** for different game types. This project is designed to help developers quickly prototype and experiment with different movement and camera mechanics in 2D and 3D.

---

## Project Structure

```
/Assets
  ├── Scenes
  │   ├── 2D Sidescrolling
  │   ├── 2D Top Down
  │   ├── 3D FPS
  │   ├── 3D Third Person
  │   ├── 3D Top Down
  ├── Scripts
  │   ├── 2D
  │   │   ├── PlayerController_SideScroller.cs
  │   │   └── PlayerController_TopDown2D.cs
  │   ├── 3D
  │   │   ├── FPSController.cs
  │   │   ├── ThirdPersonController.cs
  │   │   └── TopDown3DController.cs
  └── URP
```

---

## 🎮 Available Scenes & Controllers

### **2D Sidescrolling**

- Classic **side-scrolling movement** (e.g., platformers like *Celeste* or *Hollow Knight*).
- **Features:**
  - Left & right movement.
  - Jumping with **variable height**.
  - Coyote time & jump buffering for smoother gameplay.

### **2D Top Down**

- Top-down player movement (e.g., *Zelda*, *Hyper Light Drifter*).
- **Features:**
  - **8-directional movement**.
  - Rigidbody-based physics.
  - Adjustable movement speed.

### **3D First-Person Shooter (FPS)**

- A simple **first-person** movement system.
- **Features:**
  - WASD movement.
  - Mouse look control.

### **3D Third-Person**

- A third-person movement system using **Cinemachine**.
- **Features:**
  - Free camera rotation.
  - Character moves relative to the camera.

### **3D Top Down**

- A 3D top-down character controller.
- **Features:**
  - WASD-based movement.
  - Rotates towards movement direction.

---

## ⚙️ How to Use

1. **Clone the Repository:**

2. **Open in Unity:**

   - Make sure you have **Unity 6** installed.
   - Add and open the project in **Unity Hub**.

3. **Play Different Scenes:**

   - Navigate to `Assets/Scenes/` and open any scene.
   - Press **Play** to test different movement systems.

---

## ⚙️ Dependencies

- **Cinemachine** (for third-person and camera control).

---

