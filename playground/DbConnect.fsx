#r "../packages/SQLProvider.1.0.54/lib/FSharp.Data.SqlProvider.dll"
open FSharp.Data.Sql

let [<Literal>] connectionString = """Server=tcp:testdbjoseph.database.windows.net,1433;Initial Catalog=TestDB;Persist Security Info=False;User ID=admin_user;Password=History12!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"""

type sql = SqlDataProvider<
                            ConnectionString = connectionString,
                            DatabaseVendor = Common.DatabaseProviderTypes.MSSQLSERVER,
                            UseOptionTypes = true,
                            IndividualsAmount = 10
                           >

let ctx = sql.GetDataContext().SalesLt

query {
    for x in ctx.Product do
    select x.``SalesLT.ProductModel by ProductModelID``
}
|> Seq.toList