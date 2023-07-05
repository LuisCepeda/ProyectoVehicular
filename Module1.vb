Module Module1
    Public usuario_Id As Integer
    Public usuario_rol As Integer
    Public p1, p2, p3, p4 As Boolean
    Public Function Lectura()
        Dim cadena As String
        'BS##-E##-S##
        'distribucón uniforme u*a+b [b,b+a]
        Dim num_bs As String = ""
        Dim bs As Integer
        Randomize()
        bs = CInt(Rnd() * 1 + 1)
        If bs < 10 Then
            num_bs = "0" & bs
        Else
            num_bs = bs
        End If

        Dim num_e As String = ""
        Dim e As Integer
        Randomize()
        e = CInt(Rnd() * 99 + 0)
        If e < 10 Then
            num_e = "0" & e
        Else
            num_e = e
        End If

        Dim num_s As String = ""
        Dim s As Integer
        Randomize()
        s = CInt(Rnd() * 99 + 0)
        If s < 10 Then
            num_s = "0" & s
        Else
            num_s = s
        End If

        cadena = "BS" & num_bs & "-E" & num_e & "-S" & num_s
        Return cadena
    End Function
End Module
