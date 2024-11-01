<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        Tbx_cantidad = New TextBox()
        Tbx_resultado = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(187, 200)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(461, 200)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 1
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(374, 125)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(121, 23)
        ComboBox3.TabIndex = 2
        ' 
        ' Tbx_cantidad
        ' 
        Tbx_cantidad.Location = New Point(197, 272)
        Tbx_cantidad.Name = "Tbx_cantidad"
        Tbx_cantidad.Size = New Size(100, 23)
        Tbx_cantidad.TabIndex = 3
        ' 
        ' Tbx_resultado
        ' 
        Tbx_resultado.Location = New Point(473, 272)
        Tbx_resultado.Name = "Tbx_resultado"
        Tbx_resultado.Size = New Size(100, 23)
        Tbx_resultado.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.AppWorkspace
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(297, 127)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 21)
        Label1.TabIndex = 5
        Label1.Text = "Unidad"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.AppWorkspace
        Label2.Location = New Point(219, 254)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 15)
        Label2.TabIndex = 6
        Label2.Text = "Cantidad"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.AppWorkspace
        Label3.Location = New Point(219, 168)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 15)
        Label3.TabIndex = 7
        Label3.Text = "convetir de:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.AppWorkspace
        Label4.Location = New Point(487, 168)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 15)
        Label4.TabIndex = 8
        Label4.Text = "Convertir a :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.AppWorkspace
        Label5.Location = New Point(499, 254)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 15)
        Label5.TabIndex = 9
        Label5.Text = "Resultado"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.AppWorkspace
        Label6.Font = New Font("Segoe UI", 25F)
        Label6.Location = New Point(229, 40)
        Label6.Name = "Label6"
        Label6.Size = New Size(393, 46)
        Label6.TabIndex = 10
        Label6.Text = "Convertidor de Unidades"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-10, -10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(819, 464)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Tbx_resultado)
        Controls.Add(Tbx_cantidad)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Tbx_cantidad As TextBox
    Friend WithEvents Tbx_resultado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
