using System;
using Sungero.Core;

namespace mtg.AutotextsModule.Constants
{
  public static class Module
  {
    #region Группы и роли
    
    public static class RoleGuid
    {
      // GUID роли "Использование автотекстов".
      [Sungero.Core.Public]
      public static readonly Guid AutotextsUseRole = Guid.Parse("95941D76-0F6B-4E58-A6BD-B11654FEB350");

      // GUID роли "Создание автотекстов".
      [Sungero.Core.Public]
      public static readonly Guid AutotextsCreateRole = Guid.Parse("9399C059-0D24-4B50-8ACA-FE3DE005E7A1");
    }
    
    #endregion
  }
}