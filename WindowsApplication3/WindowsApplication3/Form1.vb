Public Class Form1

    Public Function Initialize()
        Label3.Text = "0.00"
        Form2.Visible = False
        Form5.Visible = False
        Form3.Visible = False
        LogIn.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        RadioButton1.Checked = True
        If DataGridView1.Columns.Count = 0 Then
            With Me.DataGridView1
                .Visible = True
                .AutoGenerateColumns = False
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender
                .BackColor = Color.WhiteSmoke
                .ForeColor = Color.MidnightBlue
                .CellBorderStyle = DataGridViewCellBorderStyle.None
                .ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 8.0!, FontStyle.Bold)
                .ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke
                .DefaultCellStyle.ForeColor = Color.MidnightBlue
                .DefaultCellStyle.BackColor = Color.WhiteSmoke
            End With
            Dim newColumn As Integer = Me.DataGridView1.Columns.Add("NameP", "Name")
            Me.DataGridView1.Columns(newColumn).DataPropertyName = "NameP"

            newColumn = Me.DataGridView1.Columns.Add("PriceP", "Price")
            Me.DataGridView1.Columns(newColumn).DataPropertyName = "Price"

            newColumn = Me.DataGridView1.Columns.Add("VAT", "V.A.T.")
            Me.DataGridView1.Columns(newColumn).DataPropertyName = "V.A.T"

            newColumn = Me.DataGridView1.Columns.Add("QuantityP", "Quantity")
            Me.DataGridView1.Columns(newColumn).DataPropertyName = "Quantity"

        End If

        Me.DataGridView1.Rows.Clear()
        Return 1
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton2.Checked Then
            TextBox2.Text = TextBox2.Text + "1"
        ElseIf RadioButton1.Checked Then
            TextBox1.Text = TextBox1.Text + "1"
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If (DataGridView1.RowCount Mod 2) - 1 = 0 Then
            DataGridView1.Rows.Insert(DataGridView1.RowCount - 1, New String() {"Coca Cola Light", "0.50", "19", "4"})
        Else
            DataGridView1.Rows.Insert(DataGridView1.RowCount - 1, New String() {"Water Medium", "3.00", "19", "1"})
        End If
        DataGridView1.AutoResizeColumns()

        Label3.Text = CDec(Label3.Text) + CDec(DataGridView1.Item(1, DataGridView1.RowCount - 2).Value * DataGridView1.Item(3, DataGridView1.RowCount - 2).Value) / 100
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If (Button15.Visible = False) Then
            Button15.Visible = True
            Button16.Visible = True
            Button17.Visible = True
            Button19.Visible = True
        Else
            Button15.Visible = False
            Button16.Visible = False
            Button17.Visible = False
            Button19.Visible = False
        End If

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If (DataGridView1.RowCount Mod 2) - 1 = 0 Then
            DataGridView1.Rows.Insert(DataGridView1.RowCount - 1, New String() {"Sandwitch Tuna", "3.50", "19", "1"})
        Else
            DataGridView1.Rows.Insert(DataGridView1.RowCount - 1, New String() {"Sandwitch Ham", "3.00", "19", "1"})
        End If
        DataGridView1.AutoResizeColumns()

        Label3.Text = CDec(Label3.Text) + CDec(DataGridView1.Item(1, DataGridView1.RowCount - 2).Value * DataGridView1.Item(3, DataGridView1.RowCount - 2).Value) / 100
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        DataGridView1.Rows.Insert(DataGridView1.RowCount - 1, New String() {"Simerini", "1.80", "19", "1"})
        DataGridView1.AutoResizeColumns()

        Label3.Text = CDec(Label3.Text) + CDec(DataGridView1.Item(1, DataGridView1.RowCount - 2).Value * DataGridView1.Item(3, DataGridView1.RowCount - 2).Value) / 100
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        DataGridView1.Rows.Insert(DataGridView1.RowCount - 1, New String() {"Medical Gauze", "2.00", "19", "1"})
        DataGridView1.AutoResizeColumns()

        Label3.Text = CDec(Label3.Text) + CDec(DataGridView1.Item(1, DataGridView1.RowCount - 2).Value * DataGridView1.Item(3, DataGridView1.RowCount - 2).Value) / 100
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Button15.Visible = False
        Button16.Visible = False
        Button17.Visible = False
        Button19.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        Form5.Initialize(Label3.Text)
        Form5.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Visible = False
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        LogIn.Initialize()
        LogIn.Visible = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Button15.Visible = False
        Button16.Visible = False
        Button17.Visible = False
        Button19.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        If (DataGridView1.RowCount Mod 3) - 1 = 0 Then
            DataGridView1.Rows.Insert(DataGridView1.RowCount - 1, New String() {"Coca Cola Light", "0.50", "19", "4"})
        ElseIf (DataGridView1.RowCount Mod 3) - 1 = 1 Then
            DataGridView1.Rows.Insert(DataGridView1.RowCount - 1, New String() {"Kit-Kat Large", "1.50", "19", "2"})
        Else
            DataGridView1.Rows.Insert(DataGridView1.RowCount - 1, New String() {"Water Medium", "3.00", "19", "1"})
        End If
        DataGridView1.AutoResizeColumns()

        Label3.Text = CDec(Label3.Text) + CDec(DataGridView1.Item(1, DataGridView1.RowCount - 2).Value * DataGridView1.Item(3, DataGridView1.RowCount - 2).Value) / 100

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Initialize()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButton2.Checked Then
            TextBox2.Text = TextBox2.Text + "2"
        ElseIf RadioButton1.Checked Then
            TextBox1.Text = TextBox1.Text + "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If RadioButton2.Checked Then
            TextBox2.Text = TextBox2.Text + "3"
        ElseIf RadioButton1.Checked Then
            TextBox1.Text = TextBox1.Text + "3"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If RadioButton2.Checked Then
            TextBox2.Text = TextBox2.Text + "4"
        ElseIf RadioButton1.Checked Then
            TextBox1.Text = TextBox1.Text + "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If RadioButton2.Checked Then
            TextBox2.Text = TextBox2.Text + "5"
        ElseIf RadioButton1.Checked Then
            TextBox1.Text = TextBox1.Text + "5"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If RadioButton2.Checked Then
            TextBox2.Text = TextBox2.Text + "6"
        ElseIf RadioButton1.Checked Then
            TextBox1.Text = TextBox1.Text + "6"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If RadioButton2.Checked Then
            TextBox2.Text = TextBox2.Text + "7"
        ElseIf RadioButton1.Checked Then
            TextBox1.Text = TextBox1.Text + "7"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If RadioButton2.Checked Then
            TextBox2.Text = TextBox2.Text + "8"
        ElseIf RadioButton1.Checked Then
            TextBox1.Text = TextBox1.Text + "8"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If RadioButton2.Checked Then
            TextBox2.Text = TextBox2.Text + "9"
        ElseIf RadioButton1.Checked Then
            TextBox1.Text = TextBox1.Text + "9"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If RadioButton2.Checked Then
            TextBox2.Text = TextBox2.Text + "0"
        ElseIf RadioButton1.Checked Then
            TextBox1.Text = TextBox1.Text + "0"
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        If RadioButton2.Checked Then
            If TextBox2.Text.Length <> 0 Then
                TextBox2.Text = TextBox2.Text.Substring(0, TextBox2.Text.Length - 1)
            End If
        ElseIf RadioButton1.Checked Then
            If TextBox1.Text <> "" Then
                TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
                If TextBox1.Text = "0" Then
                    TextBox1.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub fileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles fileToolStripMenuItem.Click

    End Sub

    Private Sub exitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click
        End
    End Sub
End Class
