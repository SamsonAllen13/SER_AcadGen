'Imports necessary libraries
Imports System.IO
Imports System.String

Public Class Form1
    'Runs whenever the run button is clicked
    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        'The locatin of the Template being used;
        Dim TEMPLATE_NAME As String = txtTemplate.Text
        'The name of the processed .dxf file;
        Dim OUTFILE_NAME As String
        'The current line of text being read from the .dxf file;
        Dim TextLine As String = ""

        'Holds the rows of data
        Dim dabaRow As DataRow
        'Holds the opened database
        Dim dabaData As New DataSet()
        'Index variable for assigning data base info into VB arrays
        Dim ArrayIndex As Integer

        'declare an OleDb connection to a database file using Access MDB file
        Dim dabaConn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\SER_AcadGen\Input\SERmechDB.mdb;User ID=admin;Password=;")

        'Sets up the query and selects the DB table being used 
        Dim dabaAdap As New OleDb.OleDbDataAdapter("SELECT * FROM TABLENAME", dabaConn)

        'Declares the BugStatus bit
        Dim DebugActive As Boolean = False

        'Catches a windows error and displays it locally to prevent the program from crashing
        Try
            'fills dabaData with the query results
            dabaAdap.Fill(dabaData, "dabaConn")
            Console.WriteLine()
            'A check to prevent crashing if the query did not return any records
            If dabaData.Tables(0).Rows.Count > 0 Then

                'Loop through the rows in the DB
                For Each dabaRow In dabaData.Tables(0).Rows
                    'Set the outfile's name to the text in each row's OUTFILE column and place the file the output folder as a .dxf
                    OUTFILE_NAME = "C:\SER_AcadGen\Output\" & dabaRow("OUTFILE") & ".dxf"
                    'Displays the outfile name on the form
                    txtOutfile.Text = OUTFILE_NAME
                    'A check to prevent the program from crashing if the template is not present
                    If System.IO.File.Exists(TEMPLATE_NAME) = True Then

                        'Creates an object to read the data from the template
                        Dim dabaReader As New System.IO.StreamReader(TEMPLATE_NAME)
                        'Creates an object to write to the newly created .dxf with overwrite ON
                        Dim dabaWriter As New System.IO.StreamWriter(OUTFILE_NAME, True)

                        'Checking to see whether there is another line; returns a 
                        Do While dabaReader.Peek() <> -1
                            'Clears TextLine of the last row it was storing
                            TextLine = ""
                            'Sets TextLine to the current row from the dxf file
                            TextLine = dabaReader.ReadLine()

                            'Checking to see if the current line is a "##" statement
                            If TextLine.Contains("##") Then
                                'Writes to the output file based on the current line. The current line is a ## value
                                'and will match up to a column in the DB
                                dabaWriter.WriteLine(dabaRow(TextLine.ToString))
                            Else
                                'Writes the current line from the template to the output file; has no ##
                                dabaWriter.WriteLine(TextLine)
                            End If
                            'Keeps looping until the dabaReader.Peek confirms there are no more rows
                        Loop
                        'Closes the dabaReader now that there are no more rows
                        dabaWriter.Close()
                        'Closes the dabaWriter now that there are no more rows
                        dabaReader.Close()

                    Else
                        'Alerts user if the given template location is valid
                        MsgBox("File does not Exist")
                    End If
                    'Ends the for-loop after it has ran that loop once for each row in the spreadsheet
                Next
                'Ends the if statement checking that there are more than one row
            End If
            '
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class
