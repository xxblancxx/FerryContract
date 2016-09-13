# FerryContract


Customer, Reservation, Route and Ferry are all serializable DTO objects.
ExceptionTransferObject is serializable, and inherits from base class Exception, so any type of Exception could be squished into it.


The use case we focused on contract for contains 2 main methods. These are included in our remote Interface:

ListAllRoutes which returns a list of routes available to book
and
MakeReservation which books a reservation based on selected route and mode of transportation.
