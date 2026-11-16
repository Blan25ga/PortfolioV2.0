# PortfolioV2.0

Portafolio personal de **Gabriel HernÃ¡n Blanco**, FullStack .NET Developer.
Sitio de una sola pÃ¡gina con diseÃ±o oscuro "Facet Glass": tarjetas de vidrio, acentos esmeralda y cian, fondo `#050507`.

## Contenido del sitio

- **Hero**: presentaciÃ³n, rol, ubicaciÃ³n y accesos a GitHub / LinkedIn / contacto.
- **Stack**: agrupado en Backend & BD, Frontend & Web, Herramientas & Liderazgo.
- **Proyectos destacados**: tarjetas que giran al hacer clic (mouse, Enter o Espacio) y muestran una captura real del proyecto junto con los botones *Ver proyecto* y *Repositorio*.
- **Experiencia & FormaciÃ³n**: trayectoria laboral y certificaciones.
- **Contacto**: email y telÃ©fono.

## Stack

- .NET 11 â€” ASP.NET Core Razor Pages
- C# 13 (nullable e implicit usings habilitados)
- Bootstrap 5 + Bootstrap Icons
- CSS propio (`wwwroot/css/site.css`) y JavaScript sin dependencias (`wwwroot/js/site.js`)

## Estructura

```
Models/PortfolioModels.cs      Records: Project, Experience, Certification, TechGroup
Services/PortfolioData.cs      Todos los datos del CV y proyectos (IPortfolioData)
Pages/Index.cshtml             PÃ¡gina Ãºnica del portafolio
Pages/Shared/_Layout.cshtml    Navbar glass, footer y enlaces sociales
Program.cs                     DI, logging y assets estÃ¡ticos
wwwroot/css/site.css           Sistema de diseÃ±o Facet Glass
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

Todo el texto vive en `Services/PortfolioData.cs` (nombre, bio, stack, proyectos, experiencia, certificaciones, links).
No hace falta tocar el HTML: las vistas leen de `IPortfolioData`, registrado como Singleton en `Program.cs`.

Para agregar un proyecto nuevo, sumar un `Project` a la lista `Projects`:

```csharp
new Project("TÃ­tulo", "DescripciÃ³n", new[] { "C#", "SQL Server" },
    RepoUrl: "https://github.com/Blan25ga/repo",
    DemoUrl: "https://demo.netlify.app",
    ImageUrl: "/images/projects/mi-proyecto.jpg")
```

Los campos `RepoUrl`, `DemoUrl` e `ImageUrl` son opcionales: el botÃ³n o la imagen solo se renderizan si estÃ¡n presentes.

## Proyectos enlazados

| Proyecto | Demo | Repositorio |
|---|---|---|
| GestiÃ³n CatÃ¡logo â€” TP Final Nivel 3 | [somee.com](http://www.gestioncatalogo-tpfinal-nivel3.somee.com) | [GitHub](https://github.com/Blan25ga/tp-final-nivel3-blanco-gabriel) |
| CatalogoApp Desktop | â€” | [GitHub](https://github.com/Blan25ga/CatalogoApp) |
| Clima App | [Netlify](https://appclima-1.netlify.app/) | [GitHub](https://github.com/Blan25ga/appclima-1) |
| Pokedex Web | [Netlify](https://pokedex-po.netlify.app/) | [GitHub](https://github.com/Blan25ga/pokedex-po) |
| Resto Coffee Bar | [Netlify](https://restoo-coffeebar.netlify.app/) | â€” |
| Form Login Responsive | [Netlify](https://formlogin-responsive.netlify.app/) | â€” |
| eClock Web | [Netlify](https://eclockweb.netlify.app/) | â€” |
| Martial Web | [Netlify](https://martialweb.netlify.app/) | â€” |
| Info COVID-19 | [Netlify](https://covid19-infoweb.netlify.app/) | â€” |
| Mis Certificados | â€” | [GitHub](https://github.com/Blan25ga/My-Certificates) |

## Autor

Gabriel HernÃ¡n Blanco â€” San Antonio de Padua, Buenos Aires, Argentina

- GitHub: [Blan25ga](https://github.com/Blan25ga)
- LinkedIn: [gabrielhernanblanco](https://www.linkedin.com/in/gabrielhernanblanco/)
- Email: blancogabriel751@gmail.com

