Imports MySql.Data.MySqlClient

Public Class FRMCONTATOS

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTEMAIL.TextChanged

    End Sub

    Private Sub CMDGRAVAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDGRAVAR.Click

        Dim sql As String

        Try

            abrebanco()
            sql = "insert into contatos values(null,@p2,@p3,@p4,@p5,@p6)"
            cmmd = New MySqlCommand(sql, con)

            cmmd.Parameters.AddWithValue("@p2", TXTNOME.Text)
            cmmd.Parameters.AddWithValue("@p3", TXTEMAIL.Text)
            cmmd.Parameters.AddWithValue("@p4", TXTFIXO.Text)
            cmmd.Parameters.AddWithValue("@p5", TXTCELULAR.Text)
            cmmd.Parameters.AddWithValue("@p6", invertedata(MSKDATA.Text))

            cmmd.ExecuteNonQuery()

            fechabanco()

        Catch ex As Exception
            MsgBox("Erro ao cadastrar!", MsgBoxStyle.Information, "Aviso!")

        End Try


        limpar()

















    End Sub

    Private Sub limpar()

        TXTCELULAR.Text = ""
        TXTEMAIL.Text = ""
        TXTFIXO.Text = ""
        TXTID.Text = ""
        TXTNOME.Text = ""
        MSKDATA.Text = ""

    End Sub
    Private Sub CMDPESQUISAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDPESQUISAR.Click

        abrebanco()
        Sql = "select * from contatos where nome='" + TXTNOME.Text + "'"
        cmmd = New MySqlCommand(Sql, con)
        dtr = cmmd.ExecuteReader()
        If dtr.Read() Then
            TXTID.Text = dtr(0).ToString
            TXTNOME.Text = dtr(1).ToString
            TXTEMAIL.Text = dtr(2).ToString
            TXTFIXO.Text = dtr(3).ToString
            TXTCELULAR.Text = dtr(4).ToString
            MSKDATA.Text = dtr(5).ToString
            cmdalterar.visible = True
            cmdexcluir.visible = True
        Else

            MsgBox("Contato não cadastrado!", MsgBoxStyle.Information, "Atenção!")


        End If

        dtr.Close()
        fechabanco()


    End Sub

    Private Sub CMDALTERAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDALTERAR.Click

        abrebanco()
        sql = "update contatos set nome=@p2, email=@p3, telfixo=@p4, celular=@p5, datanasc=@p6 where nome=@p2"

        cmmd = New MySqlCommand(sql, con)
        cmmd.Parameters.AddWithValue("@p2", TXTNOME.Text)
        cmmd.Parameters.AddWithValue("@p3", TXTEMAIL.Text)
        cmmd.Parameters.AddWithValue("@p4", TXTFIXO.Text)
        cmmd.Parameters.AddWithValue("@p5", TXTCELULAR.Text)
        cmmd.Parameters.AddWithValue("@p6", invertedata(MSKDATA.Text))
        execsql()



    End Sub

    Private Sub CMDEXCLUIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEXCLUIR.Click

        If (MsgBox("Você deseja excluir este contato?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção!")) = MsgBoxResult.Yes Then

            abrebanco()
            sql = "delete from contatos where nome='" + TXTNOME.Text + "'"
            cmmd = New MySqlCommand(sql, con)
            execsql()
            limpar()

        End If

    End Sub
End Class