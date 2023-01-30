import React, { useEffect } from 'react'
import { Contact } from "../interfaces/Contact";
import { getContacts as getAllContacts } from "../services/api";

interface Props {
  contacts: Contact[];
  handleSetContacts: (contacts: Contact[]) => void;
}

export default function ContactList({ contacts, handleSetContacts }: Props) {
  // Use getAllContacts to get all contacts from the API and use useEffect to set the contacts state variable
  useEffect(() => {
    const getContacts = async () => {
      const contacts = await getAllContacts();
      handleSetContacts(contacts);
    };
    getContacts();
  }, []);

  return (
    <>
      <h2>Contact List</h2>
      <ul>
        {contacts.map((contact) => (
          <li key={contact.id}>
            {contact.firstName} {contact.lastName}
            <div>
              <b>Addresses:</b>
              {contact.physicalAddress} {contact.deliveryAddress}
            </div>
          </li>
        ))}
      </ul>
    </>
  );
}
