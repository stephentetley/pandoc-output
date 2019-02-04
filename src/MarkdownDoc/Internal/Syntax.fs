﻿// Copyright (c) Stephen Tetley 2019
// License: BSD 3 Clause

namespace MarkdownDoc.Internal

// Explicitly open all Internal modules.

module Syntax = 

    open System.Text
    open MarkdownDoc.Internal.Common

    // ************************************************************************
    // Syntax

    /// Note - rendering VCatText writes an explicit Markdown 
    /// line break (two trailing spaces) to the output and 
    /// then a new line
    type MdText =
        | NoText
        | String of string
        | HCatText of MdText * MdText
        | VCatText of MdText * MdText

    type MdPara = 
        | Text of MdText 
        | UnorderedList of MdPara list
        | OrderedList of MdPara list
        | VCatPara of MdPara * MdPara 

    type Alignment = AlignDefault | AlignLeft | AlignCenter | AlignRight

    type TableCell = 
        | TableCell of Alignment * int * MdPara

    type TableRow = TableCell list

    type MdDoc = 
        | Paragraph of MdPara
        | Table of TableRow option * TableRow list
        | CodeBlock of MdPara
        | VCatDoc of MdDoc * MdDoc



    // ************************************************************************
    // Render

    let inline prefixLine (prefix:string) (lineText:string) : string = 
        prefix + lineText

    let padListItem (pad1:string, pad2:string) (body:string) : string = 
        let work xs = 
            match xs with
            | [] -> []
            | x :: xs -> (prefixLine pad1 x) :: List.map (prefixLine pad2) xs
        toLines body |> work |> fromLines


    let unorderedListItem (body:string) : string = 
        padListItem ("*  ", "   ") body

    let orderedListItem (n:int) (body:string) : string = 
        let prefix1 = sprintf "%d.  " n
        let prefix2 = String.replicate (String.length prefix1) " "
        padListItem (prefix1,prefix2) body


    /// Note an item may be a multiline string
    let unordered (items:string list) : string = 
        List.map unorderedListItem items |> fromLines

    /// Note an item may be a multiline string
    let ordered (items:string list) : string = 
        let (xs,_) = List.mapFold (fun n item -> (orderedListItem n item, n+1)) 1 items
        xs |> fromLines

    let renderMdText (text:MdText) : string = 
        let rec work (acc:StringBuilder) (doc:MdText) (cont : StringBuilder -> string) = 
            match doc with
            | NoText -> cont acc
            | String str -> 
                cont (acc.Append(str))
            | HCatText(d1,d2) -> 
                work acc d1 (fun acc1 ->
                work acc1 d2 cont)
            | VCatText(d1,d2) -> 
                work acc d1 (fun acc1 ->
                work (acc1.AppendLine("  ")) d2 cont)
        let sb = new StringBuilder ()
        work sb text (fun x -> x.ToString()) 


    let renderMdPara (para:MdPara) : string =  
        let rec work (acc:StringBuilder) (doc:MdPara) (cont:StringBuilder -> string) = 
            match doc with
            | Text txt -> 
                let str = renderMdText txt in cont (acc.Append(str)) 
            | UnorderedList xs ->
                workList [] xs (fun str ->
                cont (acc.Append(unordered str)))
            | OrderedList xs ->
                workList [] xs (fun str ->
                cont (acc.Append(ordered str)))
            | VCatPara(d1,d2) -> 
                work acc d1 (fun acc1 ->
                work (acc1.AppendLine()) d2 cont)
        and workList (acc:string list) (docs:MdPara list) (cont: string list -> string) = 
            match docs with
            | [] -> cont (List.rev acc)
            | d :: ds -> 
                work (new StringBuilder()) d (fun sb1 -> 
                let str1 = sb1.ToString()
                workList (str1::acc) ds cont)
        let sb = new StringBuilder () 
        work sb para (fun x -> x.ToString()) 


    /// Note an item may be a multiline string
    let codeBlock (body:string) : string = 
        toLines body |> List.map (prefixLine "    ") |> fromLines


    let renderMdDoc (document:MdDoc) : string = 
        let rec work (acc:StringBuilder) (doc:MdDoc) (cont:StringBuilder -> string) = 
            match doc with
            | Paragraph para -> 
                let str = renderMdPara para
                cont (acc.AppendLine(str))

            | CodeBlock para ->
                let str = renderMdPara para |> codeBlock
                cont (acc.AppendLine(str))
            | VCatDoc(d1,d2) -> 
                work acc d1 (fun acc1 -> 
                work (acc1.AppendLine()) d2 cont)
            | _ -> cont acc
        let sb = new StringBuilder () 
        work sb document (fun x -> x.ToString()) 