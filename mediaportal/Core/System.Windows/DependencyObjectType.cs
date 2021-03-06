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
  public class DependencyObjectType
  {
    #region Constructors

    public DependencyObjectType() {}

    #endregion Constructors

    #region Methods

    public static DependencyObjectType FromSystemType(Type systemType)
    {
      throw new NotImplementedException();
    }

    public override int GetHashCode()
    {
      return _id;
    }

    public bool IsInstanceOfType(DependencyObject d)
    {
      throw new NotImplementedException();
    }

    public bool IsSubclassOf(DependencyObjectType dependencyObjectType)
    {
      throw new NotImplementedException();
    }

    #endregion Methods

    #region Properties

    public DependencyObjectType BaseType
    {
      get { return _baseType; }
    }

    public int Id
    {
      get { return _id; }
    }

    public string Name
    {
      get { return _name; }
    }

    public Type SystemType
    {
      get { return _systemType; }
    }

    #endregion Properties

    #region Fields

    private DependencyObjectType _baseType = null;
    private int _id = ++_idNext;
    private static int _idNext = 0;
    private string _name = string.Empty;
    private Type _systemType = null;

    #endregion Fields
  }
}