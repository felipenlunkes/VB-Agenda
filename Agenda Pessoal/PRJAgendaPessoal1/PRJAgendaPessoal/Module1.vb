Imports MySql.Data.MySqlClient


Module Module1

    Public con As MySqlConnection
    Public adp As MySqlDataAdapter
    Public dtr As MySqlDataReader
    Public cmmd As MySqlCommand
    Public dsbanco As DataSet
    Public sql As String
    Public banco As String = "server=192.168.50.100.; database=agenda051232; uid=root; password=suporte"

    Public Sub abrebanco()

        con = New MySqlConnection(banco)
        Try
            con.Open()

        Catch ex As Exception

            MessageBox.Show("Erro ao conectar ao banco!")

        End Try

    End Sub

    Public Sub fechabanco()

        con.Close()

    End Sub


    Public Function invertedata(ByVal strdata As String)

        Dim strnovadata As String
        strnovadata = strdata.Substring(6, 4) + "-" + strdata.Substring(3, 2) + "-" + strdata.Substring(0, 2)
        Return strnovadata

    End Function

    Sub execsql()

        cmmd.ExecuteNonQuery()

        fechabanco()

    End Sub

    Sub execselect()

        cmmd.ExecuteReader()
        fechabanco()
    End Sub




End Module
