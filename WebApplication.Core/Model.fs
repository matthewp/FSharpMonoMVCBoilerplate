namespace WebApplication.Core

open Microsoft.FSharp.Quotations

type ProductInfo = {
  ID : int
  Name : string
  Category : string
  Price : System.Decimal }

module Model = 
  let ListProducts =
    1

  let ProductDetail (id) =
    1
