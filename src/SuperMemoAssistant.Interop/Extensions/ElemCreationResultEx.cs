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
// Created On:   2019/04/16 17:43
// Modified On:  2019/04/16 18:29
// Modified By:  Alexis

#endregion




using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperMemoAssistant.Interop.SuperMemo.Elements.Models;

namespace SuperMemoAssistant.Extensions
{
  public static class ElemCreationResultEx
  {
    #region Methods

    public static string GetErrorString(this List<ElemCreationResult> results)
    {
      StringBuilder errorStr = new StringBuilder();
      var tooManyChildrenErrors = results.Where(r => r.Result.HasFlag(ElemCreationResultCodes.ErrorTooManyChildren))
                                         .Select(r => r.Builder.Title.Truncate(40))
                                         .ToList();
      var unknownErrors = results.Where(r => r.Success == false)
                                 .Select(r => r.Builder.Title.Truncate(40))
                                 .ToList();

      if (tooManyChildrenErrors.Any() == false && unknownErrors.Any() == false)
        return null;

      errorStr.Append("Some elements could not be inserted.");

      if (tooManyChildrenErrors.Any())
      {
        errorStr.Append("\r\n\r\n=> Branch children limit reached:\r\n");
        errorStr.Append(StringEx.Join("\r\n", tooManyChildrenErrors));
      }

      if (unknownErrors.Any())
      {
        errorStr.Append("\r\n\r\n=> Unknown error:\r\n");
        errorStr.Append(StringEx.Join("\r\n", unknownErrors));
      }

      return errorStr.ToString();
    }

    #endregion
  }
}
