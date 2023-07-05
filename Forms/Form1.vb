Public Class Form1
    'Definición de Variables
    Dim usuario1 As New UsuariosDS 'Datos
    Dim adaptadorusuario1 As New UsuariosDSTableAdapters.UsuariosTableAdapter
    Dim roles1 As New RolesDS
    Dim adaptadorroles As New RolesDSTableAdapters.RolesTableAdapter

    'table adapter consultas
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'adaptaror.consulta(dataset.tabla,variables)
        adaptadorusuario1.FillByDocumento(usuario1.Usuarios, Text_documento.Text)
        If usuario1.Usuarios.Rows.Count > 0 Then
            'MsgBox("Usuario Existe")
            If Text_password.Text = usuario1.Usuarios.Rows(0).Item(3) Then
                Dim idRol As Integer = usuario1.Usuarios.Rows(0).Item(4)
                adaptadorroles.FillByIdrol(roles1.Roles, idRol)
                'MsgBox("Rol:" & roles1.Roles.Rows(0).Item(1))
                ''MsgBox(roles1.Roles.Rows(0).Item(2))
                usuario_Id = usuario1.Usuarios.Rows(0).Item(0)
                usuario_rol = usuario1.Usuarios.Rows(0).Item(4)
                p1 = roles1.Roles.Rows(0).Item(2)
                p2 = roles1.Roles.Rows(0).Item(3)
                p3 = roles1.Roles.Rows(0).Item(4)
                p4 = roles1.Roles.Rows(0).Item(5)
                FPrincipal.Show()
                Me.Close()
            Else
                MsgBox("Contraseña Incorrecta")
            End If
        Else
                MsgBox("Usuario No Existe")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
