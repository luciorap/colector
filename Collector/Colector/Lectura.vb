Imports System.IO
Imports System.Data
Imports System.Data.SqlServerCe
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlConnection


Public Class Lectura

    Public password As String = ""

    Private Sub Lectura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.Crea_Tabla_RDA()

        'TODO: esta línea de código carga datos en la tabla 'OperadorDataSet.operadores' Puede moverla o quitarla según sea necesario.
        Me.OperadoresTableAdapter.Fill(Me.OperadorDataSet.operadores)
        'TODO: esta línea de código carga datos en la tabla 'LugalmDataSet.lugalm' Puede moverla o quitarla según sea necesario.
        Me.LugalmTableAdapter.Fill(Me.LugalmDataSet.lugalm)

        'TODO: esta línea de código carga datos en la tabla 'ColectorDataSet.colectores' Puede moverla o quitarla según sea necesario.
        Me.ColectoresTableAdapter.Fill(Me.ColectorDataSet.colectores)

        Me.ColectoresBindingSource.MoveLast()

        Me.DesHabilita()

    End Sub

    Private Sub Consultar()
        Consulta.ShowDialog()
    End Sub

    Private Sub Grabar()

        With Me

            If Len(Trim(.txtPrecinto.Text)) < 5 Then
                'And Len(Trim(.txtPrecinto.Text)) <> 7
                MessageBox.Show("El Precinto no es válido", "Error")
                .txtPrecinto.Focus()
                Return
            End If

            If .cmbCodDes.SelectedValue = "" Then
                MessageBox.Show("Debe ingresar el Código Destino", "Error")
                .cmbCodDes.Focus()
                Return
            End If

            If .cmbOper.SelectedValue = 0 Then
                MessageBox.Show("Debe ingresar el Operador", "Error")
                .cmbOper.Focus()
                Return
            End If

        End With

        Try

            Me.ColectoresBindingSource.EndEdit()
            Me.ColectoresTableAdapter.Update(Me.ColectorDataSet.colectores)
            Me.ColectoresBindingSource.MoveLast()

        Catch ex As Exception

            MessageBox.Show("Se produjo un error al grabar la lectura " + ex.Message, "Error")
            Me.ColectoresBindingSource.CancelEdit()

        End Try

        Me.DesHabilita()

    End Sub

    Private Sub Agregar()

        With Me

            With .TlBarra
                .Buttons(0).Enabled = True
                .Buttons(1).Enabled = True
                .Buttons(2).Enabled = False
                .Buttons(3).Enabled = False
                .Buttons(4).Enabled = False
                .Buttons(5).Enabled = False
            End With

            .BotGenerar.Enabled = False

            .txtFechaHora.Enabled = False
            .txtPrecinto.Enabled = True
            .cmbCodDes.Enabled = True
            .cmbOper.Enabled = True

            .txtPrecinto.Focus()

            .ColectoresBindingSource.AddNew()

            .txtFechaHora.Text = DateTime.Now()

            .cmbCodDes.SelectedValue = ""
            .cmbOper.SelectedValue = ""

        End With
    End Sub

    Private Sub DesHabilita()

        With Me
            .txtFechaHora.Enabled = False
            .txtPrecinto.Enabled = False
            .cmbCodDes.Enabled = False
            .cmbOper.Enabled = False

            With .TlBarra
                .Buttons(0).Enabled = False
                .Buttons(1).Enabled = False
                .Buttons(2).Enabled = True
                .Buttons(3).Enabled = True
                .Buttons(4).Enabled = True
                .Buttons(5).Enabled = True
            End With

            .BotGenerar.Enabled = True

        End With

    End Sub

    Private Sub Cancelar()
        With Me
            .ColectoresBindingSource.CancelEdit()
            .DesHabilita()
        End With
    End Sub

    Private Sub Salir()
        Me.Close()
    End Sub


    Private Sub TlBarra_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles TlBarra.ButtonClick
        Select Case TlBarra.Buttons.IndexOf(e.Button)
            Case 0
                Me.Grabar()
            Case 1
                Me.Cancelar()
            Case 2
                Me.Agregar()
            Case 3
                Me.Consultar()
            Case 4
                Me.Salir()
            Case 5
                Me.LimpiaArchivo()
        End Select
    End Sub

    Private Sub GeneraArchivo()

        'Variables para abrir el archivo en modo de escritura
        Dim strStreamW As Stream
        Dim strStreamWriter As StreamWriter = Nothing

        Dim FilePath As String = "\\SERVIDOR\F\MANISERO\Temp\Colectores.txt"
        'Dim FilePath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName.CodeBase) + "\Importar.txt"

        'Se borra el archivo si este existe
        If File.Exists(FilePath) Then File.Delete(FilePath)

        'Se abre el archivo y si este no existe se crea
        strStreamW = File.OpenWrite(FilePath)
        strStreamWriter = New StreamWriter(strStreamW, _
                            System.Text.Encoding.ASCII)

        Try

            'Se traen los datos que necesitamos para el archivo
            'en un dataset pero perfectamente
            'podria ser cualquier otro tipo de objeto

            Dim dr As DataRow
            Dim fechahora As String
            Dim precinto As String
            Dim cvelugalm As String
            Dim cveoper As String

            For Each dr In Me.ColectorDataSet.colectores.Rows
                'Obtenemos los datos del dataset
                fechahora = CStr(dr("fechahora"))
                precinto = CStr(dr("precinto"))
                cvelugalm = CStr(dr("cvelugalm"))
                cveoper = CStr(dr("cveoper"))

                'Escribimos la línea en el achivo de texto
                strStreamWriter.WriteLine(fechahora & ";" & precinto & ";" & cvelugalm & ";" & cveoper)

            Next

            strStreamWriter.Close()

            MsgBox("Se generaron las lecturas con éxito")

        Catch ex As Exception
            strStreamWriter.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotGenerar.Click
        Me.GeneraArchivo()
        'Me.Envia_Rda()
        'Me.Conecta()
    End Sub

    Private Sub LimpiaArchivo()

        password = ""

        Pass.ShowDialog()

        If UCase(Trim(password)) = "AMA59" Then

            Dim conn As SqlCeConnection = New SqlCeConnection
            Dim resultado As Integer

            conn.ConnectionString = ("Data Source =" _
                        + (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName.CodeBase) _
                        + ("\Colector.sdf;" _
                        + ("Password =" + """vila17"";"))))

            Try

                conn.Open()

                Dim cmd As SqlCeCommand = conn.CreateCommand()
                cmd.CommandText = "delete from colectores"
                resultado = cmd.ExecuteScalar

                If resultado >= 0 Then
                    If resultado > 0 Then
                        cmd.ExecuteNonQuery()
                    End If
                End If

                conn.Close()

                MsgBox("Se limpiaron las lecturas con éxito")

                Me.ColectoresTableAdapter.Fill(Me.ColectorDataSet.colectores)

                Me.ColectoresBindingSource.MoveLast()

                Me.Refresh()

            Catch ex As Exception
                conn.Close()
                MsgBox(ex.Message)
            End Try

        Else

            MsgBox("Contraseña Incorrecta")
            Return

        End If

    End Sub

    Private Sub Envia_Rda()
        'Dim rdaOleDbConnectString As String = _
        '"Provider=SQLOLEDB; Data Source=LRAPETTI;Initial Catalog=Colector; User Id=sa;Password = vila17"

        Dim rdaOleDbConnectString As String = "Data Source=LRAPETTI;Initial Catalog=Colector; " & _
            "User Id=sa;Password = <vila17>"


        Dim ConnectionString As String = ("Data Source =" _
                                + (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName.CodeBase) _
                                + ("\Colector.sdf;" _
                                + ("Password =" + """vila17"";"))))

        ' Initialize RDA Object
        '
        Dim rda As SqlCeRemoteDataAccess = Nothing

        Try
            ' Try the Push Operation
            '
            rda = New SqlCeRemoteDataAccess( _
                "http://lrapetti/colector/sqlcesa30.dll", _
                ConnectionString)

            rda.InternetLogin = "LRAPETTI\IUSR_LRAPETTI"
            rda.InternetPassword = "vila17"

            'rda.Push("Colectores", rdaOleDbConnectString, RdaBatchOption.BatchingOn)

            ' or, try this overload:
            '

            rda.Push("Colectores", rdaOleDbConnectString)

            MsgBox("Se han podido enviar los datos con exito!")

        Catch ex As SqlCeException
            ' Handle errors here
            '
            MsgBox("No se han podido enviar los datos " + ex.Message + Chr(13) + _
            ex.NativeError.ToString)

        Finally
            ' Dispose of the RDA Object
            '

            rda.Dispose()
        End Try
    End Sub

    Private Sub Crea_Tabla_RDA()

        Dim rdaOleDbConnectString As String = _
         "Provider=SQLOLEDB; Data Source=LRAPETTI;Initial Catalog=Colector; " + "User Id=sa;Password=vila17"

        Dim ConnectionString As String = ("Data Source =" _
                                + (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName.CodeBase) _
                                + ("\Colector.sdf;" _
                                + ("Password =" + """vila17"";"))))

        ' Initialize RDA Object
        '
        Dim rda As SqlCeRemoteDataAccess = Nothing

        Try
            ' Try the Pull Operation
            '
            rda = New SqlCeRemoteDataAccess( _
                "http://lrapetti/colector/sqlcesa30.dll", _
                ConnectionString)

            rda.InternetLogin = "LRAPETTI\IUSR_LRAPETTI"
            rda.InternetPassword = "vila17"

            rda.Pull("Colectores", "SELECT * FROM Colectores", rdaOleDbConnectString, _
                RdaTrackOption.TrackingOnWithIndexes, "ErrorTable")

            ' or, try one of these overloads:
            ' rda.Pull("Employees", "SELECT * FROM DimEmployee", rdaOleDbConnectString, _
            '     RdaTrackOption.TrackingOnWithIndexes)
            '
            ' rda.Pull("Employees", "SELECT * FROM DimEmployee", rdaOleDbConnectString)

        Catch ex As SqlCeException
            ' Handle errors here
            '
            MsgBox("No se pudo crear la tabla de datos " + ex.Message + Chr(13) + _
            ex.NativeError.ToString)

        Finally
            ' Dispose of the RDA Object
            '

            rda.Dispose()
        End Try
    End Sub

    Private Sub Conecta()

        Dim conn As New SqlClient.SqlConnection("user id=sa;password=vila17;database=Colector;server=LRAPETTI")

        conn.Open()

        Dim resultado As Integer

        Try

            Dim dr As DataRow
            Dim fechahora As String
            Dim precinto As String
            Dim cvelugalm As String
            Dim cveoper As String

            conn.BeginTransaction()

            For Each dr In Me.ColectorDataSet.colectores.Rows
                'Obtenemos los datos del dataset
                fechahora = CStr(dr("fechahora"))
                precinto = CStr(dr("precinto"))
                cvelugalm = CStr(dr("cvelugalm"))
                cveoper = CStr(dr("cveoper"))

                Dim cmd As SqlClient.SqlCommand = conn.CreateCommand()
                cmd.CommandText = "insert into colectores(fechahora, precinto, cvelugalmd, cveoper " + _
                "values(" + fechahora + "," + precinto + "," + cvelugalm + "," + cveoper + ")"
                resultado = cmd.ExecuteScalar

                If resultado >= 0 Then
                    If resultado > 0 Then
                        cmd.ExecuteNonQuery()
                    End If
                End If

            Next

            conn.Close()

            MsgBox("Se enviaron las lecturas con éxito")

        Catch ex As Exception

            conn.Close()
            MsgBox(ex.Message)
        End Try

    End Sub

End Class
