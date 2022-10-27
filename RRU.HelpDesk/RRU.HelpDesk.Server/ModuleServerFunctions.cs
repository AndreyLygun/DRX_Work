using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;

namespace RRU.HelpDesk.Server
{
  public class ModuleFunctions
  {
    /// <summary>
    /// Создаёт новое внутреннее обращение
    /// </summary>
    /// <returns></returns>
    [Remote]
    public IInternalRequest createInternalRequest() {
      return InternalRequests.Create();
    }
    
    /// <summary>
    /// Создаёт новое внешнее обращение;
    /// </summary>
    /// <returns></returns>
    [Remote]
    public IExternalRequest createExternalRequest() {
      return ExternalRequests.Create();
    }
    
    /// <summary>
    /// Возвращает список обращений указанного автора
    /// </summary>
    /// <param name="author"></param>
    /// <returns></returns>
    [Remote]
    public IQueryable<IInternalRequest> getRequestsByAuthor(IRecipient author) {
      return InternalRequests.GetAll(r => r.Author.Equals(author));   
    }
    
  }
}