# Question: How can you build a calendar booking system that rejects overlapping bookings? C# Summary

The provided C# code is a simple console application that implements a basic calendar booking system. The system is designed to reject overlapping bookings. The application includes two classes: `Booking` and `Calendar`. The `Booking` class represents a booking with a start and end time. The `Calendar` class manages the bookings. It contains a list of `Booking` objects and a method `AddBooking` to add new bookings. When a new booking is attempted, the `AddBooking` method checks if the start or end time of the new booking overlaps with any existing bookings in the list. If an overlap is detected, the method rejects the booking and returns a message indicating the overlap. If no overlap is detected, the new booking is added to the list and a success message is returned. The `Main` method in the `Program` class demonstrates the use of the `Calendar` class by creating a `Calendar` object and attempting to add several bookings, some of which overlap.

---

# Python Differences

The Python version of the solution is similar to the C# version in terms of the overall structure and logic. Both versions have a `Booking` class to represent a booking and a `Calendar` class to manage the bookings. The `Calendar` class in both versions has a method to add a new booking, which checks if the new booking overlaps with any existing bookings and rejects it if it does.

However, there are some differences due to the different features and syntax of the two languages:

1. In the C# version, the `Booking` class has properties `Start` and `End` with getters and setters, while in the Python version, the `Booking` class has attributes `start` and `end` which are set in the `__init__` method.

2. The C# version uses a `List<Booking>` to store the bookings, while the Python version uses a list `self.bookings`.

3. The C# version uses a `foreach` loop to iterate over the bookings, while the Python version uses a `for` loop.

4. The C# version uses `Console.WriteLine` to output messages to the console, while the Python version uses the `print` function.

5. The Python version includes a user interface in the `main` function that allows the user to add bookings or exit the application. The C# version does not have a similar user interface; it simply adds some bookings in the `Main` method.

6. The Python version does not check if the start time is earlier than the end time, which is done in the C# version.

7. The Python version uses a different logic to check for overlapping bookings. It checks if the new booking does not end before the start of the existing booking and does not start after the end of the existing booking. If both conditions are false, it means the new booking overlaps with the existing booking. The C# version checks if the start or the end of the new booking is within the start and end of the existing booking.

---

# Java Differences

The Java and C# versions of the solution are quite similar in their approach to solving the problem. Both versions use a list to store bookings and a method to add new bookings. The method checks for overlapping bookings before adding a new booking to the list.

However, there are some differences due to the language features and methods used in each version:

1. DateTime vs int: In the C# version, the `DateTime` structure is used to represent the start and end times of a booking. This allows for precise date and time representation. In contrast, the Java version uses `int` to represent the start and end times. This is a simpler representation and might not be suitable for real-world applications where precise date and time are required.

2. Overlapping Check: The C# version checks for overlapping bookings by comparing the start and end times of the new booking with those of each existing booking. The Java version uses the `Math.max` and `Math.min` methods to check for overlaps. This is a more concise way of checking for overlaps, but it might be less intuitive to understand.

3. Console Output vs Return Value: The C# version outputs messages to the console to indicate whether a booking was added successfully or not. The Java version, on the other hand, returns a boolean value from the `book` method to indicate the success or failure of the booking operation. This makes the Java version more suitable for use as a part of a larger system, where the return value can be used by other parts of the system.

4. Constructor Usage: In the Java version, a constructor is used in the `Booking` class to initialize the start and end times, and in the `CalendarBookingSystem` class to initialize the bookings list. In the C# version, the `Booking` class uses properties to set the start and end times, and the bookings list is initialized directly in the `Calendar` class. This is a difference in the language features used in each version.

5. Naming: The C# version uses PascalCase for class and method names, which is the standard naming convention in C#. The Java version uses camelCase for method names, which is the standard naming convention in Java.

---
