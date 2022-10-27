using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using RRU.HelpDesk.InternalRequest;

namespace RRU.HelpDesk.Client
{
  partial class InternalRequestActions
  {
    public virtual void ShowRequestsOfTheEmployee(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      var list = Functions.Module.Remote.getRequestsByAuthor(_obj.Author);
      list.ShowModal();
    }

    public virtual bool CanShowRequestsOfTheEmployee(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      return true;
    }

  }

}