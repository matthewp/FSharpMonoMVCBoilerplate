# Introduction
**FSharpMonoMVCBoilerplate** is a boilerplate template for making MVC (Model-View-Controller) web applications in F# on Mono (OSX or Linux). It is based on the template created by Tomas Petricek [here](http://cs.hubfs.net/blogs/tomasp/archive/2010/05/09/14050.aspx).

# Details
**Templates** are written in ASPX currently, hopefully I'll be able to add support for Razor soon, since it's a bit more enjoyable to work with.

The boilplate projects works by having a minimal C# project that holds your templates, as well as a Global.asax file that simply calls the base.Start() from the F# project.  Your F# project holds all of the routing, as well as controllers and models.

To compile simply run 'make', like on any other unix project.
