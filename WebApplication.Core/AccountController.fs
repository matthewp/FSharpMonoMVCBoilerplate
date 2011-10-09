namespace WebApplication.Core.Controllers

open System
open System.Web.Mvc

[<HandleError>]
type AccountController() =
  inherit Controller()

  member x.Index() =
    x.View()

  member x.LogOn() =
    let msg = "You want to log in"
    x.ViewData.["Message"] <- msg
    x.View() 
