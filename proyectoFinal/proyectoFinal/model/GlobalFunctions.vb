Module GlobalFunctions
    Public Sub closeForms(formDontClose As Form)
        My.Application.OpenForms.Cast(Of Form)() _
              .Except({frmPrincipal}) _
              .Except({formDontClose}) _
              .ToList() _
              .ForEach(Sub(form) form.Close())
    End Sub

    Public Sub openForm(form As Form)
        form.MdiParent = frmPrincipal
        closeForms(form)
        form.Dock = DockStyle.Fill
        form.Show()
    End Sub

    Public Sub ClearInputs(form As Form)
        Dim ctrl As Control
        For Each ctrl In form.Controls
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                txt.Clear()
            End If
        Next
    End Sub

    Public Function CheckEmptyTextBox(form As Form) As Boolean
        Dim ctrl As Control
        Dim empty As Boolean = False
        For Each ctrl In form.Controls
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                If txt.Text = "" Then
                    txt.BackColor = Color.LightGray
                    empty = True
                End If
            End If
        Next
        Return empty
    End Function
End Module
