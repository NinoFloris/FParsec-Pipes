﻿#load "../packages/FSharp.Formatting.2.14.4/FSharp.Formatting.fsx"
open FSharp.Literate
open System.IO

let source = __SOURCE_DIRECTORY__
let template = Path.Combine(source, "template.html")

for file in ["Intro.fsx"; "Reference.fsx"] do
    Literate.ProcessScriptFile
        (Path.Combine(source, file), template, lineNumbers = false
        , replacements =
            [ "project-name", "FParsec-Pipes"
            ; "github-link", "https://github.com/rspeele/FParsec-Pipes"
            ])