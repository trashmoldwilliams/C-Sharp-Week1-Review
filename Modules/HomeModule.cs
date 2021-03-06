using Nancy;
using AdBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.html"];
      };

      Get["/contacts"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["contacts.cshtml", allContacts];
      };

      Get["/contacts/new"] = _ => {
        return View["add_new_contact"];
      };

      Post["/contacts/added"] = _ => {
        Contact newContact = new Contact ((Request.Form["name"]), (Request.Form["phoneNumber"]), (Request.Form["address"]));
        return View["contact_created.cshtml", newContact];
      };

      Get["/contacts/{id}"] = parameters => {
        Contact selectedContact = Contact.Find(parameters.id);
        return View["contact_details.cshtml", selectedContact];
      };

      Get["/contacts/cleared"] = _ => {
        Contact.ClearAll();
        return View["contacts_deleted.cshtml"];
      };
    }
  }
}
