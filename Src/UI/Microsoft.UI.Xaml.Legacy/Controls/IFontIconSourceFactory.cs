﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.UI.Xaml.Controls.IFontIconSourceFactory
// Assembly: Microsoft.UI.Xaml, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 5D34FD20-A2B7-40F5-936E-445C45E7C376
// Assembly location: C:\Users\Admin\Desktop\RE\XAML.UI\Microsoft.UI.Xaml.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
  [Guid(2346514109, 64518, 17080, 179, 11, 117, 5, 8, 42, 195, 142)]
  [ExclusiveTo(typeof (FontIconSource))]
  [Version(65536)]
  internal interface IFontIconSourceFactory
  {
    FontIconSource CreateInstance([In] object outer, out object inner);
  }
}