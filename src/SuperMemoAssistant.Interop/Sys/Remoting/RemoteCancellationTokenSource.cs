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
// Created On:   2019/02/23 13:50
// Modified On:  2019/02/23 14:39
// Modified By:  Alexis

#endregion




using System;
using System.Threading;

namespace SuperMemoAssistant.Sys.Remoting
{
  public sealed class RemoteCancellationTokenSource : IDisposable
  {
    #region Properties & Fields - Non-Public

    private readonly CancellationTokenSource _tokenSrc;

    #endregion




    #region Constructors

    public RemoteCancellationTokenSource()
    {
      _tokenSrc = new CancellationTokenSource();

      Token = new RemoteCancellationToken(_tokenSrc.Token);
    }

    /// <inheritdoc />
    public void Dispose()
    {
      _tokenSrc?.Dispose();
    }

    #endregion




    #region Properties & Fields - Public

    public bool                    IsCancellationRequested => _tokenSrc.IsCancellationRequested;
    public RemoteCancellationToken Token                   { get; }

    #endregion




    #region Methods

    public static implicit operator CancellationTokenSource(RemoteCancellationTokenSource remoteTokenSrc)
    {
      return remoteTokenSrc._tokenSrc;
    }

    public void Cancel()
    {
      _tokenSrc.Cancel();
    }

    public void CancelAfter(int millisecondDelay)
    {
      _tokenSrc.CancelAfter(millisecondDelay);
    }

    public void CancelAfter(TimeSpan delay)
    {
      _tokenSrc.CancelAfter(delay);
    }

    #endregion
  }
}
