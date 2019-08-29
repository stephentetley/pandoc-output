﻿// Copyright (c) Stephen Tetley 2019
// License: BSD 3 Clause

namespace MarkdownDoc.Markdown


module CssColors = 
    
    open MarkdownDoc.Markdown.InlineHtml

    type ColorName = string

    
    let aliceBlue : ColorName = "AliceBlue"
    let antiqueWhite : ColorName = "AntiqueWhite"
    let aqua : ColorName = "Aqua"
    let aquamarine : ColorName = "Aquamarine"
    let azure : ColorName = "Azure"
    let beige : ColorName = "Beige"
    let bisque : ColorName = "Bisque"
    let black : ColorName = "Black"
    let blanchedAlmond : ColorName = "BlanchedAlmond"
    let blue : ColorName = "Blue"
    let blueViolet : ColorName = "BlueViolet"
    let brown : ColorName = "Brown"
    let burlyWood : ColorName = "BurlyWood"
    let cadetBlue : ColorName = "CadetBlue"
    let chartreuse : ColorName = "Chartreuse"
    let chocolate : ColorName = "Chocolate"
    let coral : ColorName = "Coral"
    let cornflowerBlue : ColorName = "CornflowerBlue"
    let cornsilk : ColorName = "Cornsilk"
    let crimson : ColorName = "Crimson"
    let cyan : ColorName = "Cyan"
    let darkBlue : ColorName = "DarkBlue"
    let darkCyan : ColorName = "DarkCyan"
    let darkGoldenRod : ColorName = "DarkGoldenRod"
    let darkGray : ColorName = "DarkGray"
    let darkGrey : ColorName = "DarkGrey"
    let darkGreen : ColorName = "DarkGreen"
    let darkKhaki : ColorName = "DarkKhaki"
    let darkMagenta : ColorName = "DarkMagenta"
    let darkOliveGreen : ColorName = "DarkOliveGreen"
    let darkOrange : ColorName = "DarkOrange"
    let darkOrchid : ColorName = "DarkOrchid"
    let darkRed : ColorName = "DarkRed"
    let darkSalmon : ColorName = "DarkSalmon"
    let darkSeaGreen : ColorName = "DarkSeaGreen"
    let darkSlateBlue : ColorName = "DarkSlateBlue"
    let darkSlateGray : ColorName = "DarkSlateGray"
    let darkSlateGrey : ColorName = "DarkSlateGrey"
    let darkTurquoise : ColorName = "DarkTurquoise"
    let darkViolet : ColorName = "DarkViolet"
    let deepPink : ColorName = "DeepPink"
    let deepSkyBlue : ColorName = "DeepSkyBlue"
    let dimGray : ColorName = "DimGray"
    let dimGrey : ColorName = "DimGrey"
    let dodgerBlue : ColorName = "DodgerBlue"
    let fireBrick : ColorName = "FireBrick"
    let floralWhite : ColorName = "FloralWhite"
    let forestGreen : ColorName = "ForestGreen"
    let fuchsia : ColorName = "Fuchsia"
    let gainsboro : ColorName = "Gainsboro"
    let ghostWhite : ColorName = "GhostWhite"
    let gold : ColorName = "Gold"
    let goldenRod : ColorName = "GoldenRod"
    let gray : ColorName = "Gray"
    let grey : ColorName = "Grey"
    let green : ColorName = "Green"
    let greenYellow : ColorName = "GreenYellow"
    let honeyDew : ColorName = "HoneyDew"
    let hotPink : ColorName = "HotPink"
    let indianRed : ColorName = "IndianRed"
    let indigo : ColorName = "Indigo"
    let ivory : ColorName = "Ivory"
    let khaki : ColorName = "Khaki"
    let lavender : ColorName = "Lavender"
    let lavenderBlush : ColorName = "LavenderBlush"
    let lawnGreen : ColorName = "LawnGreen"
    let lemonChiffon : ColorName = "LemonChiffon"
    let lightBlue : ColorName = "LightBlue"
    let lightCoral : ColorName = "LightCoral"
    let lightCyan : ColorName = "LightCyan"
    let lightGoldenRodYellow : ColorName = "LightGoldenRodYellow"
    let lightGray : ColorName = "LightGray"
    let lightGrey : ColorName = "LightGrey"
    let lightGreen : ColorName = "LightGreen"
    let lightPink : ColorName = "LightPink"
    let lightSalmon : ColorName = "LightSalmon"
    let lightSeaGreen : ColorName = "LightSeaGreen"
    let lightSkyBlue : ColorName = "LightSkyBlue"
    let lightSlateGray : ColorName = "LightSlateGray"
    let lightSlateGrey : ColorName = "LightSlateGrey"
    let lightSteelBlue : ColorName = "LightSteelBlue"
    let lightYellow : ColorName = "LightYellow"
    let lime : ColorName = "Lime"
    let limeGreen : ColorName = "LimeGreen"
    let linen : ColorName = "Linen"
    let magenta : ColorName = "Magenta"
    let maroon : ColorName = "Maroon"
    let mediumAquaMarine : ColorName = "MediumAquaMarine"
    let mediumBlue : ColorName = "MediumBlue"
    let mediumOrchid : ColorName = "MediumOrchid"
    let mediumPurple : ColorName = "MediumPurple"
    let mediumSeaGreen : ColorName = "MediumSeaGreen"
    let mediumSlateBlue : ColorName = "MediumSlateBlue"
    let mediumSpringGreen : ColorName = "MediumSpringGreen"
    let mediumTurquoise : ColorName = "MediumTurquoise"
    let mediumVioletRed : ColorName = "MediumVioletRed"
    let MidnightBlue : ColorName = "MidnightBlue"
    let mintCream : ColorName = "MintCream"
    let mistyRose : ColorName = "MistyRose"
    let moccasin : ColorName = "Moccasin"
    let navajoWhite : ColorName = "NavajoWhite"
    let navy : ColorName = "Navy"
    let oldLace : ColorName = "OldLace"
    let olive : ColorName = "Olive"
    let oliveDrab : ColorName = "OliveDrab"
    let orange : ColorName = "Orange"
    let orangeRed : ColorName = "OrangeRed"
    let orchid : ColorName = "Orchid"
    let paleGoldenRod : ColorName = "PaleGoldenRod"
    let paleGreen : ColorName = "PaleGreen"
    let paleTurquoise : ColorName = "PaleTurquoise"
    let paleVioletRed : ColorName = "PaleVioletRed"
    let papayaWhip : ColorName = "PapayaWhip"
    let peachPuff : ColorName = "PeachPuff"
    let peru : ColorName = "Peru"
    let pink : ColorName = "Pink"
    let plum : ColorName = "Plum"
    let powderBlue : ColorName = "PowderBlue"
    let purple : ColorName = "Purple"
    let rebeccaPurple : ColorName = "RebeccaPurple"
    let red : ColorName = "Red"
    let rosyBrown : ColorName = "RosyBrown"
    let royalBlue : ColorName = "RoyalBlue"
    let saddleBrown : ColorName = "SaddleBrown"
    let salmon : ColorName = "Salmon"
    let sandyBrown : ColorName = "SandyBrown"
    let seaGreen : ColorName = "SeaGreen"
    let seaShell : ColorName = "SeaShell"
    let sienna : ColorName = "Sienna"
    let silver : ColorName = "Silver"
    let skyBlue : ColorName = "SkyBlue"
    let slateBlue : ColorName = "SlateBlue"
    let slateGray : ColorName = "SlateGray"
    let slateGrey : ColorName = "SlateGrey"
    let snow : ColorName = "Snow"
    let springGreen : ColorName = "SpringGreen"
    let steelBlue : ColorName = "SteelBlue"
    let tan : ColorName = "Tan"
    let teal : ColorName = "Teal"
    let thistle : ColorName = "Thistle"
    let tomato : ColorName = "Tomato"
    let turquoise : ColorName = "Turquoise"
    let violet : ColorName = "Violet"
    let wheat : ColorName = "Wheat"
    let white : ColorName = "White"
    let whiteSmoke : ColorName = "WhiteSmoke"
    let yellow : ColorName = "Yellow"
    let yellowGreen : ColorName = "YellowGreen"
    