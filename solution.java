Here is a simple console application in Java that implements a basic calendar booking system. This system rejects overlapping bookings.

```java
import java.util.*;

class Booking {
    int start;
    int end;

    public Booking(int start, int end) {
        this.start = start;
        this.end = end;
    }
}

class CalendarBookingSystem {
    List<Booking> bookings;

    public CalendarBookingSystem() {
        this.bookings = new ArrayList<>();
    }

    public boolean book(int start, int end) {
        for (Booking booking : bookings) {
            if (Math.max(booking.start, start) < Math.min(booking.end, end)) {
                return false;
            }
        }
        bookings.add(new Booking(start, end));
        return true;
    }
}

public class Main {
    public static void main(String[] args) {
        CalendarBookingSystem calendarBookingSystem = new CalendarBookingSystem();
        System.out.println(calendarBookingSystem.book(10, 20)); // true
        System.out.println(calendarBookingSystem.book(15, 25)); // false
        System.out.println(calendarBookingSystem.book(20, 30)); // true
    }
}
```

In this application, the `CalendarBookingSystem` class maintains a list of `Booking` objects. Each `Booking` object represents a booking with a start time and an end time. The `book` method in the `CalendarBookingSystem` class checks if a new booking overlaps with any existing bookings. If it does, the method returns `false` and the booking is rejected. If it doesn't, the method adds the new booking to the list of bookings and returns `true`. The `main` method in the `Main` class tests the `CalendarBookingSystem` class.