@{
	RootModule = "SqlDatabase"

	ModuleVersion = "4.1.1"
	GUID = "f19e643e-f998-4767-b2f9-958daf96137b"

	Author = "Max Ieremenko"
	Copyright = "(C) 2018-2022 Max Ieremenko, licensed under MIT License"

	Description = "
This module for MSSQL Server, PostgreSQL and MySQL, allows to execute scripts, database migrations and export data.
PowerShell versions: desktop 5.1, core 6.1+.
"

	# for the PowerShell Desktop edition only.
	DotNetFrameworkVersion = '4.5.2'

	PowerShellVersion = '5.1'
	CompatiblePSEditions = @('Desktop', 'Core')
	CLRVersion = '4.0'
	ProcessorArchitecture = 'None'

	CmdletsToExport = (
		"New-SqlDatabase",
		"Invoke-SqlDatabase",
		"Update-SqlDatabase",
		"Export-SqlDatabase",
		"Show-SqlDatabaseInfo"
	)

	AliasesToExport = @("Create-SqlDatabase", "Execute-SqlDatabase", "Upgrade-SqlDatabase")

	PrivateData = @{
		PSData = @{
			Tags = 'sql', 'SqlServer', 'PostgreSQL', 'MySQL', 'database', 'mysql-database', 'sqlcmd', 'migration-tool', 'miration-step', 'sql-script', 'sql-database', 'database-migrations', 'export-data', 'PSEdition_Core', 'PSEdition_Desktop', 'Windows', 'Linux', 'macOS'
			LicenseUri = 'https://github.com/max-ieremenko/SqlDatabase/blob/master/LICENSE.md'
			ProjectUri = 'https://github.com/max-ieremenko/SqlDatabase'
			IconUri = 'https://raw.githubusercontent.com/max-ieremenko/SqlDatabase/master/icon-32.png'
			ReleaseNotes = 'https://github.com/max-ieremenko/SqlDatabase/releases'
		}
	 }
}
