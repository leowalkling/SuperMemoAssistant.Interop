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
// Modified On:  2020/04/07 09:05
// Modified By:  Alexis

#endregion




namespace SuperMemoAssistant.Interop.Plugins
{
  using System;
  using System.Collections.Generic;
  using System.Diagnostics;
  using System.Diagnostics.CodeAnalysis;
  using PluginManager.Interop.Contracts;
  using PluginManager.Interop.PluginHost;
  using SuperMemo;

  /// <inheritdoc />
  [SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces")]
  public class PluginHost : PluginHostBase<ISuperMemoAssistant>
  {
    #region Properties & Fields - Non-Public

    /// <inheritdoc />
    protected override HashSet<Type> CoreInterfaceTypes { get; } = new HashSet<Type>
    {
      typeof(ISuperMemoAssistant)
      // Insert subsequent versions here
    };

    /// <inheritdoc />
    protected override HashSet<Type> PluginMgrInterfaceTypes { get; } = new HashSet<Type>
    {
      typeof(IPluginManager<ISuperMemoAssistant>)
      // Insert subsequent versions here
    };

    #endregion




    #region Constructors

    /// <inheritdoc />
    public PluginHost(
      string  pluginPackageName,
      Guid    sessionGuid,
      string  smaChannelName,
      Process smaProcess,
      bool    isDev)
      : base(pluginPackageName, sessionGuid, smaChannelName, smaProcess, isDev) { }

    #endregion
  }
}
