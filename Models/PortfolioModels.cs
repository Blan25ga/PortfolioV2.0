namespace PortfolioV2._0.Models;

public record Project(
    string Title,
    string Description,
    string[] Tags,
    string? RepoUrl = null,
    string? DemoUrl = null,
    string? ImageUrl = null);

public record Experience(
    string Role,
    string Company,
    string Period,
    string Description);

public record Certification(
    string Title,
    string Issuer,
    string Status);

public record TechGroup(
    string Name,
    string Icon,
    string Description,
    string[] Items);
