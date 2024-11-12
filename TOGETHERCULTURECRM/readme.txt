so what is happening is that by default any changes in db is occuring in
runtime DB which in bin folder, we have to make changes in app.config to make changes
visible to main db:
add the path of db (path of db formed inside in your system) to |DataDirectory|


<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <configSections>
    </configSections>
    <connectionStrings>
        <add name="TOGETHERCULTURECRM.Properties.Settings.DBConnectionString"
            connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TcCRMDB.mdf;Integrated Security=True;Connect Timeout=30"
            providerName="System.Data.SqlClient" />
    </connectionStrings>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
    </startup>
</configuration>