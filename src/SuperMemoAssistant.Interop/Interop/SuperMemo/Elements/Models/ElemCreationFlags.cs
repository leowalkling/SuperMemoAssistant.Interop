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
// Created On:   2019/04/16 13:38
// Modified On:  2019/04/16 17:28
// Modified By:  Alexis

#endregion




using System;

namespace SuperMemoAssistant.Interop.SuperMemo.Elements.Models
{
  /// <summary>
  /// Defines available options when creating a new element with SMA
  /// </summary>
  [Flags]
  [Serializable]
  public enum ElemCreationFlags
  {
    /// <summary>
    /// Default (no option)
    /// </summary>
    None = 0,

    /// <summary>
    ///   This will insert new elements, even if their parent branch has reached max. children
    ///   capacity
    /// </summary>
    ForceCreate = 1,

    /// <summary>Automatically create a folder hierarchy to prevent children overflow in a branch</summary>
    CreateSubfolders = 2,
  }
}
