# 🛠️ Worker Service con .NET y Archivos Automáticos

Este proyecto es un **servicio en segundo plano** creado con .NET, que:

📁 Crea archivos `.txt` en una carpeta llamada `Files`  
🕒 Lo hace **cada segundo** sin molestar al usuario  
🧠 Usa buenas prácticas como **inyección de dependencias**  
🧾 Guarda mensajes con un sistema de **logs profesionales**

---

## 🚀 ¿Cómo funciona?

1. 🧩 La clase `Worker` hereda de `BackgroundService`, lo que permite ejecutar tareas en segundo plano.

2. 🪵 Usa `ILogger<Worker>` para mostrar mensajes en la consola como:  
   `"Worker running at: 20/04/2025 10:00:01"`

3. 🗂️ Usa una interfaz `IFileData` para crear archivos sin que el `Worker` sepa cómo se hacen.

4. ✍️ Cada archivo contiene el texto:  
   `"Karina Simbaña Repasando"`

---

## 🧪 ¿Qué hace exactamente?

| Tarea                              | Descripción |
|-----------------------------------|-------------|
| 🔁 Ciclo infinito                 | Corre cada segundo (hasta que se apague el servicio) |
| 🔢 Contador                      | Crea archivos con nombres como `0.txt`, `1.txt`, `2.txt` |
| 📝 Escritura de texto             | Escribe dentro del archivo un mensaje personalizado |
| 📦 Carpeta automática             | Usa la carpeta `Files` dentro del directorio de tu app |
| 💡 Logs informativos              | Muestra mensajes de cada acción en consola o archivo |




