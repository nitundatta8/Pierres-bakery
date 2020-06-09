
# **Pierre's Bakery**

#### _This is an Independent Project at Epicodus using web application framework called ASP.NET Core MVC and Entity Framework Core._

#### Made By **Nitun Data_**
#### June 05, 2020

### Description

__A web application where a business owner to market their sweet and savory treats.All users have read authorization of content on the website, but only users logged in can create, update or delete items.__

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
  (VSCode, Atom, etc.)
3. Make sure that C#/.netcore2.2 is installed on your computer.
4. Ensure that  MySQL Community Server is installed on your computer.
5. Within the PierresBakery directory add your MySQL password to the appsettings.json file.
* "Server=localhost;Port=3306;database=pierres_bakery;uid=root;pwd=YOURPASSWORDHERE;"
* Make any other changes needed if you have an alternative server, port, or uid selected. These are the default settings.
6. For launching the program navigate to the _PierresBakery_ directory and run _dotnet build_.
7. Then run _dotnet ef database update_.
8. Finaly,run _dotnet run_ command in the same directory to to open a live server w/auto updated viewing.Then navigate to localhost:5000/.

#### If you need to install and configure MySQL:
1. Download the MySQL Community Server DMG file [here](https://dev.mysql.com/downloads/file/?id=484914) with the "No thanks, just start my download" link.
2. On the configuration page of the installer select the following options:
* Use legacy password encryption
* Set your password
3. Open the terminal and enter the command:
*'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile
4. Download the MySQL Workbench DMG file [here](https://dev.mysql.com/downloads/file/?id=484391)

### Known Bugs

No bugs have been identified at the time of this update.

### Support and Contact Information

Please contact me with any suggestions or questions at nitun.2@gmail.com. Thank you for your input!  

### Technologies Used

* C#
* ASP.NET Core
* ASP.NET Core MVC
* MySQL
* Entity Framework Core
* Git and GitHub

### Specs
* The user can view the splashpage
* A user can create an account
* A user with a valid account can log in and out
* All users have READ access to the entire application
* Only logged-in users can:
   - Add a new treat or flavor
   - Update a treat or flavor
   - Delete a treat or flavor
* The user can route to a splashpage that displays all treats and flavors
* The user can route to a specific treat or flavor and see all treats/flavors that belong to it


#### License

This software is licensed under the MIT license.

Copyright © 2020 **_Nitun Datta_**
