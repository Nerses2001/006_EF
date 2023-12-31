# 006_EF
## Repository with One-to-Many Relationship Example in Entity Framework

This repository represents an example of using Entity Framework to create a one-to-many relationship between the `Player` and `Team` entities.

## One-to-Many Relationship

A one-to-many relationship means that one element in one table is associated with multiple elements in another table. In this example, one team can have multiple players, but each player belongs to only one team.

## Codebase

### Player Class

```csharp
public class Player
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int TeamId { get; set; }
    public Team Team { get; set; }
}

```

### Team Class
```csharp
public class Team
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Player> Players { get; set; }
}
```

### Context Class
```csharp
internal class Context : DbContext
{
    public DbSet<Team> Teams { get; set; }
    public DbSet<Player> Players { get; set; }

    public Context()
    {
        Database.EnsureCreated();
    }

    // Other code is omitted for brevity
}

```
In this example, the `Player` and `Team` classes represent the "Player" and "Team" entities, respectively. The `Player` class has a `TeamId` property that serves as a foreign key to establish the one-to-many relationship with the `Team` entity. The `Team` class has a collection of `Players`, representing the relationship.

This example illustrates how to implement a one-to-many relationship using Entity Framework in C#. Each player belongs to one team, demonstrating the one-to-many relationship.

