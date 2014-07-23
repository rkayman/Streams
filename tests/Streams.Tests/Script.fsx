﻿#time

#r "bin/Release/Streams.Core.dll"

open Nessos.Streams.Core

let data = [|1..100000000|] |> Array.map int64

data
|> Seq.filter (fun x -> x % 2L = 0L)
|> Seq.map (fun x -> x + 1L)
|> Seq.sum

data
|> Array.filter (fun x -> x % 2L = 0L)
|> Array.map (fun x -> x + 1L)
|> Array.sum

data
|> Stream.ofArray
|> Stream.filter (fun x -> x % 2L = 0L)
|> Stream.map (fun x -> x + 1L)
|> Stream.sum





#r "../../packages/FSharp.Collections.ParallelSeq.1.0/lib/net40/FSharp.Collections.ParallelSeq.dll"

open FSharp.Collections.ParallelSeq

data
|> PSeq.filter (fun x -> x % 2L = 0L)
|> PSeq.map (fun x -> x + 1L)
|> PSeq.sum

data
|> ParStream.ofArray
|> ParStream.filter (fun x -> x % 2L = 0L)
|> ParStream.map (fun x -> x + 1L)
|> ParStream.sum

    

