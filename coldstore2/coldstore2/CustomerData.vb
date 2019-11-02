Imports System.Data.SqlClient
Public Class CustomerData
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As String

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim qty As Integer
        Dim pqty As Integer
        Dim comp As Integer
        Dim due As Integer
        Dim dip As Integer
        Try
            If TextBox2.Text = Nothing Then
                qty = 0
            Else
                qty = Convert.ToInt32(TextBox2.Text)
            End If
            If TextBox3.Text = Nothing Then
                pqty = 0
            Else
                pqty = Convert.ToInt32(TextBox3.Text)
            End If
            If TextBox5.Text = Nothing Then
                comp = 0
            Else
                comp = Convert.ToInt32(TextBox5.Text)
            End If
            If TextBox8.Text = Nothing Then
                due = 0
            Else
                due = Convert.ToInt32(TextBox8.Text)
            End If
            If TextBox10.Text = Nothing Then
                dip = 0
            Else
                dip = Convert.ToInt32(TextBox10.Text)
            End If
            TextBox4.Text = (qty * pqty)
            TextBox6.Text = (qty * pqty) - comp
            TextBox11.Text = due - dip
        Catch ex As Exception
            Timer1.Enabled = False
            Dim iExit As DialogResult
            iExit = MessageBox.Show("Enter Number Only", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Question)
            If iExit = DialogResult.OK Then
                TextBox2.Text = "0"
                TextBox3.Text = "0"
                TextBox5.Text = "0"
                Timer1.Enabled = True
            End If
        End Try


    End Sub

    Private Sub CustomerData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomerDataSet.dailyTable' table. You can move, or remove it, as needed.
        TextBox9.Text = Date.Now.ToString("dd-MMM-yyyy")

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\coldstore2\coldstore2\coldStoreDatabase.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT cu_name,cu_phone1,cu_due_amount FROM customerDataTable where id='" + Label16.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dr As SqlClient.SqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read
            Label1.Text = dr.GetString(0).ToString()

            Label2.Text = dr.GetString(1).ToString()

            TextBox8.Text = dr.GetValue(2).ToString()

        End While
        Timer1.Enabled = True

        disp_data()
        RichTextBox1.AppendText(vbTab + "===================================" + vbNewLine)
        RichTextBox1.AppendText(vbTab + vbTab + "BANSAL COLD STORE" + vbNewLine)
        RichTextBox1.AppendText(vbTab + "===================================" + vbNewLine)
        RichTextBox1.AppendText(vbTab + vbTab + vbTab + vbTab + vbTab + TextBox9.Text + vbNewLine)
        RichTextBox1.AppendText("BARNALA ROAD" + vbNewLine)
        RichTextBox1.AppendText("NIHAL SINGH VALA" + vbNewLine)
        RichTextBox1.AppendText("MOGA, 142055" + vbNewLine)
        RichTextBox1.AppendText("M.NO.-9914054478" + vbNewLine)
        RichTextBox1.AppendText(vbTab + "===================================" + vbNewLine)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim prQty As Int32 = Convert.ToInt32(TextBox2.Text)
            Dim prPerQty As Int32 = Convert.ToInt32(TextBox3.Text)
            Dim prTotalPrice As Int32 = Convert.ToInt32(TextBox4.Text)
            Dim prCom As Int32 = Convert.ToInt32(TextBox5.Text)
            Dim prFinalPr As Int32 = Convert.ToInt32(TextBox6.Text)
            Dim iExit As DialogResult
            iExit = MessageBox.Show("Confirm to Save...", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If iExit = DialogResult.Yes Then
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO dailyTable(cu_Id,cu_name,cu_phone1,date,pr_name,pr_qty,pr_price_per_qty,pr_total_price,pr_compensation,pr_final_price,pr_cabin,ini_pr_qty) VALUES('" + Label16.Text + "','" + Label1.Text + "','" + Label2.Text + "','" + TextBox9.Text + "','" + TextBox1.Text + "'," & prQty & "," & prPerQty & "," & prTotalPrice & "," & prCom & "," & prFinalPr & ",'" + TextBox7.Text + "'," & prQty & ")"
                cmd.ExecuteNonQuery()

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE customerDataTable SET cu_total_amount=cu_total_amount+'" + TextBox6.Text + "',cu_due_amount=cu_due_amount+'" + TextBox6.Text + "' WHERE Id='" + Label16.Text + "'"
                cmd.ExecuteNonQuery()

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "SELECT cu_due_amount FROM customerDataTable WHERE Id='" & Label16.Text & "'"
                cmd.ExecuteNonQuery()
                Dim dr As SqlClient.SqlDataReader
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                While dr.Read
                    TextBox8.Text = dr.GetValue(0).ToString()
                End While

                disp_data()

                RichTextBox1.AppendText(vbTab + vbTab + "         Item Entry" + vbNewLine)
                RichTextBox1.AppendText(vbTab + vbTab + "---------------------------------" + vbNewLine)
                RichTextBox1.AppendText(vbNewLine)
                RichTextBox1.AppendText(" Item Name:  ")
                RichTextBox1.AppendText(vbTab + vbTab + TextBox1.Text + vbNewLine)
                RichTextBox1.AppendText(" Quantity:  ")
                RichTextBox1.AppendText(vbTab + vbTab + TextBox2.Text + vbNewLine)
                RichTextBox1.AppendText(" Price Per Qty:  ")
                RichTextBox1.AppendText(vbTab + vbTab + TextBox3.Text + vbNewLine)
                RichTextBox1.AppendText(" Discount:  ")
                RichTextBox1.AppendText(vbTab + vbTab + TextBox5.Text + vbNewLine)
                RichTextBox1.AppendText(" Total Price:  ")
                RichTextBox1.AppendText(vbTab + vbTab + TextBox6.Text + vbNewLine)
                RichTextBox1.AppendText(" Cabin: ")
                RichTextBox1.AppendText(vbTab + vbTab + vbTab + TextBox7.Text + vbNewLine)
                RichTextBox1.AppendText(vbNewLine)
                RichTextBox1.AppendText(vbTab + "===================================" + vbNewLine)

            End If
        Catch ex As Exception
            MsgBox("Enter Data Properly Or Restart the App Again.", MsgBoxStyle.Information)
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim prcru As String = TextBox8.Text
            Dim iExit As DialogResult
            iExit = MessageBox.Show("Confirm to Deposit Amount...", "Deposit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If iExit = DialogResult.Yes Then
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE customerDataTable SET cu_due_amount=cu_due_amount-'" + TextBox10.Text + "' WHERE id='" + Label16.Text + "'"
                cmd.ExecuteNonQuery()
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO dailyTable(cu_Id,cu_name,cu_phone1,date,cu_deposit) VALUES('" + Label16.Text + "','" + Label1.Text + "','" + Label2.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "')"
                cmd.ExecuteNonQuery()

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "SELECT cu_due_amount FROM customerDataTable WHERE Id='" & Label16.Text & "'"
                cmd.ExecuteNonQuery()
                Dim dr As SqlClient.SqlDataReader
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                While dr.Read
                    TextBox8.Text = dr.GetValue(0).ToString()
                End While

                RichTextBox1.AppendText(vbTab + vbTab + "         Deposit Money" + vbNewLine)
                RichTextBox1.AppendText(vbTab + vbTab + "-----------------------------------------" + vbNewLine)
                RichTextBox1.AppendText(vbNewLine)
                RichTextBox1.AppendText(" Due Amounut:  ")
                RichTextBox1.AppendText(vbTab + vbTab + " " + prcru + vbNewLine)
                RichTextBox1.AppendText(" Deposit Amount:  ")
                RichTextBox1.AppendText(vbTab + vbTab + "-" + TextBox10.Text + vbNewLine)
                RichTextBox1.AppendText(" Final Due Amounut:  ")
                RichTextBox1.AppendText(vbTab + " " + TextBox11.Text + vbNewLine)
                RichTextBox1.AppendText(vbNewLine)
                RichTextBox1.AppendText(vbTab + "===================================" + vbNewLine)

                TextBox10.Text = "0"
            End If
        Catch ex As Exception
            MsgBox("Enter Data Properly Or Restart the App Again.", MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim iExit As DialogResult
            Dim prleft As String

            iExit = MessageBox.Show("Confirm to Clear Stock", "Clear Stock", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If iExit = DialogResult.Yes Then
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                Dim rec01 As Integer = Convert.ToUInt32(TextBox12.Text)
                i = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString)
                con.Open()
                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE dailyTable SET pr_qty=pr_qty-" & rec01 & " WHERE Id=" & i & ""
                cmd.ExecuteNonQuery()
                cmd.CommandText = "INSERT dailyTable(cu_Id, cu_name, cu_phone1, Date, pr_clearance_name, pr_clearance_qty) VALUES('" + Label16.Text + "','" + Label1.Text + "','" + Label2.Text + "','" + TextBox9.Text + "','" + TextBox13.Text + "'," & rec01 & ")"
                cmd.ExecuteNonQuery()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "SELECT pr_qty FROM dailyTable WHERE Id=" & i & ""
                cmd.ExecuteNonQuery()
                Dim dr As SqlClient.SqlDataReader
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                While dr.Read
                    prleft = dr.GetValue(0).ToString()
                End While

                RichTextBox1.AppendText(vbTab + vbTab + "         Clearance" + vbNewLine)
                RichTextBox1.AppendText(vbTab + vbTab + "-------------------------------------" + vbNewLine)
                RichTextBox1.AppendText(vbNewLine)
                RichTextBox1.AppendText(" Product: ")
                RichTextBox1.AppendText(vbTab + vbTab + TextBox13.Text + vbNewLine)
                RichTextBox1.AppendText(" Amount Taken: ")
                RichTextBox1.AppendText(vbTab + vbTab + TextBox12.Text + vbNewLine)
                RichTextBox1.AppendText(" Amount Left: ")
                RichTextBox1.AppendText(vbTab + vbTab + prleft)
                RichTextBox1.AppendText(vbNewLine)
                RichTextBox1.AppendText(vbTab + "===================================" + vbNewLine)


                TextBox12.Text = "0"
            End If
            disp_data()
        Catch ex As Exception
            MsgBox("Enter Data Properly Or Restart the App Again.", MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub DailyTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DailyTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DailyTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CustomerDataSet)

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim iExit As DialogResult
            iExit = MessageBox.Show("Confirm to Back", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If iExit = DialogResult.Yes Then
                firstPage.Show()
                firstPage.TextBox1.Text = ""
                firstPage.TextBox2.Text = ""
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Enter Data Properly Or Restart the App Again.", MsgBoxStyle.Information)
        End Try


    End Sub

    Public Sub disp_data()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT pr_name,pr_qty,pr_cabin,Id FROM dailyTable WHERE cu_Id='" + Label16.Text + "' AND pr_qty>0"
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
            cmd.CommandText = "SELECT pr_name,pr_qty,pr_cabin,Id FROM dailyTable where Id=" & i & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                TextBox13.Text = dr.GetString(0).ToString()
            End While
        Catch ex As Exception
            MsgBox("Something went wrong, Restart again..", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("Times New Roman", 18, FontStyle.Regular)

        e.Graphics.DrawString(RichTextBox1.Text, font1, Brushes.Black, 100, 100)
    End Sub
End Class