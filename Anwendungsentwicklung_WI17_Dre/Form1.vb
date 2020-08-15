Public Class Form1
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim Result As Integer

        Try
            Result = Me.CalculateFormula(FormulaTextBox.Text)
            ResultValueLabel.Text = Result
        Catch
            MessageBox.Show("Bitte geben sie eine Formel ein. Erlaubt sind einziffrige Operanden, Leerzeichen und die Operatoren Plus und Minus. Außerdem kann das letzte Zeichen ein Gleichheitszeichen sein.", "Invalide Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Function CalculateFormula(Formula As String) As Integer
        ' Throw exception if input is empty
        If Formula Is Nothing Or Formula.Length < 1 Then Throw New InvalidOperationException()
        ' Remove last character if last character is =
        If Formula.Substring(Formula.Length - 1, 1) = "=" Then Formula = Formula.Remove(Formula.Length - 1, 1)
        ' Remove whitespaces from input
        Dim FormulaWithoutWhitespaces = Me.RemoveWhitespaces(Formula)
        ' Throw exception if input length < 3
        If FormulaWithoutWhitespaces.Length < 3 Then Throw New InvalidOperationException()
        ' Throw exception if last char is + or -
        Dim LastFormulaChar = FormulaWithoutWhitespaces.Substring(FormulaWithoutWhitespaces.Length - 1, 1)
        If LastFormulaChar = "+" Or LastFormulaChar = "-" Then Throw New InvalidOperationException()
        ' Start calculation
        Dim Result As Integer
        For I = 0 To FormulaWithoutWhitespaces.Length - 1
            Dim CurrentChar = FormulaWithoutWhitespaces.Substring(I, 1)
            If I = 0 Then
                ' The first character (should be a number) is added
                Result = Result + Convert.ToInt32(CurrentChar)
            ElseIf I Mod 2 <> 0 Then
                ' Any character in an odd position should be an operator
                If CurrentChar <> "+" And CurrentChar <> "-" Then Throw New InvalidOperationException()
                Continue For
            ElseIf I Mod 2 = 0 Then
                ' Every character in an even position should be an operand
                ' Get last operator
                Dim LastChar = FormulaWithoutWhitespaces.Substring(I - 1, 1)
                If LastChar = "+" Then
                    Result = Result + Convert.ToInt32(CurrentChar)
                ElseIf LastChar = "-" Then
                    Result = Result - Convert.ToInt32(CurrentChar)
                Else
                    Throw New InvalidOperationException()
                End If
            End If
        Next I
        Return Result
    End Function

    Function RemoveWhitespaces(str As String) As String
        Return New String(str.Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray())
    End Function
End Class
