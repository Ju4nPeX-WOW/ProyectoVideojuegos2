Public Class Empleado
    Protected _id As Short
    Protected _nombre As String
    Protected _apellidos As String
    Protected _rut As Integer
    Protected _email As String

    Public Property ID()
        Get
            Return _id
        End Get
        Set(value)
            _id = value
        End Set
    End Property

    Public Property Nombre()
        Get
            Return _nombre
        End Get
        Set(value)
            _nombre = value
        End Set
    End Property
    Public Property Apellidos()
        Get
            Return _apellidos
        End Get
        Set(value)
            _apellidos = value
        End Set
    End Property
    Public Property Rut()
        Get
            Return _rut
        End Get
        Set(value)
            _rut = value
        End Set
    End Property
    Public Property Email()
        Get
            Return _email
        End Get
        Set(value)
            _email = value
        End Set
    End Property



    Public Function ValidarRut(rut As String, exDV As String)
        Dim valido = False 'Boolean a retornar
        Dim inDV = CalcularDV(rut) 'Digito Verificador que debe ser 
        'si corresponde se hace el cambio de : 10 a K - 11 a 0
        If inDV.Equals("10") Then
            inDV = "K"
        ElseIf inDV.Equals("11") Then
            inDV = "0"
        End If
        'se determina si es valido
        If inDV.Equals(exDV) Then
            valido = True
        Else
            valido = False
        End If
        Return valido
    End Function

    Public Function GetDV(rut As String)
        Dim inDV = CalcularDV(rut) 'Digito Verificador que debe ser 
        Return inDV


    End Function

    Private Function CalcularDV(rut As String)
        Dim serie = 2      'serie numerica 2 a 7
        Dim suma = 0
        'Se recorre el rut de derecha a izquierda
        For i = rut.Length To 1 Step -1
            'se obtiene la suma de la multiplicacion de los digitos por la serie numerica 2 a 7
            suma = suma + (Integer.Parse(rut(i - 1)) * serie)
            If serie = 7 Then   'reiniciamos la serie
                serie = 2
            Else
                serie += 1      'aumentamos en 1 la serie
            End If
        Next
        Return (11 - (suma - (11 * (suma \ 11)))).ToString 'se obtiene el digito verificador
    End Function
End Class
