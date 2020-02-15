module HtmlConverter.References

[<RequireQualifiedAccess>]
type AttributeType =
    | String
    | Int
    | Float
    | Obj
    | Func
    | Bool

type FSharpName = string

type HtmlName = string

let attributes: (FSharpName * HtmlName * AttributeType) list =
    [ "_oncut", "onCut", AttributeType.Func
      "_onpaste", "onPaste", AttributeType.Func
      "_oncompositionend", "onCompositionEnd", AttributeType.Func
      "_oncompositionstart", "onCompositionStart", AttributeType.Func
      "_oncopy", "onCopy", AttributeType.Func
      "_oncompositionupdate", "onCompositionUpdate", AttributeType.Func
      "_onfocus", "onFocus", AttributeType.Func
      "_onblur", "onBlur", AttributeType.Func
      "_onchange", "onChange", AttributeType.Func
      "_oninput", "onInput", AttributeType.Func
      "_onsubmit", "onSubmit", AttributeType.Func
      "_onload", "onLoad", AttributeType.Func
      "_onerror", "onError", AttributeType.Func
      "_onkeydown", "onKeyDown", AttributeType.Func
      "_onkeypress", "onKeyPress", AttributeType.Func
      "_onkeyup", "onKeyUp", AttributeType.Func
      "_onabort", "onAbort", AttributeType.Func
      "_oncanplay", "onCanPlay", AttributeType.Func
      "_oncanplaythrough", "onCanPlayThrough", AttributeType.Func
      "_ondurationchange", "onDurationChange", AttributeType.Func
      "_onemptied", "onEmptied", AttributeType.Func
      "_onencrypted", "onEncrypted", AttributeType.Func
      "_onended", "onEnded", AttributeType.Func
      "_onloadeddata", "onLoadedData", AttributeType.Func
      "_onloadedmetadata", "onLoadedMetadata", AttributeType.Func
      "_onloadstart", "onLoadStart", AttributeType.Func
      "_onpause", "onPause", AttributeType.Func
      "_onplay", "onPlay", AttributeType.Func
      "_onplaying", "onPlaying", AttributeType.Func
      "_onprogress", "onProgress", AttributeType.Func
      "_onratechange", "onRateChange", AttributeType.Func
      "_onseeked", "onSeeked", AttributeType.Func
      "_onseeking", "onSeeking", AttributeType.Func
      "_onstalled", "onStalled", AttributeType.Func
      "_onsuspend", "onSuspend", AttributeType.Func
      "_ontimeupdate", "onTimeUpdate", AttributeType.Func
      "_onvolumechange", "onVolumeChange", AttributeType.Func
      "_onwaiting", "onWaiting", AttributeType.Func
      "_onclick", "onClick", AttributeType.Func
      "_oncontextmenu", "onContextMenu", AttributeType.Func
      "_ondoubleclick", "onDoubleClick", AttributeType.Func
      "_ondrag", "onDrag", AttributeType.Func
      "_ondragend", "onDragEnd", AttributeType.Func
      "_ondragenter", "onDragEnter", AttributeType.Func
      "_ondragexit", "onDragExit", AttributeType.Func
      "_ondragleave", "onDragLeave", AttributeType.Func
      "_ondragover", "onDragOver", AttributeType.Func
      "_ondragstart", "onDragStart", AttributeType.Func
      "_ondrop", "onDrop", AttributeType.Func
      "_onmousedown", "onMouseDown", AttributeType.Func
      "_onmouseenter", "onMouseEnter", AttributeType.Func
      "_onmouseleave", "onMouseLeave", AttributeType.Func
      "_onmousemove", "onMouseMove", AttributeType.Func
      "_onmouseout", "onMouseOut", AttributeType.Func
      "_onmouseover", "onMouseOver", AttributeType.Func
      "_onmouseup", "onMouseUp", AttributeType.Func
      "_onselect", "onSelect", AttributeType.Func
      "_ontouchcancel", "onTouchCancel", AttributeType.Func
      "_ontouchend", "onTouchEnd", AttributeType.Func
      "_ontouchmove", "onTouchMove", AttributeType.Func
      "_ontouchstart", "onTouchStart", AttributeType.Func
      "_onscroll", "onScroll", AttributeType.Func
      "_onwheel", "onWheel", AttributeType.Func
      "_onanimationstart", "onAnimationStart", AttributeType.Func
      "_onanimationend", "onAnimationEnd", AttributeType.Func
      "_onanimationiteration", "onAnimationIteration", AttributeType.Func
      "_ontransitionend", "onTransitionEnd", AttributeType.Func
      "_defaultchecked", "defaultChecked", AttributeType.String
      "_defaultvalue", "defaultValue", AttributeType.String
      "_accept", "accept", AttributeType.String
      "_acceptcharset", "acceptCharset", AttributeType.String
      "_accesskey", "accessKey", AttributeType.String
      "_action", "action", AttributeType.String
      "_allowfullscreen", "allowFullScreen", AttributeType.String
      "_allowtransparency", "allowTransparency", AttributeType.String
      "_alt", "alt", AttributeType.String
      "_ariahaspopup", "aria-haspopup", AttributeType.String
      "_ariaexpanded", "aria-expanded", AttributeType.String
      "_async", "async", AttributeType.String
      "_autocomplete", "autoComplete", AttributeType.String
      "_autofocus", "autoFocus", AttributeType.String
      "_autoplay", "autoPlay", AttributeType.String
      "_capture", "capture", AttributeType.String
      "_cellpadding", "cellPadding", AttributeType.Obj
      "_cellspacing", "cellSpacing", AttributeType.Obj
      "_charset", "charSet", AttributeType.String
      "_challenge", "challenge", AttributeType.String
      "_checked", "checked", AttributeType.String
      "_classid", "classID", AttributeType.String
      "_classname", "className", AttributeType.String
      "_class", "class", AttributeType.String
      "_cols", "cols", AttributeType.Float
      "_colspan", "colSpan", AttributeType.Float
      "_content", "content", AttributeType.String
      "_contenteditable", "contentEditable", AttributeType.String
      "_contextmenu", "contextMenu", AttributeType.String
      "_controls", "controls", AttributeType.String
      "_coords", "coords", AttributeType.String
      "_crossorigin", "crossOrigin", AttributeType.String
      "_datetime", "dateTime", AttributeType.String
      "_default", "default", AttributeType.String
      "_defer", "defer", AttributeType.String
      "_dir", "dir", AttributeType.String
      "_disabled", "disabled", AttributeType.String
      "_download", "download", AttributeType.Obj
      "_draggable", "draggable", AttributeType.String
      "_enctype", "encType", AttributeType.String
      "_form", "form", AttributeType.String
      "_formaction", "formAction", AttributeType.String
      "_formenctype", "formEncType", AttributeType.String
      "_formmethod", "formMethod", AttributeType.String
      "_formnovalidate", "formNoValidate", AttributeType.String
      "_formtarget", "formTarget", AttributeType.String
      "_frameborder", "frameBorder", AttributeType.Obj
      "_headers", "headers", AttributeType.String
      "_height", "height", AttributeType.Obj
      "_hidden", "hidden", AttributeType.String
      "_high", "high", AttributeType.Float
      "_href", "href", AttributeType.String
      "_hreflang", "hrefLang", AttributeType.String
      "_htmlfor", "htmlFor", AttributeType.String
      "_httpequiv", "httpEquiv", AttributeType.String
      "_icon", "icon", AttributeType.String
      "_id", "id", AttributeType.String
      "_inputmode", "inputMode", AttributeType.String
      "_integrity", "integrity", AttributeType.String
      "_is", "is", AttributeType.String
      "_keyparams", "keyParams", AttributeType.String
      "_keytype", "keyType", AttributeType.String
      "_kind", "kind", AttributeType.String
      "_label", "label", AttributeType.String
      "_lang", "lang", AttributeType.String
      "_list", "list", AttributeType.String
      "_loop", "loop", AttributeType.String
      "_low", "low", AttributeType.Float
      "_manifest", "manifest", AttributeType.String
      "_marginheight", "marginHeight", AttributeType.Float
      "_marginwidth", "marginWidth", AttributeType.Float
      "_max", "max", AttributeType.Obj
      "_maxlength", "maxLength", AttributeType.Float
      "_media", "media", AttributeType.String
      "_mediagroup", "mediaGroup", AttributeType.String
      "_method", "method", AttributeType.String
      "_min", "min", AttributeType.Obj
      "_minlength", "minLength", AttributeType.Float
      "_multiple", "multiple", AttributeType.String
      "_muted", "muted", AttributeType.String
      "_name", "name", AttributeType.String
      "_novalidate", "noValidate", AttributeType.String
      "_open", "open", AttributeType.String
      "_optimum", "pptimum", AttributeType.Float
      "_pattern", "pattern", AttributeType.String
      "_placeholder", "placeholder", AttributeType.String
      "_poster", "poster", AttributeType.String
      "_preload", "preload", AttributeType.String
      "_radiogroup", "radioGroup", AttributeType.String
      "_readonly", "readOnly", AttributeType.String
      "_rel", "rel", AttributeType.String
      "_required", "required", AttributeType.String
      "_role", "role", AttributeType.String
      "_rows", "rows", AttributeType.Float
      "_rowspan", "rowSpan", AttributeType.Float
      "_sandbox", "sandbox", AttributeType.String
      "_scope", "scope", AttributeType.String
      "_scoped", "scoped", AttributeType.String
      "_scrolling", "scrolling", AttributeType.String
      "_seamless", "seamless", AttributeType.String
      "_selected", "selected", AttributeType.String
      "_shape", "shape", AttributeType.String
      "_size", "size", AttributeType.Float
      "_sizes", "sizes", AttributeType.String
      "_span", "span", AttributeType.Float
      "_spellcheck", "spellCheck", AttributeType.String
      "_src", "src", AttributeType.String
      "_srcdoc", "srcDoc", AttributeType.String
      "_srclang", "srcLang", AttributeType.String
      "_srcset", "srcSet", AttributeType.String
      "_start", "start", AttributeType.Float
      "_step", "step", AttributeType.Obj
      "_summary", "summary", AttributeType.String
      "_tabindex", "tabIndex", AttributeType.Float
      "_target", "target", AttributeType.String
      "_title", "title", AttributeType.String
      "_type", "type", AttributeType.String
      "_usemap", "useMap", AttributeType.String
      "_value", "value", AttributeType.String
      "_width", "width", AttributeType.Obj
      "_wmode", "wmode", AttributeType.String
      "_wrap", "wrap", AttributeType.String
      "_about", "about", AttributeType.String
      "_datatype", "datatype", AttributeType.String
      "_inlist", "inlist", AttributeType.Obj
      "_prefix", "prefix", AttributeType.String
      "_property", "property", AttributeType.String
      "_resource", "resource", AttributeType.String
      "_typeof", "typeof", AttributeType.String
      "_vocab", "vocab", AttributeType.String
      "_autocapitalize", "autoCapitalize", AttributeType.String
      "_autocorrect", "autoCorrect", AttributeType.String
      "_autosave", "autoSave", AttributeType.String
      "_itemprop", "itemProp", AttributeType.String
      "_itemscope", "itemScope", AttributeType.String
      "_itemtype", "itemType", AttributeType.String
      "_itemid", "itemID", AttributeType.String
      "_itemref", "itemRef", AttributeType.String
      "_results", "results", AttributeType.Float
      "_security", "security", AttributeType.String
      "_unselectable", "unselectable", AttributeType.String
      // Custom
      "_ariaHidden", "aria-hidden", AttributeType.String
      "_ariaControls", "aria-controls", AttributeType.String
      "_ariaLabel", "aria-label", AttributeType.String
      "_ariaExpanded", "aria-expanded", AttributeType.String
      "_dataTarget", "data-target", AttributeType.String
      "_dataSlideTo", "data-slide-to", AttributeType.String
      "_dataRide", "data-ride", AttributeType.String
      "_ariaCurrent", "aria-current", AttributeType.String
       ]

let cssProps: string array =
    [| "AlignContent"
       "AlignItems"
       "AlignSelf"
       "AlignmentAdjust"
       "AlignmentBaseline"
       "All"
       "Animation"
       "AnimationDelay"
       "AnimationDirection"
       "AnimationDuration"
       "AnimationFillMode"
       "AnimationIterationCount"
       "AnimationName"
       "AnimationPlayState"
       "AnimationTimingFunction"
       "Appearance"
       "BackfaceVisibility"
       "Background"
       "BackgroundAttachment"
       "BackgroundBlendMode"
       "BackgroundClip"
       "BackgroundColor"
       "BackgroundComposite"
       "BackgroundImage"
       "BackgroundOrigin"
       "BackgroundPosition"
       "BackgroundPositionX"
       "BackgroundPositionY"
       "BackgroundRepeat"
       "BackgroundSize"
       "BaselineShift"
       "Behavior"
       "BlockSize"
       "Border"
       "BorderBlockEnd"
       "BorderBlockEndColor"
       "BorderBlockEndStyle"
       "BorderBlockEndWidth"
       "BorderBlockStart"
       "BorderBlockStartColor"
       "BorderBlockStartStyle"
       "BorderBlockStartWidth"
       "BorderBottom"
       "BorderBottomColor"
       "BorderBottomLeftRadius"
       "BorderBottomRightRadius"
       "BorderBottomStyle"
       "BorderBottomWidth"
       "BorderCollapse"
       "BorderColor"
       "BorderCornerShape"
       "BorderImage"
       "BorderImageOutset"
       "BorderImageRepeat"
       "BorderImageSlice"
       "BorderImageSource"
       "BorderImageWidth"
       "BorderInlineEnd"
       "BorderInlineEndColor"
       "BorderInlineEndStyle"
       "BorderInlineEndWidth"
       "BorderInlineStart"
       "BorderInlineStartColor"
       "BorderInlineStartStyle"
       "BorderInlineStartWidth"
       "BorderLeft"
       "BorderLeftColor"
       "BorderLeftStyle"
       "BorderLeftWidth"
       "BorderRadius"
       "BorderRight"
       "BorderRightColor"
       "BorderRightStyle"
       "BorderRightWidth"
       "BorderSpacing"
       "BorderStyle"
       "BorderTop"
       "BorderTopColor"
       "BorderTopLeftRadius"
       "BorderTopRightRadius"
       "BorderTopStyle"
       "BorderTopWidth"
       "BorderWidth"
       "Bottom"
       "BoxAlign"
       "BoxDecorationBreak"
       "BoxDirection"
       "BoxFlex"
       "BoxFlexGroup"
       "BoxLineProgression"
       "BoxLines"
       "BoxOrdinalGroup"
       "BoxShadow"
       "BoxSizing"
       "BreakAfter"
       "BreakBefore"
       "BreakInside"
       "CaptionSide"
       "CaretColor"
       "Clear"
       "Clip"
       "ClipPath"
       "ClipRule"
       "Color"
       "ColorInterpolation"
       "ColorInterpolationFilters"
       "ColorProfile"
       "ColorRendering"
       "ColumnCount"
       "ColumnFill"
       "ColumnGap"
       "ColumnRule"
       "ColumnRuleColor"
       "ColumnRuleStyle"
       "ColumnRuleWidth"
       "ColumnSpan"
       "ColumnWidth"
       "Columns"
       "Content"
       "CounterIncrement"
       "CounterReset"
       "Cue"
       "CueAfter"
       "Cursor"
       "Direction"
       "Display"
       "DominantBaseline"
       "EmptyCells"
       "EnableBackground"
       "Fill"
       "FillOpacity"
       "FillRule"
       "Filter"
       "Flex"
       "FlexAlign"
       "FlexBasis"
       "FlexDirection"
       "FlexFlow"
       "FlexGrow"
       "FlexItemAlign"
       "FlexLinePack"
       "FlexOrder"
       "FlexShrink"
       "FlexWrap"
       "Float"
       "FloodColor"
       "FloodOpacity"
       "FlowFrom"
       "Font"
       "FontFamily"
       "FontFeatureSettings"
       "FontKerning"
       "FontLanguageOverride"
       "FontSize"
       "FontSizeAdjust"
       "FontStretch"
       "FontStyle"
       "FontSynthesis"
       "FontVariant"
       "FontVariantAlternates"
       "FontVariantCaps"
       "FontVariantEastAsian"
       "FontVariantLigatures"
       "FontVariantNumeric"
       "FontVariantPosition"
       "FontWeight"
       "GlyphOrientationHorizontal"
       "GlyphOrientationVertical"
       "Grid"
       "GridArea"
       "GridAutoColumns"
       "GridAutoFlow"
       "GridAutoRows"
       "GridColumn"
       "GridColumnEnd"
       "GridColumnGap"
       "GridColumnStart"
       "GridGap"
       "GridRow"
       "GridRowEnd"
       "GridRowGap"
       "GridRowPosition"
       "GridRowSpan"
       "GridRowStart"
       "GridTemplate"
       "GridTemplateAreas"
       "GridTemplateColumns"
       "GridTemplateRows"
       "HangingPunctuation"
       "Height"
       "HyphenateLimitChars"
       "HyphenateLimitLines"
       "HyphenateLimitZone"
       "Hyphens"
       "ImageOrientation"
       "ImageRendering"
       "ImageResolution"
       "ImeMode"
       "InlineSize"
       "Isolation"
       "JustifyContent"
       "Kerning"
       "LayoutGrid"
       "LayoutGridChar"
       "LayoutGridLine"
       "LayoutGridMode"
       "LayoutGridType"
       "Left"
       "LetterSpacing"
       "LightingColor"
       "LineBreak"
       "LineClamp"
       "LineHeight"
       "ListStyle"
       "ListStyleImage"
       "ListStylePosition"
       "ListStyleType"
       "Margin"
       "MarginBlockEnd"
       "MarginBlockStart"
       "MarginBottom"
       "MarginInlineEnd"
       "MarginInlineStart"
       "MarginLeft"
       "MarginRight"
       "MarginTop"
       "MarkerEnd"
       "MarkerMid"
       "MarkerStart"
       "MarqueeDirection"
       "MarqueeStyle"
       "Mask"
       "MaskBorder"
       "MaskBorderRepeat"
       "MaskBorderSlice"
       "MaskBorderSource"
       "MaskBorderWidth"
       "MaskClip"
       "MaskComposite"
       "MaskImage"
       "MaskMode"
       "MaskOrigin"
       "MaskPosition"
       "MaskRepeat"
       "MaskSize"
       "MaskType"
       "MaxFontSize"
       "MaxHeight"
       "MaxWidth"
       "MinBlockSize"
       "MinHeight"
       "MinInlineSize"
       "MinWidth"
       "MixBlendMode"
       "ObjectFit"
       "ObjectPosition"
       "OffsetBlockEnd"
       "OffsetBlockStart"
       "OffsetInlineEnd"
       "OffsetInlineStart"
       "Opacity"
       "Order"
       "Orphans"
       "Outline"
       "OutlineColor"
       "OutlineOffset"
       "OutlineStyle"
       "OutlineWidth"
       "Overflow"
       "OverflowStyle"
       "OverflowWrap"
       "OverflowX"
       "OverflowY"
       "Padding"
       "PaddingBlockEnd"
       "PaddingBlockStart"
       "PaddingBottom"
       "PaddingInlineEnd"
       "PaddingInlineStart"
       "PaddingLeft"
       "PaddingRight"
       "PaddingTop"
       "PageBreakAfter"
       "PageBreakBefore"
       "PageBreakInside"
       "Pause"
       "PauseAfter"
       "PauseBefore"
       "Perspective"
       "PerspectiveOrigin"
       "PointerEvents"
       "Position"
       "PunctuationTrim"
       "Quotes"
       "RegionFragment"
       "Resize"
       "RestAfter"
       "RestBefore"
       "Right"
       "RubyAlign"
       "RubyMerge"
       "RubyPosition"
       "ScrollBehavior"
       "ScrollSnapCoordinate"
       "ScrollSnapDestination"
       "ScrollSnapType"
       "ShapeImageThreshold"
       "ShapeInside"
       "ShapeMargin"
       "ShapeOutside"
       "ShapeRendering"
       "Speak"
       "SpeakAs"
       "StopColor"
       "StopOpacity"
       "Stroke"
       "StrokeDasharray"
       "StrokeDashoffset"
       "StrokeLinecap"
       "StrokeLinejoin"
       "StrokeMiterlimit"
       "StrokeOpacity"
       "StrokeWidth"
       "TabSize"
       "TableLayout"
       "TextAlign"
       "TextAlignLast"
       "TextAnchor"
       "TextCombineUpright"
       "TextDecoration"
       "TextDecorationColor"
       "TextDecorationLine"
       "TextDecorationLineThrough"
       "TextDecorationNone"
       "TextDecorationOverline"
       "TextDecorationSkip"
       "TextDecorationStyle"
       "TextDecorationUnderline"
       "TextEmphasis"
       "TextEmphasisColor"
       "TextEmphasisPosition"
       "TextEmphasisStyle"
       "TextHeight"
       "TextIndent"
       "TextJustify"
       "TextJustifyTrim"
       "TextKashidaSpace"
       "TextLineThrough"
       "TextLineThroughColor"
       "TextLineThroughMode"
       "TextLineThroughStyle"
       "TextLineThroughWidth"
       "TextOrientation"
       "TextOverflow"
       "TextOverline"
       "TextOverlineColor"
       "TextOverlineMode"
       "TextOverlineStyle"
       "TextOverlineWidth"
       "TextRendering"
       "TextScript"
       "TextShadow"
       "TextTransform"
       "TextUnderlinePosition"
       "TextUnderlineStyle"
       "Top"
       "TouchAction"
       "Transform"
       "TransformBox"
       "TransformOrigin"
       "TransformOriginZ"
       "TransformStyle"
       "Transition"
       "TransitionDelay"
       "TransitionDuration"
       "TransitionProperty"
       "TransitionTimingFunction"
       "UnicodeBidi"
       "UnicodeRange"
       "UserFocus"
       "UserInput"
       "VerticalAlign"
       "Visibility"
       "VoiceBalance"
       "VoiceDuration"
       "VoiceFamily"
       "VoicePitch"
       "VoiceRange"
       "VoiceRate"
       "VoiceStress"
       "VoiceVolume"
       "WhiteSpace"
       "WhiteSpaceTreatment"
       "Widows"
       "Width"
       "WillChange"
       "WordBreak"
       "WordSpacing"
       "WordWrap"
       "WrapFlow"
       "WrapMargin"
       "WrapOption"
       "WritingMode"
       "ZIndex"
       "Zoom" |]
