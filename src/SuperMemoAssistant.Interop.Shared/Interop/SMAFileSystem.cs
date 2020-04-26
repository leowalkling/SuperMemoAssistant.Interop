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
// Modified On:  2020/04/06 19:46
// Modified By:  Alexis

#endregion




namespace SuperMemoAssistant.Interop
{
  using System;
  using System.IO;
  using global::Extensions.System.IO;

  /// <summary>Defines constants to access the various core files of SMA and its plugins</summary>
  public static class SMAFileSystem
  {
    #region Constants & Statics

    /// <summary>The sma folder inside a user's collection -- used for collection-specific configuration files</summary>
    public const string CollectionSMAFolder = "sma";

    /// <summary>The config folder name for sma- and collection-specific configuration files</summary>
    public const string ConfigsFolder = "configs";

    /// <summary>SMA's root folder under %LocalAppData%</summary>
    public static DirectoryPath AppRootDir =>
      Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        SMAConst.Name
      );

    /// <summary>SMA's data folder (under user profile) TODO: Make this configurable</summary>
    public static DirectoryPath AppDataRootDir =>
      Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
        SMAConst.Name
      );

    /// <summary>SMA's log folder</summary>
    public static DirectoryPath LogDir => AppDataRootDir.Combine("Logs");

    /// <summary>SMA's configs folder</summary>
    public static DirectoryPath ConfigDir => AppDataRootDir.Combine("Configs");

    /// <summary>SMA's configs folder for configuration shared between all modules (core, plugins, ..)</summary>
    public static DirectoryPath SharedConfigDir => ConfigDir.Combine("Shared");

    /// <summary>SMA's data folder</summary>
    public static DirectoryPath DataDir => AppDataRootDir.Combine("Data");

    /// <summary>SMA's root folder all things-plugin</summary>
    public static DirectoryPath PluginDir => AppDataRootDir.Combine("Plugins");

    /// <summary>SMA's plugins' package folder (contains installed plugin packages and their dependencies')</summary>
    public static DirectoryPath PluginPackageDir => PluginDir.Combine("Packages");

    /// <summary>SMA's development plugins root folder</summary>
    public static DirectoryPath PluginDevelopmentDir => PluginDir.Combine("Development");

    /// <summary>SMA's home folder for plugins. Each plugin has a subfolder inside this folder.</summary>
    public static DirectoryPath PluginHomeDir => PluginDir.Combine("Home");

    /// <summary>SMA's plugins global configuration file</summary>
    public static FilePath PluginConfigFile => PluginDir.CombineFile("plugins.json");

    /// <summary>Path to PluginHost.exe for the current executing assembly. Internal use only</summary>
    public static FilePath PluginHostExeFile => GetAppExeFilePath(SMAConst.Assembly.PluginHostExe);

    /// <summary>Path to SuperMemoAssistant.InjectLib.dll for the current executing assembly. Internal use only</summary>
    public static FilePath InjectionLibFile => GetAppExeFilePath(SMAConst.Assembly.SMInjectionLib);

    /// <summary>Path to Update.exe</summary>
    public static FilePath UpdaterExeFile => AppRootDir.CombineFile(SMAConst.Assembly.Updater);

    public static FilePath TempErrorLog => Path.Combine(Path.GetTempPath(), "SuperMemoAssistant.log");

    #endregion




    #region Methods

    /// <summary>Returns the path to a file in executing assembly's folder. Internal use only</summary>
    /// <param name="filename">The filename to append</param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException">Calling method isn't hosted in SMA</exception>
    public static FilePath GetAppExeFilePath(string filename)
    {
      if (SMAExecutableInfo.Instance.ExecutableType == SMAExecutableType.SuperMemoAssistant)
        return SMAExecutableInfo.Instance.DirectoryPath.CombineFile(filename);

      throw new InvalidOperationException("GetAppExeFilePath getter is only available for SuperMemoAssistant");
    }

    #endregion
  }
}
