# Program Flow:

- Ask the user if they want to produce a car: Prompt the user to input 'e' for yes or 'h' for no. Ignore case sensitivity. If an invalid response is given, inform the user of the invalid input and ask the question again.
- If the user chooses no, end the program: If the response is yes, create a new car object and prompt the user to enter its properties via the console.
- Set the Production Date: Automatically set the ProductDate value to the current date and time when the car is produced.
- Validate Door Number: Prevent the program from throwing an exception if a non-numeric value is entered for the number of doors. Display a warning message and redirect the user to re-enter the value. (Research the goto command.)
- Add the created car object to a list: Store the newly created car in a list named cars.
- Ask if the user wants to produce another car: If yes, return to step 2 and create another car, adding it to the list. If no, print the serial numbers and brands of all cars in the list.
