Imports System.Data.SqlClient
Public Class firstPage

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Dim sel_cu_name As String

    Private Sub FirstPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomerDataSet.customerDataTable' table. You can move, or remove it, as needed.


        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\coldstore2\coldstore2\coldStoreDatabase.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        TextBox1.Text = ""
        TextBox2.Text = ""
        disp_data()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then

            Form1.Show()
            Application.Exit()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM customerDataTable where cu_phone1='" + TextBox2.Text + "' or cu_phone2='" + TextBox2.Text + "'"
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox("No such Phone is in the DataBase", MsgBoxStyle.Information)
        End Try
        TextBox2.Text = ""
        TextBox1.Text = ""
    End Sub


    Public Sub disp_data()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM customerDataTable"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            i = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString)

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT id,cu_name,cu_phone1,cu_address,cu_due_amount,cu_comments FROM customerDataTable where id=" & i & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                TextBox1.Text = dr.GetString(1).ToString()
                sel_cu_name = TextBox1.Text
                TextBox2.Text = dr.GetString(2).ToString()

            End While
        Catch ex As Exception
            MsgBox("Something went wrong, Restart again..", MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        registerPage.Show()
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If i = Nothing Then
            MsgBox("Please Select a Customer..!", MsgBoxStyle.Information)
        Else
            CustomerData.Label16.Text = i
            CustomerData.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        disp_data()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM customerDataTable where cu_name='" + TextBox1.Text + "'"
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox("No such Name is in the DataBase", MsgBoxStyle.Information)
        End Try
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If i = Nothing Then
            MsgBox("Please Select a Customer..!", MsgBoxStyle.Information)
        Else
            pastData.Label4.Text = i
            pastData.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim iExit As DialogResult
        If i = Nothing Then
            MsgBox("Select the Customer...", MsgBoxStyle.Information)
        Else
            iExit = MessageBox.Show("Confirm to Delete. All the Data will be Deleted", "Confirm to Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If iExit = DialogResult.Yes Then

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM dailyTable WHERE cu_Id=" & i & ""
                cmd.ExecuteNonQuery()

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                cmd = con.CreateCommand()
                cmd.CommandText = "DELETE FROM customerDataTable WHERE id=" & i & ""
                cmd.ExecuteNonQuery()
            End If
        End If

    End Sub
End Class