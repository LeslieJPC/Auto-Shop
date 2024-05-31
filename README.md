# Program4AutoShop

## Overview
**Program4AutoShop** is a Windows Forms application designed to assist with managing and calculating the costs of various auto services. The application allows users to select different auto services, input parts and labor costs, and calculates the total fee including taxes.

## Features
- Checkbox and radio button options for various auto services.
- Input fields for parts and labor costs.
- Calculation of total fees including parts, labor, and taxes.
- Clear and Exit functionalities.
- User-friendly interface with message prompts for guidance.

## Code Structure
The application is developed in C# using Windows Forms. Below is a brief description of the main components and their functionality.

### Constants
- **Service Costs**:
  - `OilChange`: $26.00
  - `Mixed`: $10.00
  - `FullSynthetic`: $20.00
  - `LubeJob`: $18.00
  - `FullService`: $6.00
  - `Premium`: $9.00
  - `RadiatorFlush`: $30.00
  - `TransmissionFlush`: $80.00
  - `Inspection`: $15.00
  - `ReplaceMuffler`: $100.00
  - `TireRotation`: $20.00
  - `taxrate`: 6%

### Variables
- `serviceslabor`: Stores the total labor cost.
- `parts`: Stores the cost of parts.
- `finaltax`: Stores the calculated tax on parts.
- `fees`: Stores the total fee including parts, labor, and tax.
- `total`: Stores the cumulative cost of selected services.

### Methods
- `Form1()`: Constructor to initialize components.
- `button1_Click()`: Event handler for the "Calculate" button.
  - Calculates the total fees and displays them in the respective text boxes.
  - Calls `GetInput` method to reset input fields.
- `GetTextBox1()`, `GetTextBox2()`: Helper methods to get text box controls.
- `GetInput()`: Resets text box inputs and prompts user for service and labor hours.
- `button2_Click()`: Event handler for the "Clear" button.
  - Resets all checkboxes, radio buttons, and text boxes.
- `button3_Click()`: Event handler for the "Exit" button.
  - Exits the application with a thank-you message.
- `checkBox1_CheckedChanged()`, `radioButton2_CheckedChanged()`, etc.: Event handlers for service options.
  - Adds the cost of the selected service to the total.

### Event Handlers
- Each checkbox and radio button has an associated event handler that adds the cost of the selected service to the `total` variable.

## Getting Started

### Prerequisites
- .NET Framework (version 4.7.2 or higher)
- Visual Studio (or any C# compatible IDE)

### Installation
1. Clone the repository:
    ```sh
    git clone https://github.com/LeslieJPC/Program4AutoShop.git
    ```
2. Open the project in Visual Studio.
3. Build the solution to restore dependencies and compile the application.
4. Run the application.

### Usage
1. Select the desired auto services using the checkboxes and radio buttons.
2. Enter the parts cost and labor hours in the respective text boxes.
3. Click the "Calculate" button to calculate the total fee, which will be displayed in the output text boxes.
4. To reset the form, click the "Clear" button.
5. To exit the application, click the "Exit" button.

## License
This project is licensed under the MIT License. See the `LICENSE` file for more details.

## Author
- Leslie J Polley Cofer

Feel free to reach out for any questions or contributions. Happy coding!

---

### Note
This application is a sample project intended for learning and demonstration purposes. It may require further enhancements and testing for production use.
