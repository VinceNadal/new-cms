import { Contact } from "../interfaces/Contact";

interface Props {
  contacts: Contact[];
}

export default function ContactList({ contacts }: Props) {
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
