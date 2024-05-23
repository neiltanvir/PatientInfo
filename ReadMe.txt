1. Open PatientInfoAPI Project 
2. Connect your database(MS Sql Server) to the project
	=> In Appsetting.json 
	=> Go to "Con" (give your sql server information in "SERVER=")
3. Do the migration from Nuget Package Manager Console
	=> Command "add-migration initial" 
	=> then Command "Update-database"
thats will create database table.
4. Then Firstly, Run the PatientInfoAPI project.
5. Then Secondly, Run PatientInfoUI Project.
