using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using RRU.HelpDesk.Request;

namespace RRU.HelpDesk.Client
{
  partial class RequestActions
  {
    public virtual void ReopenRequest(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      _obj.LifeCycle = Request.LifeCycle.InWork;
      _obj.State.IsEnabled = true;
      _obj.ClosedDate = null;
      
    }

    public virtual bool CanReopenRequest(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      return _obj.LifeCycle.Equals(Request.LifeCycle.Closed);
    }

  }


}