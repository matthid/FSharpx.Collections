﻿namespace System
open System.Reflection
open System.Runtime.CompilerServices

[<assembly: AssemblyTitleAttribute("FSharpx.Collections")>]
[<assembly: AssemblyProductAttribute("FSharpx.Collections")>]
[<assembly: AssemblyDescriptionAttribute("FSharpx.Collections is a collection of datastructures for use with F# and C#.")>]
[<assembly: AssemblyVersionAttribute("1.9.5")>]
[<assembly: InternalsVisibleToAttribute("FSharpx.Collections.Tests")>]
[<assembly: InternalsVisibleToAttribute("FSharpx.Collections.Experimental.Tests")>]
[<assembly: AssemblyFileVersionAttribute("1.9.5")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.9.5"
