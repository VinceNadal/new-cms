import ContactList from "./components/ContactList";
import Form from "./components/Form";
import { useState } from "react";

function App() {
  // create a state variable which stores contacts
  const [contacts, setContacts] = useState([]);

  
  return (
    <div>
      <h1>My Contacts</h1>
      <Form />
      <ContactList contacts={contacts} />
    </div>
  );
}

export default App;

// 2 primary UI components
// form inputs wc will be used to create a new contact
// ui component that will be used to display all the contacts
