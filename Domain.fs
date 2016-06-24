namespace TempConverter
open System
open System.IO

module Temps =
    type TemperatureType  = F of float | C of float