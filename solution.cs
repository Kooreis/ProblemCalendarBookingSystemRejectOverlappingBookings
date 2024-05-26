Here is a simple console application in C# that implements a basic calendar booking system. This system rejects overlapping bookings.

```C#
using System;
using System.Collections.Generic;
using System.Linq;

public class Booking
{
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
}

public class Calendar
{
    private List<Booking> bookings = new List<Booking>();

    public bool AddBooking(DateTime start, DateTime end)
    {
        if (start >= end)
        {
            Console.WriteLine("Invalid booking. Start time must be earlier than end time.");
            return false;
        }

        foreach (var booking in bookings)
        {
            if ((start >= booking.Start && start < booking.End) || (end > booking.Start && end <= booking.End))
            {
                Console.WriteLine("Booking overlaps with an existing booking.");
                return false;
            }
        }

        bookings.Add(new Booking { Start = start, End = end });
        Console.WriteLine("Booking added successfully.");
        return true;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calendar calendar = new Calendar();

        calendar.AddBooking(new DateTime(2022, 1, 1, 10, 0, 0), new DateTime(2022, 1, 1, 12, 0, 0));
        calendar.AddBooking(new DateTime(2022, 1, 1, 12, 0, 0), new DateTime(2022, 1, 1, 14, 0, 0));
        calendar.AddBooking(new DateTime(2022, 1, 1, 13, 0, 0), new DateTime(2022, 1, 1, 15, 0, 0));

        Console.ReadLine();
    }
}
```

This application creates a `Booking` class to represent a booking, and a `Calendar` class to manage the bookings. The `Calendar` class has a `List<Booking>` to store the bookings, and a `AddBooking` method to add a new booking. The `AddBooking` method checks if the new booking overlaps with any existing bookings, and if it does, it rejects the booking. If the new booking does not overlap with any existing bookings, it adds the booking to the list. The `Main` method in the `Program` class creates a `Calendar` object and adds some bookings to it.