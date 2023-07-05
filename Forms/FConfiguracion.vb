Public Class FConfiguracion
    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsuariosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UsuariosDS)

    End Sub

    Private Sub FConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UsuariosDS.Usuarios' table. You can move, or remove it, as needed.
        Me.UsuariosTableAdapter.Fill(Me.UsuariosDS.Usuarios)

    End Sub
End Class