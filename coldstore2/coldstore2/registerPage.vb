Imports System.Data.SqlClient
Public Class registerPage
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub CustomerDataTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerDataTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerDataTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CustomerDataSet)

    End Sub

    Private Sub RegisterPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\coldstore2\coldstore2\coldStoreDatabase.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cu_nameTextBox.Text = ""
        Cu_phone1TextBox.Text = ""
        Cu_phone2TextBox.Text = ""
        Cu_addressTextBox.Text = ""
        Cu_commentsTextBox.Text = ""
        Cu_due_amountTextBox.Text = "0"
    End Sub

    Private Sub IdLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Cu_due_amountTextBox_TextChanged(sender As Object, e As EventArgs) Handles Cu_due_amountTextBox.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then

            firstPage.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Cu_nameTextBox.Text = Nothing Or Cu_phone1TextBox.Text = Nothing Or Cu_addressTextBox.Text = Nothing Then
            MsgBox("Enter all the requierd fields", MsgBoxStyle.Critical)
        Else
            Dim iSave As DialogResult
            iSave = MessageBox.Show("Confirm to Save", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If iSave = DialogResult.Yes Then
                Try
                    Dim dueamount As Integer
                    Dim amount As Integer
                    dueamount = Convert.ToInt32(Cu_due_amountTextBox.Text)
                    amount = Convert.ToInt32(Cu_due_amountTextBox.Text)
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                    Dim cmd As New SqlCommand("select count(*) from customerDataTable where cu_phone1='" + Cu_phone1TextBox.Text + "' and cu_name='" + Cu_nameTextBox.Text + "'", con)

                    Dim count = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then
                        MsgBox("Name and Phone is already exist!!!", MsgBoxStyle.Critical)
                    Else
                        If con.State = ConnectionState.Closed Then
                            con.Open()
                        End If
                        cmd = con.CreateCommand()
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = "INSERT INTO customerDataTable (cu_name,cu_phone1,cu_phone2,cu_address,cu_due_amount,cu_total_amount,cu_comments) VALUES('" & Cu_nameTextBox.Text & "','" & Cu_phone1TextBox.Text & "','" & Cu_phone2TextBox.Text & "','" & Cu_addressTextBox.Text & "'," & dueamount & "," & amount & ",'" & Cu_commentsTextBox.Text & "')"
                        cmd.ExecuteNonQuery()
                    End If
                Catch ex As Exception
                    MsgBox("Sorry, Try again!!", MsgBoxStyle.Critical)
                End Try
                Cu_nameTextBox.Text = ""
                Cu_addressTextBox.Text = ""
                Cu_addressTextBox.Text = ""
                Cu_phone1TextBox.Text = ""
                Cu_phone2TextBox.Text = ""
                Cu_total_amountTextBox.Text = ""
                Cu_commentsTextBox.Text = ""
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Cu_due_amountTextBox.Text = Cu_total_amountTextBox.Text
        Catch ex As Exception
            MsgBox("Enter Only Number!", MsgBoxStyle.Information)
        End Try

    End Sub
End Class