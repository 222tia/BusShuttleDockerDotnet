using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace WebMvc.Services;

public class BusShuttleDocker : DbContext {

    public BusShuttleDocker(DbContextOptions<BusShuttleDocker> options)
        : base(options)
    { }
    public DbSet<Bus> Bus { get; set; }
    public DbSet<Driver> Driver { get; set; }
    public DbSet<Entry> Entry { get; set; }
    public DbSet<Loop> Loop { get; set; }
    public DbSet<Route> Route { get; set; }
    public DbSet<Stop> Stop { get; set; }
    public DbSet<User> User { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source=BusShuttleDocker.db");
}

public class Bus {
    public int Id { get; set; }
    public int BusNumber { get; set; }
}

public class Driver {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public class Entry {
    public int Id { get; set; }
    public int StopId { get; set; }
    public int LoopId { get; set; }
    public int DriverId { get; set; }
    public int BusId { get; set; }
    public DateTime TimeStamp { get; set; }
    public int Boarded { get; set; }
    public int LeftBehind { get; set; }
}

public class Loop {
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Route {
    public int Id { get; set; }
    public int Order { get; set; }
}

public class Stop {
    public int Id { get; set; }
    public string Name { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}

public class User {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
}