import { CreateContact } from "./../interfaces/CreateContact";
import axios from "axios";
import { Contact } from "../interfaces/Contact";

// Create an axios configuration
const api = axios.create({
  baseURL: "http://localhost:5000",
  headers: {
    "Content-Type": "application/json",
  },
});

// Get contacts from the server asynchronously
export const getContacts = async (): Promise<Contact[]> => {
  const response = await api.get("/contacts");
  return response.data;
};

// Add a new contact to the server asynchronously
export const addContact = async (contact: CreateContact): Promise<Contact> => {
  const response = await api.post("/contacts", contact);
  return response.data;
};

// Get a single contact from the server asynchronously
export const getContact = async (id: string): Promise<Contact> => {
  const response = await api.get(`/contacts/${id}`);
  return response.data;
};

// Update a contact on the server asynchronously
export const updateContact = async (contact: Contact): Promise<Contact> => {
  const response = await api.put(`/contacts/${contact.id}`, contact);
  return response.data;
};

// Delete a contact from the server asynchronously
export const deleteContact = async (id: string): Promise<void> => {
  await api.delete(`/contacts/${id}`);
};
