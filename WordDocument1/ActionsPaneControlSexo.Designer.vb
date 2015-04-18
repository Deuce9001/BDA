<System.ComponentModel.ToolboxItemAttribute(False)> _
Partial Public Class ActionsPaneControlSexo
    Inherits System.Windows.Forms.UserControl

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelSexo = New System.Windows.Forms.Label()
        Me.SexoListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LabelSexo
        '
        Me.LabelSexo.AutoSize = True
        Me.LabelSexo.Location = New System.Drawing.Point(285, 17)
        Me.LabelSexo.Name = "LabelSexo"
        Me.LabelSexo.Size = New System.Drawing.Size(31, 13)
        Me.LabelSexo.TabIndex = 0
        Me.LabelSexo.Text = "Sexo"
        '
        'SexoListBox
        '
        Me.SexoListBox.FormattingEnabled = True
        Me.SexoListBox.Items.AddRange(New Object() {"M", "F"})
        Me.SexoListBox.Location = New System.Drawing.Point(288, 33)
        Me.SexoListBox.Name = "SexoListBox"
        Me.SexoListBox.Size = New System.Drawing.Size(120, 95)
        Me.SexoListBox.TabIndex = 1
        '
        'ActionsPaneControl1
        '
        Me.Controls.Add(Me.SexoListBox)
        Me.Controls.Add(Me.LabelSexo)
        Me.Name = "ActionsPaneControl1"
        Me.Size = New System.Drawing.Size(535, 150)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelSexo As System.Windows.Forms.Label
    Friend WithEvents SexoListBox As System.Windows.Forms.ListBox

End Class
