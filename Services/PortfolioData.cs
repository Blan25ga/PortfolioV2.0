using PortfolioV2._0.Models;

namespace PortfolioV2._0.Services;

public interface IPortfolioData
{
    string Name { get; }
    string Role { get; }
    string Location { get; }
    string Email { get; }
    string Phone { get; }
    string Bio { get; }
    string GitHub { get; }
    string LinkedIn { get; }
    string AvatarUrl { get; }
    IReadOnlyList<TechGroup> Tech { get; }
    IReadOnlyList<Project> Projects { get; }
    IReadOnlyList<Experience> Experience { get; }
    IReadOnlyList<Certification> Certifications { get; }
}

public class PortfolioData : IPortfolioData
{
    public string Name => "Gabriel Hernán Blanco";
    public string Role => "FullStack .NET Developer";
    public string Location => "San Antonio de Padua, Buenos Aires, Argentina";
    public string Email => "blancogabriel751@gmail.com";
    public string Phone => "+54 9 1136729505";
    public string GitHub => "https://github.com/Blan25ga";
    public string LinkedIn => "https://www.linkedin.com/in/gabrielhernanblanco/";
    public string AvatarUrl => "https://avatars.githubusercontent.com/u/97577534?v=4";

    public string Bio =>
        "Desarrollador FullStack .NET con background sólido en gestión operativa y liderazgo de equipos. " +
        "Esta combinación me permite comprender la visión estratégica del negocio y traducirla en código " +
        "eficiente, estructurado y mantenible. Experiencia internacional en Australia (2023–2024) y " +
        "reenfoque total en C# .NET desde Noviembre 2025.";

    public IReadOnlyList<TechGroup> Tech { get; } = new[]
    {
        new TechGroup("Backend & BD", "cpu",
            "Lógica de negocio orientada a objetos, arquitectura multicapa y bases de datos relacionales.",
            new[] { "C#", ".NET Framework / Core", "ASP.NET Web Forms", "SQL Server", "ADO.NET" }),
        new TechGroup("Frontend & Web", "window-sidebar",
            "Interfaces adaptativas, responsivas e interactivas con foco en experiencia de usuario.",
            new[] { "HTML5", "CSS3", "JavaScript", "Bootstrap 5", "REST APIs" }),
        new TechGroup("Herramientas & Liderazgo", "diagram-3",
            "Control de versiones, entornos de desarrollo y liderazgo de equipos de operaciones.",
            new[] { "Git & GitHub", "Visual Studio", "VS Code", "Gestión de Operaciones" })
    };

    public IReadOnlyList<Project> Projects { get; } = new[]
    {
        new Project("Gestión Catálogo — TP Final Nivel 3",
            "Aplicación web con arquitectura multicapa en ASP.NET Web Forms, C# y SQL Server. Autenticación, catálogo de productos, categorías y panel de administración completo. Demo online: registrate con cualquier email y contraseña.",
            new[] { "ASP.NET Web Forms", "C#", "SQL Server", "Bootstrap" },
            "https://github.com/Blan25ga/tp-final-nivel3-blanco-gabriel",
            "http://www.gestioncatalogo-tpfinal-nivel3.somee.com",
            "/images/projects/catalogo-tp3.jpg"),
        new Project("CatalogoApp Desktop",
            "Sistema de escritorio para gestión de artículos, marcas y categorías. Arquitectura en capas (Dominio, Negocio, Presentación) con ADO.NET.",
            new[] { "Windows Forms", ".NET Framework", "C#", "SQL Server" },
            "https://github.com/Blan25ga/CatalogoApp",
            null,
            "/images/projects/catalogoapp.jpg"),
        new Project("Clima App",
            "Aplicación web meteorológica en tiempo real con consumo de REST APIs y manipulación del DOM.",
            new[] { "JavaScript", "REST API", "HTML5/CSS3" },
            "https://github.com/Blan25ga/appclima-1",
            "https://appclima-1.netlify.app/",
            "/images/projects/appclima.jpg"),
        new Project("Pokedex Web",
            "Interfaz interactiva con PokeAPI: filtrado por tipos, búsqueda en tiempo real y layout responsive.",
            new[] { "JavaScript", "PokeAPI", "CSS Grid" },
            "https://github.com/Blan25ga/pokedex-po",
            "https://pokedex-po.netlify.app/",
            "/images/projects/pokedex.jpg"),
        new Project("Resto Coffee Bar",
            "Landing page responsive para cafetería: maquetado semántico, animaciones CSS y diseño mobile-first.",
            new[] { "HTML5", "CSS3", "Responsive" },
            null,
            "https://restoo-coffeebar.netlify.app/",
            "/images/projects/restoo.jpg"),
        new Project("Form Login Responsive",
            "Diseño de interfaz y UX para formulario de autenticación con validaciones y estilos modernos.",
            new[] { "HTML5", "CSS3", "UI/UX" },
            null,
            "https://formlogin-responsive.netlify.app/",
            "/images/projects/formlogin.jpg"),
        new Project("eClock Web",
            "Proyecto de práctica frontend: reloj digital y componentes interactivos con JavaScript.",
            new[] { "JavaScript", "CSS3" },
            null,
            "https://eclockweb.netlify.app/",
            "/images/projects/eclockweb.jpg"),
        new Project("Martial Web",
            "Sitio institucional para academia de artes marciales: secciones, galería y contacto.",
            new[] { "HTML5", "CSS3", "Bootstrap" },
            null,
            "https://martialweb.netlify.app/",
            "/images/projects/martialweb.jpg"),
        new Project("Info COVID-19",
            "Proyecto de contenido y presentación con datos informativos y layout responsive.",
            new[] { "HTML5", "CSS3", "Contenido" },
            null,
            "https://covid19-infoweb.netlify.app/",
            "/images/projects/covid19.jpg"),
        new Project("Portafolio Web Personal (v1)",
            "Primera versión del portafolio personal: presentación de trayectoria, stack y proyectos.",
            new[] { "HTML5", "CSS3", "JavaScript" },
            "https://github.com/Blan25ga/portfolio-act",
            "https://portafolio-actualizado.netlify.app/",
            "/images/projects/portfolio-act.jpg"),
        new Project("Mis Certificados",
            "Repositorio oficial con la colección de certificaciones y credenciales en desarrollo de software.",
            new[] { "C# N1–N3", "Certificaciones" },
            "https://github.com/Blan25ga/My-Certificates",
            null,
            "/images/projects/certificados.jpg")
    };

    public IReadOnlyList<Experience> Experience { get; } = new[]
    {
        new Experience("Desarrollador .NET Independiente", "Proyectos Personales & Formación",
            "Nov 2025 — Presente",
            "Aplicaciones en ASP.NET Web Forms, WinForms, C# y SQL Server con arquitectura en capas y buenas prácticas de POO."),
        new Experience("Experiencia Internacional — Working Holiday", "Australia",
            "2023 — 2024",
            "Inmersión cultural y laboral. Fortalecimiento de inglés, adaptabilidad multicultural y resolución de problemas bajo presión."),
        new Experience("Subgerente de Operaciones", "Cinépolis Argentina",
            "2016 — 2022",
            "Liderazgo de equipos de +20 personas, optimización de procesos, control de inventario, análisis comercial y servicio al cliente."),
        new Experience("Coordinador de Depósito y Logística", "Maransi",
            "2015 — 2016",
            "Coordinación logística comercial y gestión de depósito.")
    };

    public IReadOnlyList<Certification> Certifications { get; } = new[]
    {
        new Certification("ASP.NET Web Forms, MVC, Entity Framework & Web API (Nivel 3)", "Maxi Programa", "Certificado"),
        new Certification("C# .NET Nivel 2 — POO & SQL Server", "Maxi Programa", "Certificado"),
        new Certification("C# .NET Nivel 1 — Programación desde cero", "Maxi Programa", "Certificado"),
        new Certification("Frontend: HTML5, CSS3 y JavaScript", "OpenBootcamp", "Certificado"),
        new Certification("Inglés intensivo y competencias globales", "—", "Certificado")
    };
}
