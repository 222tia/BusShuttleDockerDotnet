using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using DomainModel;

namespace WebMvc.Models;

public class EntryViewModel {
    public int Id { get; set; }
    public int StopId { get; set; }
    public int LoopId { get; set; }
    public int DriverId { get; set; }
    public int BusId { get; set; }
    public DateTime TimeStamp { get; set; }
    public int Boarded { get; set; }
    public int LeftBehind { get; set; }

    public static EntryViewModel FromEntry(EntryModel entry) {
        return new EntryViewModel {
            Id = entry.Id,
            StopId = entry.StopId,
            LoopId = entry.LoopId,
            DriverId = entry.DriverId,
            BusId = entry.BusId,
            TimeStamp = entry.TimeStamp,
            Boarded = entry.Boarded,
            LeftBehind = entry.LeftBehind 
            };
        }
}
