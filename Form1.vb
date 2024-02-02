Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim lang As String
        Dim prog As String

        If CheckBox1.Checked And CheckBox2.Checked Then
            lang = CheckBox1.Text + ", " + CheckBox2.Text
        ElseIf CheckBox1.Checked Then
            lang = CheckBox1.Text
        ElseIf CheckBox2.Checked Then
            lang = CheckBox2.Text
        End If

        If RadioButton1.Checked Then
            prog = RadioButton1.Text
        Else
            prog = RadioButton2.Text
        End If
        RichTextBox1.Text = TextBox1.Text + " " + TextBox2.Text + " " + lang + " " + prog

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Form1.ActiveForm.BackColor = Color.Red
        Dim list As Object = ListBox1.SelectedItems
        For Each il In list
            ComboBox1.Items.Add(il)
        Next

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Dim colorVal As String = ListBox1.Text
        'If colorVal = "Red" Then
        '    Form1.ActiveForm.BackColor = Color.Red
        'ElseIf colorVal = "Green" Then
        '    Form1.ActiveForm.BackColor = Color.Green
        'ElseIf colorVal = "Blue" Then
        '    Form1.ActiveForm.BackColor = Color.Blue
        'End If
        'Dim colorVal As String = ComboBox1.Text
        'If colorVal = "Red" Then
        '    Form1.ActiveForm.BackColor = Color.Red
        'ElseIf colorVal = "Green" Then
        '    Form1.ActiveForm.BackColor = Color.Green
        'ElseIf colorVal = "Blue" Then
        '    Form1.ActiveForm.BackColor = Color.Blue
        'End If

        ColorDialog1.ShowDialog()
        Form1.ActiveForm.BackColor = ColorDialog1.Color



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SaveFileDialog1.ShowDialog()
        File.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        OpenFileDialog1.ShowDialog()
        RichTextBox1.Text = File.ReadAllText(OpenFileDialog1.FileName)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FontDialog1.ShowDialog()
        RichTextBox1.Font = FontDialog1.Font
    End Sub
End Class
