# Proyecto Interactivo - Unidad 2.2 El primer escenario

## 📌 Descripción
Este proyecto corresponde a la **actividad 2.2: El primer escenario**, en donde se configuró una escena en Unity a partir del proyecto anterior (botones que abren enlaces).  
La escena incluye ajuste de aspecto para diferentes dispositivos, botones de navegación y puntos de anclaje.

---

## ⚙️ Configuración de la escena

### 1. Tamaño de pantalla para diferentes dispositivos
- Se configuró el **Canvas** con la opción:
  - **Canvas Scaler → UI Scale Mode: Scale With Screen Size**
  - Resolución de referencia: **1920 x 1080**
- Esto permite que la interfaz se adapte a diferentes resoluciones (16:9, 4:3, 9:16, etc.).

### 2. Botones de navegación
Se integraron tres botones dentro de un **Panel de navegación**:
- **Google** → Abre la página [https://www.google.com](https://www.google.com)  
- **YouTube** → Abre la página [https://www.youtube.com](https://www.youtube.com)  
- **Wikipedia** → Abre la página [https://www.wikipedia.org](https://www.wikipedia.org)  

Los botones funcionan correctamente y muestran mensajes en la consola al ser presionados.

### 3. Puntos de anclaje
Se configuraron los **Anchors** de los botones para mantener su posición en distintas resoluciones:
- Botón Google → anclado al **Top Center**  
- Botón YouTube → anclado al **Center**  
- Botón Wikipedia → anclado al **Bottom Center**

---

## 📂 Estructura de la escena
```
Canvas (UI principal)
 └── Panel Navegación
      ├── Botón Google
      ├── Botón YouTube
      └── Botón Wikipedia
```

---

## 🖥️ Scripts utilizados

### AbrirEnlace.cs
```csharp
using UnityEngine;

public class AbrirEnlace : MonoBehaviour
{
    public void AbrirGoogle()
    {
        Application.OpenURL("https://www.google.com");
    }

    public void AbrirYouTube()
    {
        Application.OpenURL("https://www.youtube.com");
    }

    public void AbrirWikipedia()
    {
        Application.OpenURL("https://www.wikipedia.org");
    }
}
```

### Botones.cs
```csharp
using UnityEngine;
using UnityEngine.UI;

public class Botones : MonoBehaviour
{
    public Button boton1;
    public Button boton2;
    public Button boton3;

    void Start()
    {
        boton1.onClick.AddListener(() => Debug.Log("Botón 1 presionado"));
        boton2.onClick.AddListener(() => Debug.Log("Botón 2 presionado"));
        boton3.onClick.AddListener(() => Debug.Log("Botón 3 presionado"));
    }
}
```

---

## ✅ Criterios de evaluación cumplidos
- [x] La escena creada tiene un tamaño de pantalla ajustable a diferentes dispositivos.  
- [x] Se integran botones de navegación que funcionan de forma adecuada.  
- [x] La escena contiene puntos de anclaje que permiten ver de manera correcta todos los elementos dentro de la ventana creada.  

---

## 📎 Recursos de apoyo
- Natalie C. (2017, 14 de julio). *Interactive book 02 Aspect ratio and Artwork*. [video]. YouTube.  
  https://www.youtube.com/watch?v=OsOVmiDY41I&list=PLXCgN_6N-cUxdJrPGL93xSL1oUuqt3Hvt&index=2  
- Natalie C. (2017, 14 de julio). *Interactive Book 03 Setting up a scene in Unity, Aspect ratios & buttons*. [video]. YouTube.  
  https://www.youtube.com/watch?v=6jKU1eVFGqI&list=PLXCgN_6N-cUxdJrPGL93xSL1oUuqt3Hvt&index=3  
