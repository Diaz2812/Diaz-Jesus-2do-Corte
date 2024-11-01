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
        TextBoxPrestatario = New TextBox()
        ComboBoxLibro = New ComboBox()
        ComboBoxDevolver = New ComboBox()
        ButtonPrestar = New Button()
        ButtonDevolver = New Button()
        Label1 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBoxPrestatario
        ' 
        TextBoxPrestatario.Location = New Point(315, 290)
        TextBoxPrestatario.Name = "TextBoxPrestatario"
        TextBoxPrestatario.Size = New Size(100, 23)
        TextBoxPrestatario.TabIndex = 0
        ' 
        ' ComboBoxLibro
        ' 
        ComboBoxLibro.FormattingEnabled = True
        ComboBoxLibro.Location = New Point(178, 181)
        ComboBoxLibro.Name = "ComboBoxLibro"
        ComboBoxLibro.Size = New Size(121, 23)
        ComboBoxLibro.TabIndex = 1
        ' 
        ' ComboBoxDevolver
        ' 
        ComboBoxDevolver.FormattingEnabled = True
        ComboBoxDevolver.Location = New Point(425, 181)
        ComboBoxDevolver.Name = "ComboBoxDevolver"
        ComboBoxDevolver.Size = New Size(121, 23)
        ComboBoxDevolver.TabIndex = 2
        ' 
        ' ButtonPrestar
        ' 
        ButtonPrestar.Font = New Font("Segoe UI", 12F)
        ButtonPrestar.Location = New Point(179, 139)
        ButtonPrestar.Name = "ButtonPrestar"
        ButtonPrestar.Size = New Size(121, 29)
        ButtonPrestar.TabIndex = 3
        ButtonPrestar.Text = "Prestar Libro"
        ButtonPrestar.UseVisualStyleBackColor = True
        ' 
        ' ButtonDevolver
        ' 
        ButtonDevolver.Font = New Font("Segoe UI", 12F)
        ButtonDevolver.Location = New Point(425, 138)
        ButtonDevolver.Name = "ButtonDevolver"
        ButtonDevolver.Size = New Size(121, 29)
        ButtonDevolver.TabIndex = 4
        ButtonDevolver.Text = "Devolver Libro"
        ButtonDevolver.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(287, 257)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 21)
        Label1.TabIndex = 5
        Label1.Text = "Nombre del Prestario"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaptionText
        Label2.Font = New Font("Segoe UI", 25F)
        Label2.ForeColor = SystemColors.ActiveCaption
        Label2.Location = New Point(211, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(325, 46)
        Label2.TabIndex = 6
        Label2.Text = "Biblioteca Jesus Diaz"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1, -20)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(802, 473)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ButtonDevolver)
        Controls.Add(ButtonPrestar)
        Controls.Add(ComboBoxDevolver)
        Controls.Add(ComboBoxLibro)
        Controls.Add(TextBoxPrestatario)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxPrestatario As TextBox
    Friend WithEvents ComboBoxLibro As ComboBox
    Friend WithEvents ComboBoxDevolver As ComboBox
    Friend WithEvents ButtonPrestar As Button
    Friend WithEvents ButtonDevolver As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
