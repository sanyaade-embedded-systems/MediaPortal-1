#region Copyright (C) 2005-2011 Team MediaPortal

// Copyright (C) 2005-2011 Team MediaPortal
// http://www.team-mediaportal.com
// 
// MediaPortal is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
// 
// MediaPortal is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with MediaPortal. If not, see <http://www.gnu.org/licenses/>.

#endregion

namespace System.Windows
{
  public class UIPropertyMetadata : PropertyMetadata
  {
    #region Constructors

    public UIPropertyMetadata() {}

    public UIPropertyMetadata(GetValueOverride getValueOverride) : base(getValueOverride) {}

    public UIPropertyMetadata(object defaultValue) : base(defaultValue) {}

    public UIPropertyMetadata(PropertyInvalidatedCallback propertyInvalidatedCallback)
      : base(propertyInvalidatedCallback) {}

    public UIPropertyMetadata(SetValueOverride setValueOverride) : base(setValueOverride) {}

    public UIPropertyMetadata(GetValueOverride getValueOverride, SetValueOverride setValueOverride)
      : base(getValueOverride, setValueOverride) {}

    public UIPropertyMetadata(object defaultValue, PropertyInvalidatedCallback propertyInvalidatedCallback)
      : base(defaultValue, propertyInvalidatedCallback) {}

    public UIPropertyMetadata(object defaultValue, PropertyInvalidatedCallback propertyInvalidatedCallback,
                              GetValueOverride getValueOverride)
      : base(defaultValue, propertyInvalidatedCallback, getValueOverride) {}

    public UIPropertyMetadata(PropertyInvalidatedCallback propertyInvalidatedCallback, GetValueOverride getValueOverride,
                              SetValueOverride setValueOverride)
      : base(propertyInvalidatedCallback, getValueOverride, setValueOverride) {}

    public UIPropertyMetadata(object defaultValue, PropertyInvalidatedCallback propertyInvalidatedCallback,
                              GetValueOverride getValueOverride, SetValueOverride setValueOverride)
      : base(defaultValue, propertyInvalidatedCallback, getValueOverride, setValueOverride) {}

    public UIPropertyMetadata(object defaultValue, PropertyInvalidatedCallback propertyInvalidatedCallback,
                              GetValueOverride getValueOverride, SetValueOverride setValueOverride,
                              bool isAnimationProhibited)
      : base(defaultValue, propertyInvalidatedCallback, getValueOverride, setValueOverride)
    {
      _isAnimationProhibited = isAnimationProhibited;
    }

    #endregion Constructors

    #region Methods

    protected override PropertyMetadata CreateInstance()
    {
      return new UIPropertyMetadata();
    }

    #endregion Methods

    #region Properties

    public bool IsAnimationProhibited
    {
      get { return _isAnimationProhibited; }
      set { _isAnimationProhibited = value; }
    }

    #endregion Properties

    #region Fields

    private bool _isAnimationProhibited = false;

    #endregion Fields
  }
}