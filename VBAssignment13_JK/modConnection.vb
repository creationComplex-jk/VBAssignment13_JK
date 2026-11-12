Imports System.IO

Module modConnection
    Public ReadOnly databasePath As String =
        Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..\..\flyme2themoon.db"))

    Public ReadOnly connectionString As String =
        "Data Source=" & databasePath & ";Version=3;"

End Module
