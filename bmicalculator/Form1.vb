Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim height, weight, bmi, metre, inch As Single
        metre = TextBox1.Text
        inch = TextBox3.Text
        height = ((metre * 0.3048) + (inch * 0.0254))
        weight = TextBox2.Text
        bmi = ((weight) / (height ^ 2))
        Label1.Text = "Your BMI is  " & bmi
        Label5.Visible = True
        Label6.Visible = True
        If bmi < 18.49 Then Label6.Text = "You are underweight!"
        If bmi > 18.49 And bmi < 24.9 Then Label6.Text = "You are normal!"
        If bmi > 25 And bmi < 29.9 Then Label6.Text = "You are a overweight!"
        If bmi > 30 Then Label6.Text = "You are obess!"
    End Sub
End Class
