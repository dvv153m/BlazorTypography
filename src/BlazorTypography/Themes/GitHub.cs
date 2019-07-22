﻿using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    internal class GitHub : BaseTypographyOptions
    {
        public override string Title { get; set; } = "GitHub";
        public override string BaseFontSize { get; set; } = "16px";
        public override string BaseLineHeight { get; set; } = "1.625";
        public override List<string> BodyFontFamily { get; set; } = new List<string>
        {
            "-apple-system",
            "BlinkMacSystemFont",
            "Segoe UI",
            "Roboto",
            "Helvetica",
            "Arial",
            "sans-serif",
            "Apple Color Emoji",
            "Segoe UI Emoji",
            "Segoe UI Symbol"
        };
        public override double? ScaleRatio { get; set; } = 2;
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.8)";
        public override string BodyWeight { get; set; } = "normal";
        public override string HeaderColor { get; set; } = "hsla(0,0%,0%,0.9)";
        public override List<string> HeaderFontFamily { get; set; } = new List<string>
        {
            "-apple-system",
            "BlinkMacSystemFont",
            "Segoe UI",
            "Roboto",
            "Helvetica",
            "Arial",
            "sans-serif",
            "Apple Color Emoji",
            "Segoe UI Emoji",
            "Segoe UI Symbol"
        };
        public override string HeaderWeight { get; set; } = "600";
        public override string BoldWeight { get; set; } = "600";
        public override string BlockMarginBottom { get; set; } = "0.5";
        public override Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>> OverrideStyles { get; set; } =
            new Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>>((vr, options) =>
            {
                List<KeyValuePair<string, string>> ret = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("h1", $@"
                    border-bottom: 1px solid {vr.Gray(93)};
                    padding-bottom: calc({vr.Rhythm(1 / 4f)} - 1px);
                    margin-bottom: {vr.Rhythm(3 / 4f)};
                    margin-top: {vr.Rhythm(1.5f)};
                "),
                    new KeyValuePair<string, string>("h2", $@"
                    border-bottom: 1px solid {vr.Gray(93)};
                    padding-bottom: calc({vr.Rhythm(1 / 4f)} - 1px);
                    margin-bottom: {vr.Rhythm(1 / 4f)};
                    margin-top: {vr.Rhythm(1f)};
                "),
                    new KeyValuePair<string, string>("h6", @"
                    color: {vr.Gray(47)};
                "),
                    new KeyValuePair<string, string>("h3,h4,h5,h6", $@"
                    margin-bottom: {vr.Rhythm(1 / 2f)};
                    margin-top: {vr.Rhythm(1f)};
                "),
                    new KeyValuePair<string, string>("ol,ul", $@"
                    margin-left: rhythm(1.25f);
                "),
                    new KeyValuePair<string, string>("li>ol,li>ul", $@"
                    margin-left: rhythm(1.25f);
                "),
                    new KeyValuePair<string, string>("a", @"
                    color: #4078c0;
                    text-decoration: none;
                "),
                    new KeyValuePair<string, string>("a:hover,a:active", "text-decoration: underline;"),
                    new KeyValuePair<string, string>("blockquote", $@"
                    border-left: 4px solid {vr.Gray(87)};
                    color: {vr.Gray(47)};
                    margin-top: 0,
                    margin-right: 0,
                    margin-left: 0,
                    padding-left: calc({vr.Rhythm(1 / 2f)} - 1px);
                ")
                };
                return ret;
            });
    }
}