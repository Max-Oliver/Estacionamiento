Imports ADODB
Module MetodosBD
    Dim dr As OleDb.OleDbDataReader
    Dim sqlCommand As New OleDb.OleDbCommand
    Dim cn As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    '////////////////////////////////////////////
    Dim fd = My.Forms.frmPrincipal.odfAbrirArchivo
    Dim obj_FSO As Object
    Dim Archivo As Object

    Public Function general(ByVal code)
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\Conexion.txt") = False Then
            If fd.ShowDialog() = DialogResult.OK Then
                obj_FSO = CreateObject("Scripting.FileSystemObject")
                Archivo = obj_FSO.CreateTextFile(Application.StartupPath & "\Conexion.txt", True)
                Archivo.WriteLine(fd.FileName())
                Archivo.Close()

                general(code)
            Else
                Application.ExitThread()
            End If
        End If
        Dim ruta As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Conexion.txt")

        ds = New DataSet
        cn = New OleDb.OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" & ruta)
        Try
            cn.Open()
            da = New Data.OleDb.OleDbDataAdapter(code, cn)
            sqlCommand.Connection = cn
            sqlCommand.CommandText = code
        Catch ex As Exception
            MessageBox.Show("No se encontró la Base de datos, puede que se halla movido a otro sitio")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Conexion.txt")
            general(code)
        End Try
        Return True
    End Function

    Public Sub ejecutarSql(ByVal code) 'alta. baja, mod
        If general(code) Then
            sqlCommand.ExecuteNonQuery()
            cn.Close()
        End If
    End Sub

    Public Sub consulta(ByVal dgv As DataGridView, ByVal code As String)
        If general(code) Then
            da.Fill(ds)
            cn.Close()
            dgv.DataSource = ds.Tables(0)
        End If
    End Sub

    Function contiene(ByVal code)
        If general(code) Then
            dr = sqlCommand.ExecuteReader()
            Dim val As Boolean = dr.HasRows
            cn.Close()
            Return val
        End If
    End Function

    Public Sub datos(ByVal box, ByVal code, ByVal code2)
        If general(code) Then
            dr = sqlCommand.ExecuteReader()
            While dr.Read = True
                If TypeOf box Is ComboBox Or TypeOf box Is ListBox Or TypeOf box Is CheckBox Then
                    box.items.add(dr(code2))
                ElseIf TypeOf box Is DataGridView Then
                    MsgBox("Ingresa datos al dgv")
                End If
            End While
            cn.Close()
        End If
    End Sub

    Function retornoCelda(ByVal code, ByVal code2)
        If general(code) Then
            Dim celda As String
            dr = sqlCommand.ExecuteReader()
            If dr.Read = True Then
                celda = dr(code2)
            Else
                celda = ""
            End If
            cn.Close()
            Return celda
        End If
       
    End Function
End Module