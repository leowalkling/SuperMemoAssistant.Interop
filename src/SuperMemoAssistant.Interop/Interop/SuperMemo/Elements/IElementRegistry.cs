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
// Modified On:  2020/04/07 05:42
// Modified By:  Alexis

#endregion




namespace SuperMemoAssistant.Interop.SuperMemo.Elements
{
  using System;
  using System.Collections.Generic;
  using Builders;
  using Core;
  using Models;
  using Registry.Types;
  using Types;

  /// <summary>The <see cref="IElement" /> registry</summary>
  [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1710:Identifiers should have correct suffix", Justification = "<Pending>")]
  public interface IElementRegistry : IRegistry<IElement>
  {
    /// <summary>The root element (id 1)</summary>
    IElement Root { get; }

    /// <summary>Adds a new elements in the user's Collection</summary>
    /// <param name="failed">Elements that failed to be created</param>
    /// <param name="options">Defines optional settings for creating the elements</param>
    /// <param name="builders">The new elements' definitions</param>
    /// <returns>Success of operation</returns>
    bool Add(out List<ElemCreationResult> failed, ElemCreationFlags options, params ElementBuilder[] builders);

    /// <summary>Deletes the element <paramref name="element" /></summary>
    /// <param name="element"></param>
    /// <returns>Success of operation</returns>
    bool Delete(IElement element);

    /// <summary>Raised when a new element has been created. See <see cref="SMElementEventArgs" /></summary>
    event Action<SMElementEventArgs> OnElementCreated;

    /// <summary>Raised when an element has been modified. See <see cref="SMElementChangedEventArgs" /></summary>
    event Action<SMElementChangedEventArgs> OnElementModified;

    /// <summary>Raised when an element has been deleted. See <see cref="SMElementEventArgs" /></summary>
    event Action<SMElementEventArgs> OnElementDeleted;
  }
}
