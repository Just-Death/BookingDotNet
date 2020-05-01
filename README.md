# BookingDotNet
SWD3: Microsoft .NET Framework, Application Development Foundation course final project 
Topic of this project is room booking system in hotel, where logined users can book rooms in hotel.

Authors: Kazhi Berik, Tolebay Amirzhan, group CSSE 1701 of IITU.

Project is written on C# using ASP.NET Core framework. 
In our project we have 6 models with all possible DB relationships. There are them:
1) Room
2) Review
3) Category
4) User
5) Menu
6) Orders(MenuRoom) 
So now relations: 
One-to-Many: Room-Review, Room-Category, Menu-Orders
One-to-One: Room-User, User-Review
Many-to-Many: Room-Order

Also we have controllers with CRUD actions on our models with views.
