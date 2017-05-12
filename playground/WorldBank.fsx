#load "../packages/FSharp.Charting.0.90.14/FSharp.Charting.fsx"
#r """C:\Repos\playground\packages\FSharp.Data.2.3.2\lib\net40\FSharp.Data.dll"""

open FSharp.Data
open FSharp.Charting

let data = WorldBankData.GetDataContext()

data.Countries.``United Kingdom``.Indicators.``Gross enrolment ratio, tertiary, both sexes (%)``
|> Chart.Line