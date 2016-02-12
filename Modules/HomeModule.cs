using Nancy;
using AdBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    Get["/contacts"] = _ => {
      List<Contact> allContacts = Contact.GetAll();
      return View["index.cshtml", allContacts];
    };

    Get["/contacts/new"] = _ => {
      return View["add_new_contact"];
    };

    Post["/contacts/added"] = _ => {
      Contact newContact = new Contact (Resquest.Form["name"], (Resquest.Form["phoneNumber"], (Resquest.Form["address"]);
      return View["contact_created.cshtml", newContact];
    };

    Get["contacts/{id}"] = parameters => {
      Contact selectedContact = Contact.Find(parameters.id);
      return View["contact_details.cshtml", selectedContact]
    }

    Post["/contacts/deleted"] = _ => {
      Contact.ClearAll();
      return View["contacts_deleted.cshtml"];
    };
  }
}
