using System.Collections.Generic;

namespace AdBook.Objects
{
  public class Contact
  {
    private string _name;
    private string _phoneNumber;
    private string _address;
    private int _id;
    private static List<Contact> _instances = new List<Contact> {};

    public Contact (string name, string phoneNumber, string address)
    {
      _name = name;
      _phoneNumber = phoneNumber;
      _address = address;
      _instances.Add(this);
      _id = _instances.Count;

    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }

    public void SetPhoneNumber(string newPhoneNumber)
    {
      _name = newPhoneNumber;
    }

    public string GetAddress()
    {
      return _address;
    }

    public void SetAddress(string newAddress)
    {
      _name = newAddress;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Contact> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Contact Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
