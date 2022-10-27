using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;

namespace RRU.HelpDesk.Client
{
  public class ModuleFunctions
  {
    /// <summary>
    /// 
    /// </summary>
    /// 
    public virtual void createExternalRequest()
    {
      var r = Functions.Module.Remote.createExternalRequest();
      r.ShowModal();      
    }

    /// <summary>
    /// 
    /// </summary>
    public virtual void сreateInternalRequest()
    {
      var r = Functions.Module.Remote.createInternalRequest();
      r.ShowModal();
    }

  }
}