﻿#region License & Metadata

// The MIT License (MIT)
// 
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// 
// 
// Created On:   2020/03/29 00:21
// Modified On:  2020/04/07 05:05
// Modified By:  Alexis

#endregion




namespace SuperMemoAssistant.Interop.SuperMemo.Elements.Models
{
  using System;

  /// <summary>Defines the success or failure of the element creation operation</summary>
  [Serializable]
  [Flags]
  public enum ElemCreationResultCodes
  {
    /// <summary>The element was successfully created</summary>
    Success = 1,

    /// <summary>The concept is not set</summary>
    WarningConceptNotSet = 4,

    /// <summary>The parent branch has reached its maximum children capacity</summary>
    ErrorTooManyChildren = 64,

    /// <summary>An unknown error occured, check the logs for more information</summary>
    ErrorUnknown = 128
  }
}
