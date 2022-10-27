using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using RRU.HelpDesk.Request;

namespace RRU.HelpDesk.Shared
{
  [Public]
  partial class RequestFunctions
  {
    public void fillName() {    
      var s = "{0} № {1} от {2}: {3}";
      var newName = string.Format(s, _obj.RequestKind.ToString(), _obj.Number.ToString(), _obj.CreatedDate.ToString(),  
                                  _obj.Description.Length<=50?_obj.Description:_obj.Description.Substring(0, 50));
      _obj.Name = newName;
    }
  }
}