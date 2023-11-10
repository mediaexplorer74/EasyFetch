﻿// Decompiled with JetBrains decompiler
// Type: NiL.JS.Expressions.BitwiseNegation
// Assembly: NiL.JS, Version=2.5.1514.0, Culture=neutral, PublicKeyToken=fa941a7c2a4de689
// MVID: 02CF2D1B-C531-464C-A1C8-3EDB7D11C54C
// Assembly location: C:\Users\Admin\Desktop\RE\XAML.UI\NiL.JS.dll

using NiL.JS.Core;

namespace NiL.JS.Expressions
{
  public sealed class BitwiseNegation : Expression
  {
    protected internal override PredictedType ResultType => PredictedType.Int;

    internal override bool ResultInTempContainer => true;

    public BitwiseNegation(Expression first)
      : base(first, (Expression) null, true)
    {
    }

    public override JSValue Evaluate(Context context)
    {
      this._tempContainer._iValue = ~Tools.JSObjectToInt32(this._left.Evaluate(context));
      this._tempContainer._valueType = JSValueType.Integer;
      return this._tempContainer;
    }

    public override T Visit<T>(Visitor<T> visitor) => visitor.Visit(this);

    public override string ToString() => "~" + this._left?.ToString();
  }
}