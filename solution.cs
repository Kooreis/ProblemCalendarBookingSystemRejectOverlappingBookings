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