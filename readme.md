# Trevor Prinn Vaultex Test

## Database model

Under normal circumstances, I wouldn't consider making a database model like this one.
Each table would have a primary key, containing no meaningful fields, and these would
be used to link the tables and give model objects navigation properties to the other
entities.

The database context would also normally implement migrations, and be capable of
creating the database (by using data annotations etc).

I would also add a loader
app to load data into the database. If data was provided in Excel I would use
csv for a one off load or something like Flexcel for more regular updates and
additions.

## Logging

I've added in log4net to do some logging, but it doesn't seem to be working.
I don't know why, but I've not used it with net core 6 before.