Under the contact header there are three form pages. Two MVC, one for adding people and one for adding classes. 
There's also a razor page which I've used to demonstrate a rather crap thread delay workaround to using one migration service 'concurrently' for more than one data model (long story). 
Haven't implemented the many-to-many relationship or the data viewing page in this commit since they're simple but time-consuming and I need to sleep! 
Otherwise, I believe everything else is working including some basic validation. 





This project uses SQLEXPRESS. Set the connection string to your database via appsettings.json

1. Ensure the Migrations folder is empty 

2. Build project

3. In the package manager console, run 'Add-Migration Migration1''

4. In the package manager console, run 'Update-Database'