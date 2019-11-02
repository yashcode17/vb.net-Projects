Imports System.Data.SqlClient
Public Class pastData
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer

    Public Sub disp_data3()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT pr_clearance_qty,pr_clearance_name,date FROM dailyTable WHERE cu_Id='" + Label4.Text + "' AND pr_clearance_qty>0"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView3.DataSource = dt
    End Sub

    Public Sub disp_data2()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT cu_deposit,date FROM dailyTable WHERE cu_Id='" + Label4.Text + "' AND cu_deposit>0"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView2.DataSource = dt
    End Sub

    Public Sub disp_data()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT pr_name,pr_qty,pr_cabin,Id,date,pr_price_per_qty,pr_total_price,pr_compensation,pr_final_price FROM dailyTable WHERE cu_Id='" + Label4.Text + "' AND ini_pr_qty>0"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub


    Private Sub PastData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomerDataSet.dailyTable' table. You can move, or remove it, as needed.
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\coldstore2\coldstore2\coldStoreDatabase.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT cu_name,cu_phone1,cu_due_amount FROM customerDataTable where id='" + Label4.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dr As SqlClient.SqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read
            Label5.Text = dr.GetString(0).ToString()
            Label6.Text = dr.GetString(1).ToString()
        End While
        disp_data()
        disp_data2()
        disp_data3()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        firstPage.Show()
        Me.Hide()
    End Sub
End Class