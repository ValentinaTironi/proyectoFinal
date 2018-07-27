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
End Module
