import ContactList from "./components/ContactList";
import Form from "./components/Form";
import { useState } from "react";
import { Contact } from "./interfaces/Contact";

function App() {
  // create a state variable which stores contacts
  const [contacts, setContacts] = useState<Contact[]>([]);

  // create a function to add a new contact to the contacts state variable
  const addContactHandler = (contact: Contact) => {
    console.log(contact);
    setContacts([...contacts, contact]);
  };

  const setContactsHandler = (contacts: Contact[]) => {
    setContacts(contacts);
  };

  return (
    <div>
      <h1>My Contacts</h1>
      <Form handleAddContact={addContactHandler} />
      <ContactList contacts={contacts} handleSetContacts={setContactsHandler} />
    </div>
  );
}

export default App;

// 2 primary UI components
// form inputs wc will be used to create a new contact
// ui component that will be used to display all the contacts
