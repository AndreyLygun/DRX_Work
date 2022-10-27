using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using RRU.HelpDesk.Request;

namespace RRU.HelpDesk
{
  partial class RequestSharedHandlers
  {

    public virtual void DescriptionChanged(Sungero.Domain.Shared.StringPropertyChangedEventArgs e)
    {      
      Functions.Request.fillName(_obj);
    }

    public virtual void CreatedDateChanged(Sungero.Domain.Shared.DateTimePropertyChangedEventArgs e)
    {
      Functions.Request.fillName(_obj);
    }

    public virtual void NumberChanged(Sungero.Domain.Shared.IntegerPropertyChangedEventArgs e)
    {
      Functions.Request.fillName(_obj);
    }

    public virtual void RequestKindChanged(RRU.HelpDesk.Shared.RequestRequestKindChangedEventArgs e)
    {
      Functions.Request.fillName(_obj);
    }

  }
}