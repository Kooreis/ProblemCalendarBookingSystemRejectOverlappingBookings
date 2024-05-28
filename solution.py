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