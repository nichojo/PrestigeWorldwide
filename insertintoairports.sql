insert into Airports
select ident, type, name, Latitude, Longitude, Continent, ISOCountry, ISORegion, Municipality, Serviced, GPSCode, IATACode, LocalCode from Airports_Backup