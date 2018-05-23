For the WCF Service to work you will need to do the following

1.Restore DigitalXDB.Bak to SQL Database
2. Add an ADO.net Entity Data Model
3. Use DigitalXDBEntitities (ShoppingCartWCF) as the connection, and save the connection string in Web.Config 
4. Import all Tables
5. edit the db context on Service1.SVC (default should be something like DigitalXDBEntities1)

Everything should now work as intended