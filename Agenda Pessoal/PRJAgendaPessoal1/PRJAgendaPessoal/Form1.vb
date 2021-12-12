Public Class FRMPrincipal

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub CadastrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarToolStripMenuItem.Click
        FRMCONTATOS.show()
    End Sub

    Private Sub SobreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreToolStripMenuItem.Click
        FRMSOBRE.Show()
    End Sub
End Class
