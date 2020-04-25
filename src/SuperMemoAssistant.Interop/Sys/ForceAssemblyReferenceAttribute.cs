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
// Created On:   2019/02/22 14:27
// Modified On:  2019/02/22 14:28
// Modified By:  Alexis

#endregion




using System;

namespace SuperMemoAssistant.Sys
{
  /// <summary>
  /// Forces an assembly to be loaded by referencing it with this attribute in the dependent assembly
  /// </summary>
  [AttributeUsage(AttributeTargets.Assembly)]
  public class ForceAssemblyReferenceAttribute : Attribute
  {
    #region Constructors

    /// <inheritdoc />
    public ForceAssemblyReferenceAttribute(Type forcedType)
    {
      void Noop(Type t)
      {
        System.Console.WriteLine(t.Name);
      }

      Noop(forcedType);
    }

    #endregion
  }
}
