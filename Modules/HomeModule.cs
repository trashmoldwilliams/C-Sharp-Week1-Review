using Nancy;
using Todo.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    Get["/"] = _ => View[""];
  }
}
