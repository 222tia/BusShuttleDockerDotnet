using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DomainModel;

namespace WebMvc.Models;

public class DriverEntryCreateModel {
    public int Id { get; set; }
    public int StopId { get; set; }
    public int LoopId { get; set; }
    public int DriverId { get; set; }
    public int BusId { get; set; }
    public DateTime TimeStamp { get; set; }
    public int Boarded { get; set; }
    public int LeftBehind { get; set; }
}