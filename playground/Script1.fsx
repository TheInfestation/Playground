#load "../packages/FSharp.Charting.0.90.14/FSharp.Charting.fsx"
#r """C:\Users\josep\onedrive\documents\visual studio 2017\Projects\ConsoleApplication1\packages\FSharp.Data.2.3.2\lib\net40\FSharp.Data.dll"""

open System.Drawing
open FSharp.Data
open FSharp.Charting

let data = WorldBankData.GetDataContext()

data.Countries.``United Kingdom``.Indicators.``Gross enrolment ratio, tertiary, both sexes (%)``
|> Chart.Line