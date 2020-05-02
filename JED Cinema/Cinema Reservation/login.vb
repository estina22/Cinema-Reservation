Imports MySql.Data.MySqlClient

Public Class login
    Dim ConStr As String = "Server=localhost; Port=3306; Database=cinema_db; Uid=root; Pwd=zero00;"
    Dim con As New MySqlConnection(ConStr)
    Dim sdaEmp As MySqlDataAdapter

    Public Sub Login()

        Dim SQLAdmin As String = "Select * from employee"
        Dim dtEmp As DataTable = New DataTable()

        Dim SQLCust As String = "Select * from customer"
        Dim dtCust As DataTable = New DataTable()



        If adminCheck.Checked Then

            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            SQLAdmin = "SELECT * FROM employee WHERE username='" & user.Text & "'and password='" & pass.Text & "'"
            Dim sdaEmp As New MySqlDataAdapter(SQLAdmin, con)
            sdaEmp.Fill(dtEmp)

            If (dtEmp.Rows.Count > 0) Then
                MessageBox.Show("Login Successful as: " + dtEmp.Rows(0)(4))

                Dim aWindow As New adminMain
                aWindow.Show()
                Me.Hide()
                con.Close()
            Else
                MessageBox.Show("Login unsuccesful: Check your username/password")
            End If
        Else
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            SQLCust = "SELECT * FROM customer WHERE email='" & user.Text & "'and password='" & pass.Text & "' "
            Dim sdaCust As New MySqlDataAdapter(SQLCust, con)
            sdaCust.Fill(dtCust)
            If (dtCust.Rows.Count > 0) Then
                MessageBox.Show("Login Successful")
                Dim uWindow As New userMain
                uWindow.Show()
                Me.Hide()
            Else
                MessageBox.Show("Login error")
            End If
        End If

    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If user.Text = "" Or pass.Text = "" Then
            MessageBox.Show("Error: missing information")
        Else
            Login()
        End If
    End Sub

    Private Sub exitLabel_Click(sender As Object, e As EventArgs) Handles exitLabel.Click
        End 'closes window
    End Sub

    Private Sub exitLabel_MouseHover(sender As Object, e As EventArgs) Handles exitLabel.MouseHover
        exitLabel.BackColor = Color.DarkSlateGray
        exitLabel.ForeColor = Color.White
    End Sub

    Private Sub exitLabel_MouseLeave(sender As Object, e As EventArgs) Handles exitLabel.MouseLeave
        exitLabel.BackColor = Color.DarkTurquoise
        exitLabel.ForeColor = Color.White
    End Sub


End Class
