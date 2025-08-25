<div align="center">
  <img width="927" height="185" alt="Image 1" src="https://github.com/user-attachments/assets/5da3a3af-8af3-4e51-9b21-89d14d426758" />
  <img width="1024" height="185" alt="Image 2" src="https://github.com/user-attachments/assets/4bc72cef-d816-49fe-ba8d-78d6b6367424" />
</div>



MAUI Graphics Library Implementation

![.NET MAUI](https://img.shields.io/badge/.NET-MAUI-512BD4)
![C#](https://img.shields.io/badge/C%23-239120)
![License](https://img.shields.io/badge/License-MIT-yellow)
![Version](https://img.shields.io/badge/Version-1.0-red)

**La solución definitiva para visualización de datos con MicroCharts en .NET MAUI**

*Una implementación completa de gráficas y visualizaciones desarrollada por PIXELBITS Studios que aprovecha todo el poder de MicroCharts en .NET MAUI.*

---

## **¿Por qué MicroCharts PixelBits?**

En el desarrollo moderno de aplicaciones multiplataforma, **la visualización efectiva de datos es fundamental**. Ya seas un desarrollador profesional, analista de datos, o creador de aplicaciones empresariales, esta implementación te proporciona **un conjunto completo** de herramientas de visualización para tus aplicaciones .NET MAUI.

### **Características Destacadas**

**Visualización Avanzada**
Implementación completa de todos los tipos de gráficas disponibles en MicroCharts, incluyendo gráficas de barras, líneas, áreas, circulares y más.

**Personalización Total**
Controles completamente personalizables con opciones de colores, estilos, animaciones y layouts. Adaptación automática a diferentes tamaños de pantalla y orientaciones.

**Rendimiento Optimizado**
Renderizado eficiente de gráficas con gestión optimizada de memoria y actualizaciones en tiempo real de datos.

**Multiplataforma**
Funcionalidad completa en todas las plataformas soportadas por .NET MAUI: iOS, Android, macOS y Windows.

<div align="center">
  <img width="726" height="370" alt="Image" src="https://github.com/user-attachments/assets/0fc53362-eeb2-402c-838c-448220f1ca6c" />
</div>

---

## **Especificaciones Técnicas**

### **Requisitos del Sistema**

**.NET MAUI Development Environment**
Visual Studio 2022 (Windows/Mac), .NET 6.0 o superior, SDK de las plataformas objetivo

### **Software y Dependencias**

#### **Visual Studio Setup**

## **Guía de Uso**

**Paso 1: Instalar Visual Studio 2022**
[Descarga oficial](https://visualstudio.microsoft.com/)

**Paso 2: Instalar la carga de trabajo de .NET MAUI**
Workload: .NET Multi-platform App UI development

#### **NuGet Packages Requeridos**

**Microcharts**
```
Install-Package Microcharts
Install-Package Microcharts.Maui
```

**SkiaSharp**
```
Install-Package SkiaSharp
Install-Package SkiaSharp.Views.Maui.Controls
```

### **Configuración del Proyecto**

**Paso 1: Referencias**
Agregar referencias a los paquetes necesarios en el archivo .csproj

**Paso 2: Inicialización**
Configurar los servicios necesarios en MauiProgram.cs

**Paso 3: Implementación**
Integrar las gráficas en las páginas XAML y código behind

---

📊 BarChart Visualización de datos categóricos mediante barras verticales u horizontales, ideal para comparar valores entre diferentes categorías. <div align="center"> <img src="https://github.com/user-attachments/assets/bfb10b2f-9ca6-488d-b76c-2de09022e87d" alt="BarChart Example" width="252" height="560"> </div>

📈 LineChart Representación de tendencias y cambios a lo largo del tiempo, perfecta para mostrar evolución de datos temporales. <div align="center"> <img src="https://github.com/user-attachments/assets/b61641e1-bfa7-4f24-a950-750590d7b1be" alt="LineChart Example" width="171" height="560"> </div>

🍩 DonutChart Visualización de proporciones con área central personalizable, excelente para mostrar distribuciones porcentuales. <div align="center"> <img src="https://github.com/user-attachments/assets/eb2c1265-fa72-4acd-9064-491e95732909" alt="DonutChart Example" width="252" height="560"> </div>

🎯 RadialGaugeChart Indicadores de progreso o métricas específicas, ideal para dashboards y monitoreo de KPIs. <div align="center"> <img src="https://github.com/user-attachments/assets/cf7270dc-b3bb-4b18-8602-88c8896a453b" alt="RadialGaugeChart Example" width="168" height="560"> </div>

🔵 PointChart Visualización de datos discretos en un plano, perfecta para análisis de correlación y distribución de puntos. <div align="center"> <img src="https://github.com/user-attachments/assets/04ea2194-b2c7-4a13-b5df-cffa746974f4" alt="PointChart Example" width="252" height="560"> </div>

🕸️ RadarChart Visualización multidimensional que muestra datos en forma radial desde un punto central, ideal para comparar múltiples variables. <div align="center"> <img src="https://github.com/user-attachments/assets/14db61f2-3145-40bf-9af0-e09c5090533d" alt="RadarChart Example" width="252" height="560"> </div>

🚀 Características Generales

Responsive Design: Todas las gráficas se adaptan a diferentes tamaños de pantalla
Personalización: Colores, estilos y configuraciones completamente customizables
Rendimiento Optimizado: Renderizado eficiente para grandes volúmenes de datos
Fácil Integración: API simple y documentación completa


### **Ejemplo de Implementación**

```xaml
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:microcharts="clr-namespace:Microcharts.Maui;assembly=Microcharts.Maui">
    <microcharts:ChartView x:Name="chartView" 
                          HeightRequest="200" 
                          WidthRequest="400"/>
</ContentPage>
```

```csharp
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        CreateChart();
    }

    private void CreateChart()
    {
        var entries = new[]
        {
            new ChartEntry(200) { Label = "Enero", ValueLabel = "200" },
            new ChartEntry(400) { Label = "Febrero", ValueLabel = "400" }
        };

        chartView.Chart = new BarChart { Entries = entries };
    }
}
```

---

## **Resolución de Problemas**

### **Problemas Comunes**

**Errores de Renderizado**
Verificar las dimensiones del contenedor y la inicialización correcta de SkiaSharp.

**Problemas de Rendimiento**
Optimizar el número de entradas y la frecuencia de actualización.

**Incompatibilidades de Plataforma**
Asegurar la configuración correcta de los permisos específicos de plataforma.

---
<div align="center">
<img width="419" height="404" alt="Image" src="https://github.com/user-attachments/assets/ef9bb9d7-6f90-4187-a32a-d15a9195ffc8" />
</div>

---

## **Casos de Uso**

### **Aplicaciones Empresariales**
Dashboards, reportes financieros, análisis de ventas, monitoreo de KPIs.

### **Análisis de Datos**
Visualización de estadísticas, tendencias temporales, distribuciones.

### **Monitoreo en Tiempo Real**
Sistemas de monitoreo, telemetría, análisis de sensores.

---

## 🌐 Contacto

<div align="center">

**PIXELBITS Studios** - *Innovación en tecnología embebida*

[![YouTube](https://img.shields.io/badge/YouTube-FF0000?style=for-the-badge&logo=youtube&logoColor=white)](https://www.youtube.com/channel/UCkLUjIeYTECtigFdcQjWu5Q)
[![Twitter](https://img.shields.io/badge/Twitter-1DA1F2?style=for-the-badge&logo=twitter&logoColor=white)](https://x.com/pixelbitstud)
[![Twitch](https://img.shields.io/badge/Twitch-9146FF?style=for-the-badge&logo=twitch&logoColor=white)](https://www.twitch.tv/pixelbits_studio/about)
[![Email](https://img.shields.io/badge/Email-D14836?style=for-the-badge&logo=gmail&logoColor=white)](mailto:info@pixelbits.studio)

</div>

---

## 📜 Licencia

Este proyecto está bajo la Licencia MIT. Ver [LICENSE](LICENSE) para detalles.

[![License](https://img.shields.io/badge/Licencia-MIT-green.svg?style=for-the-badge)](https://opensource.org/licenses/MIT)

---

<div align="center">

### **Hecho con 👽 por PIXELBITS Studios**

**WiFi Monitor ESP32 - Porque conocer tu entorno es el primer paso hacia la seguridad.**

[![Repository Views](https://komarev.com/ghpvc/?username=pixelbits-opera-num&color=00ff41&style=flat-square&label=Visitas+de+otros+Mundos)](https://github.com/Pacheco55/microchartsPixelbits)


</div>

