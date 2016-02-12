using Nancy;
using Todo.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    Get["/"] = _ => {
      List<Contact> allContacts = Contact.GetAll();
      return View["index.cshtml", allContacts];
    }

    Post["/contact_created"] = _ => {
      Contact newContact = new Contact (Resquest.Form["name"], (Resquest.Form["phoneNumber"], (Resquest.Form["address"]);
      newContact.Save();
      return View["contact_created.cshtml", newContact];
    };

  }
}
