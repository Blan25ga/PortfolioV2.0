# PortfolioV2.0

Portafolio personal de **Gabriel Hernán Blanco**, FullStack .NET Developer.  
Sitio de una sola página con diseño oscuro "Facet Glass": tarjetas de vidrio, acentos esmeralda y cian, fondo `#050507`.

## Contenido del sitio

- **Hero**: presentación, rol, ubicación y accesos a GitHub / LinkedIn / contacto.
- **Stack**: agrupado en Backend & BD, Frontend & Web, Herramientas & Liderazgo.
- **Proyectos destacados**: tarjetas que giran al hacer clic (mouse, Enter o Espacio) y muestran una captura real del proyecto junto con los botones *Ver proyecto* y *Repositorio*.
- **Experiencia & Formación**: trayectoria laboral y certificaciones.
- **Contacto**: email y teléfono.

## Stack

- .NET 11 — ASP.NET Core Razor Pages
- C# 13 (nullable e implicit usings habilitados)
- Bootstrap 5 + Bootstrap Icons
- CSS propio (`wwwroot/css/site.css`) y JavaScript sin dependencias (`wwwroot/js/site.js`)

## Estructura

```text
Models/PortfolioModels.cs      Records: Project, Experience, Certification, TechGroup
Services/PortfolioData.cs      Todos los datos del CV y proyectos (IPortfolioData)
Pages/Index.cshtml             Página única del portafolio
Pages/Shared/_Layout.cshtml    Navbar glass, footer y enlaces sociales
Program.cs                     DI, logging y assets estáticos
wwwroot/css/site.css           Sistema de diseño Facet Glass
wwwroot/js/site.js             Giro de las tarjetas de proyectos
wwwroot/images/projects/       Capturas de cada proyecto (JPG 800px)
```

## Ejecutar en local

Requisito: .NET SDK 11.

```bash
dotnet restore
dotnet run --urls "http://localhost:5199"
```

Abrir `http://localhost:5199`.

## Editar el contenido

Todo el texto vive en `Services/PortfolioData.cs` (nombre, bio, stack, proyectos, experiencia, certificaciones, links). No hace falta tocar el HTML: las vistas leen de `IPortfolioData`, registrado como Singleton en `Program.cs`.

Para agregar un proyecto nuevo, sumar un `Project` a la lista `Projects`:

```csharp
new Project("Título", "Descripción", new[] { "C#", "SQL Server" },
    RepoUrl: "https://github.com/Blan25ga/repo",
    DemoUrl: "https://demo.netlify.app",
    ImageUrl: "/images/projects/mi-proyecto.jpg")
```

Los campos `RepoUrl`, `DemoUrl` e `ImageUrl` son opcionales: el botón o la imagen solo se renderizan si están presentes.

## Proyectos enlazados

| Proyecto | Demo | Repositorio |
|---|---|---|
| Gestión Catálogo — TP Final Nivel 3 | [somee.com](http://www.gestioncatalogo-tpfinal-nivel3.somee.com) | [GitHub](https://github.com/Blan25ga/tp-final-nivel3-blanco-gabriel) |
| CatalogoApp Desktop | — | [GitHub](https://github.com/Blan25ga/CatalogoApp) |
| Clima App | [Netlify](https://appclima-1.netlify.app/) | [GitHub](https://github.com/Blan25ga/appclima-1) |
| Pokedex Web | [Netlify](https://pokedex-po.netlify.app/) | [GitHub](https://github.com/Blan25ga/pokedex-po) |
| Resto Coffee Bar | [Netlify](https://restoo-coffeebar.netlify.app/) | — |
| Form Login Responsive | [Netlify](https://formlogin-responsive.netlify.app/) | — |
| eClock Web | [Netlify](https://eclockweb.netlify.app/) | — |
| Martial Web | [Netlify](https://martialweb.netlify.app/) | — |
| Info COVID-19 | [Netlify](https://covid19-infoweb.netlify.app/) | — |
| Mis Certificados | — | [GitHub](https://github.com/Blan25ga/My-Certificates) |

## Autor

Gabriel Hernán Blanco — San Antonio de Padua, Buenos Aires, Argentina

- GitHub: [Blan25ga](https://github.com/Blan25ga)
- LinkedIn: [gabrielhernanblanco](https://www.linkedin.com/in/gabrielhernanblanco/)
- Email: blancogabriel751@gmail.com
