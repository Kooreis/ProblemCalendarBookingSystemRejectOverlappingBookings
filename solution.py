Here is a simple console application in Python that implements a calendar booking system that rejects overlapping bookings.

```python
class Booking:
    def __init__(self, start, end):
        self.start = start
        self.end = end

class Calendar:
    def __init__(self):
        self.bookings = []

    def add_booking(self, start, end):
        new_booking = Booking(start, end)
        for booking in self.bookings:
            if not (new_booking.end <= booking.start or new_booking.start >= booking.end):
                return "Booking overlaps with an existing booking. Try again."
        self.bookings.append(new_booking)
        return "Booking added successfully."

def main():
    calendar = Calendar()
    while True:
        print("\n1. Add booking")
        print("2. Exit")
        choice = int(input("Enter your choice: "))
        if choice == 1:
            start = int(input("Enter start time: "))
            end = int(input("Enter end time: "))
            print(calendar.add_booking(start, end))
        elif choice == 2:
            break
        else:
            print("Invalid choice. Try again.")

if __name__ == "__main__":
    main()
```

This application allows the user to add bookings to a calendar. If a booking overlaps with an existing booking, the application rejects the booking and asks the user to try again. The user can continue to add bookings or exit the application.