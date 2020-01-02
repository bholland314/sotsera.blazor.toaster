﻿// Copyright (c) Alessandro Ghidini. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Sotsera.Blazor.Toaster.Core.Models
{
    public static class Defaults
    {
        public static class Classes
        {
            public const string Toast = "toaster";
            public const string ToastTitle = "toast-title";
            public const string ToastMessage = "toast-message";
            public const string CloseIconClass = "toast-close-button";
            public const string ProgressBarClass = "toast-progress";
            public static class TextPosition
            {
                public const string Left = "text-left";
                public const string Center = "text-center";
                public const string Right = "text-right";
            }
            public static class Position
            {
                public const string TopCenter = "toast-top-center";
                public const string BottomCenter = "toast-bottom-center";
                public const string TopFullWidth = "toast-top-full-width";
                public const string BottomFullWidth = "toast-bottom-full-width";
                public const string TopLeft = "toast-top-left";
                public const string TopRight = "toast-top-right";
                public const string BottomRight = "toast-bottom-right";
                public const string BottomLeft = "toast-bottom-left";
            }

            public static class Icons
            {
                public const string Info = "alert-primary";
                public const string Success = "alert-success";
                public const string Warning = "alert-warning";
                public const string Error = "alert-danger";

                //public const string Info = "toast-info";
                //public const string Success = "toast-success";
                //public const string Warning = "toast-warning";
                //public const string Error = "toast-error";
            }
        }
    }
}