# 🛡️ Proyecto Vikings

Este proyecto consiste en una aplicación que gestiona información sobre vikingos. Está compuesto por tres partes:

1. **🌐 Web API**: Proporciona las operaciones CRUD para gestionar los vikingos.
2. **🖥️ Frontend en Blazor**: Interfaz de usuario para interactuar con la API.
3. **📚 Biblioteca de Clases**: Contiene las entidades compartidas entre la API y el frontend.

## 📋 Requisitos Previos

Antes de ejecutar el proyecto, asegúrate de tener instalados los siguientes elementos:

- [.NET SDK](https://dotnet.microsoft.com/download) (versión 7.0 o superior)
- Un IDE como [Visual Studio](https://visualstudio.microsoft.com/) o [Visual Studio Code](https://code.visualstudio.com/)

## 🗂️ Estructura del Proyecto

/PruebaSolution │ ├── /PruebaSolution.WebApi # Web API ├── /PruebaSolution.FrontPrueba # Frontend en Blazor └── /PruebaSolution.SharedModels # Biblioteca de clases para entidades compartidas

## 🚀 Ejecución del Proyecto

### 1. Clonar el Repositorio

Primero, clona el repositorio en tu máquina local:

```bash
# Comando en Bash
git clone https://github.com/JhonAguiar/Vikings.git
cd vikings
2. Ejecutar la Web API
Navega a la carpeta de la API:
```

```bash
Copiar código
cd Vikings.Api
Restaura las dependencias:
```

```bash
Copiar código
dotnet restore
Ejecuta la API:
```

```bash
Copiar código
dotnet run
La API se ejecutará por defecto en https://localhost:7002.

3. Ejecutar el Frontend en Blazor
Abre una nueva terminal y navega a la carpeta del frontend:
```

```bash
Copiar código
cd Vikings.Frontend
Restaura las dependencias:
```

```bash
Copiar código
dotnet restore
Ejecuta el proyecto:
```

```bash
Copiar código
dotnet run
El frontend se ejecutará por defecto en https://localhost:5001.

4. Probar la Aplicación
Abre un navegador y visita la dirección del frontend:
```

```bash
Copiar código
https://localhost:5001/createVikings
Desde ahí podrás crear, editar, eliminar y visualizar la información de los vikingos.
```
## 📦 Entidades Compartidas
La biblioteca de clases Vikings.SharedModels contiene las definiciones de las entidades que se utilizan tanto en la API como en el frontend. Asegúrate de que cualquier cambio en las entidades se refleje en ambas partes del proyecto.

## 🤝 Contribuciones
Las contribuciones son bienvenidas. Si deseas contribuir al proyecto, por favor sigue estos pasos:

Haz un fork del repositorio.
Crea una nueva rama para tu feature (git checkout -b feature/nueva-feature).
Realiza tus cambios y haz commit (git commit -m 'Añadir nueva feature').
Haz push a la rama (git push origin feature/nueva-feature).
Abre un Pull Request.
## 📜 Licencia
Este proyecto está bajo la licencia MIT. Consulta el archivo LICENSE para más detalles.
