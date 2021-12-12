<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMCONTATOS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MSKDATA = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTID = New System.Windows.Forms.TextBox()
        Me.TXTNOME = New System.Windows.Forms.TextBox()
        Me.TXTEMAIL = New System.Windows.Forms.TextBox()
        Me.TXTFIXO = New System.Windows.Forms.TextBox()
        Me.TXTCELULAR = New System.Windows.Forms.TextBox()
        Me.CMDGRAVAR = New System.Windows.Forms.Button()
        Me.CMDPESQUISAR = New System.Windows.Forms.Button()
        Me.CMDALTERAR = New System.Windows.Forms.Button()
        Me.CMDEXCLUIR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código (ID):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefone Fixo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telefone Celular:"
        '
        'MSKDATA
        '
        Me.MSKDATA.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MSKDATA.Location = New System.Drawing.Point(233, 388)
        Me.MSKDATA.Mask = "00/00/0000"
        Me.MSKDATA.Name = "MSKDATA"
        Me.MSKDATA.Size = New System.Drawing.Size(183, 33)
        Me.MSKDATA.TabIndex = 5
        Me.MSKDATA.ValidatingType = GetType(Date)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 396)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Data de nascimento:"
        '
        'TXTID
        '
        Me.TXTID.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTID.Location = New System.Drawing.Point(390, 23)
        Me.TXTID.Name = "TXTID"
        Me.TXTID.Size = New System.Drawing.Size(195, 33)
        Me.TXTID.TabIndex = 7
        '
        'TXTNOME
        '
        Me.TXTNOME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTNOME.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNOME.Location = New System.Drawing.Point(233, 110)
        Me.TXTNOME.Name = "TXTNOME"
        Me.TXTNOME.Size = New System.Drawing.Size(264, 33)
        Me.TXTNOME.TabIndex = 8
        '
        'TXTEMAIL
        '
        Me.TXTEMAIL.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TXTEMAIL.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTEMAIL.Location = New System.Drawing.Point(233, 179)
        Me.TXTEMAIL.Name = "TXTEMAIL"
        Me.TXTEMAIL.Size = New System.Drawing.Size(264, 33)
        Me.TXTEMAIL.TabIndex = 9
        '
        'TXTFIXO
        '
        Me.TXTFIXO.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFIXO.Location = New System.Drawing.Point(233, 254)
        Me.TXTFIXO.Name = "TXTFIXO"
        Me.TXTFIXO.Size = New System.Drawing.Size(258, 33)
        Me.TXTFIXO.TabIndex = 10
        '
        'TXTCELULAR
        '
        Me.TXTCELULAR.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCELULAR.Location = New System.Drawing.Point(233, 322)
        Me.TXTCELULAR.Name = "TXTCELULAR"
        Me.TXTCELULAR.Size = New System.Drawing.Size(258, 33)
        Me.TXTCELULAR.TabIndex = 11
        '
        'CMDGRAVAR
        '
        Me.CMDGRAVAR.Location = New System.Drawing.Point(639, 110)
        Me.CMDGRAVAR.Name = "CMDGRAVAR"
        Me.CMDGRAVAR.Size = New System.Drawing.Size(163, 78)
        Me.CMDGRAVAR.TabIndex = 12
        Me.CMDGRAVAR.Text = "Gravar"
        Me.CMDGRAVAR.UseVisualStyleBackColor = True
        '
        'CMDPESQUISAR
        '
        Me.CMDPESQUISAR.Location = New System.Drawing.Point(639, 235)
        Me.CMDPESQUISAR.Name = "CMDPESQUISAR"
        Me.CMDPESQUISAR.Size = New System.Drawing.Size(163, 74)
        Me.CMDPESQUISAR.TabIndex = 13
        Me.CMDPESQUISAR.Text = "Pesquisar"
        Me.CMDPESQUISAR.UseVisualStyleBackColor = True
        '
        'CMDALTERAR
        '
        Me.CMDALTERAR.Location = New System.Drawing.Point(32, 486)
        Me.CMDALTERAR.Name = "CMDALTERAR"
        Me.CMDALTERAR.Size = New System.Drawing.Size(114, 75)
        Me.CMDALTERAR.TabIndex = 14
        Me.CMDALTERAR.Text = "Alterar"
        Me.CMDALTERAR.UseVisualStyleBackColor = True
        Me.CMDALTERAR.Visible = False
        '
        'CMDEXCLUIR
        '
        Me.CMDEXCLUIR.Location = New System.Drawing.Point(207, 486)
        Me.CMDEXCLUIR.Name = "CMDEXCLUIR"
        Me.CMDEXCLUIR.Size = New System.Drawing.Size(108, 75)
        Me.CMDEXCLUIR.TabIndex = 15
        Me.CMDEXCLUIR.Text = "Excluir"
        Me.CMDEXCLUIR.UseVisualStyleBackColor = True
        Me.CMDEXCLUIR.Visible = False
        '
        'FRMCONTATOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 573)
        Me.Controls.Add(Me.CMDEXCLUIR)
        Me.Controls.Add(Me.CMDALTERAR)
        Me.Controls.Add(Me.CMDPESQUISAR)
        Me.Controls.Add(Me.CMDGRAVAR)
        Me.Controls.Add(Me.TXTCELULAR)
        Me.Controls.Add(Me.TXTFIXO)
        Me.Controls.Add(Me.TXTEMAIL)
        Me.Controls.Add(Me.TXTNOME)
        Me.Controls.Add(Me.TXTID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MSKDATA)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FRMCONTATOS"
        Me.Text = "Contatos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MSKDATA As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXTID As System.Windows.Forms.TextBox
    Friend WithEvents TXTNOME As System.Windows.Forms.TextBox
    Friend WithEvents TXTEMAIL As System.Windows.Forms.TextBox
    Friend WithEvents TXTFIXO As System.Windows.Forms.TextBox
    Friend WithEvents TXTCELULAR As System.Windows.Forms.TextBox
    Friend WithEvents CMDGRAVAR As System.Windows.Forms.Button
    Friend WithEvents CMDPESQUISAR As System.Windows.Forms.Button
    Friend WithEvents CMDALTERAR As System.Windows.Forms.Button
    Friend WithEvents CMDEXCLUIR As System.Windows.Forms.Button
End Class
