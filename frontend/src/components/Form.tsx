import { useState } from "react";

export default function Form() {
  // create form with inputs for firstname, lastname, physical address, and delivery address
  // create a submit button

  // create a state variable for the form inputs using react useState hook
  const [formState, setFormState] = useState({
    firstName: "",
    lastName: "",
    physicalAddress: "",
    deliveryAddress: "",
  });

  // create a handler function to update the state variable when a user types in an input
  const handleInputChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    setFormState({ ...formState, [event.target.name]: event.target.value });
  };

  //   create a handler function to submit the form
  const handleSubmit = (event: React.FormEvent<HTMLFormElement>) => {
    event.preventDefault();
    console.log(formState);
  };

  return (
    <form onSubmit={handleSubmit}>
      <input
        type="text"
        name="firstName"
        placeholder="First Name"
        value={formState.firstName}
        onChange={handleInputChange}
      />
      <input
        type="text"
        name="lastName"
        placeholder="Last Name"
        value={formState.lastName}
        onChange={handleInputChange}
      />
      <input
        type="text"
        name="physicalAddress"
        placeholder="Physical Address"
        value={formState.physicalAddress}
        onChange={handleInputChange}
      />
      <input
        type="text"
        name="deliveryAddress"
        placeholder="Delivery Address"
        value={formState.deliveryAddress}
        onChange={handleInputChange}
      />

      <button type="submit">Submit</button>
    </form>
  );
}
