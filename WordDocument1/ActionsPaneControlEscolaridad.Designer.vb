<System.ComponentModel.ToolboxItemAttribute(False)> _
Partial Public Class ActionsPaneControlEscolaridad
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
        Me.LabelEscolaridad = New System.Windows.Forms.Label()
        Me.ListBoxEscolaridad = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LabelEscolaridad
        '
        Me.LabelEscolaridad.AutoSize = True
        Me.LabelEscolaridad.Location = New System.Drawing.Point(227, 16)
        Me.LabelEscolaridad.Name = "LabelEscolaridad"
        Me.LabelEscolaridad.Size = New System.Drawing.Size(62, 13)
        Me.LabelEscolaridad.TabIndex = 0
        Me.LabelEscolaridad.Text = "Escolaridad"
        '
        'ListBoxEscolaridad
        '
        Me.ListBoxEscolaridad.FormattingEnabled = True
        Me.ListBoxEscolaridad.Items.AddRange(New Object() {"Primaria", "Secundaria", "Preparatoria", "Bachillerato", "Universidad", "Maestría ", "Doctorado"})
        Me.ListBoxEscolaridad.Location = New System.Drawing.Point(230, 46)
        Me.ListBoxEscolaridad.Name = "ListBoxEscolaridad"
        Me.ListBoxEscolaridad.Size = New System.Drawing.Size(120, 95)
        Me.ListBoxEscolaridad.TabIndex = 1
        '
        'ActionsPaneControl1
        '
        Me.Controls.Add(Me.ListBoxEscolaridad)
        Me.Controls.Add(Me.LabelEscolaridad)
        Me.Name = "ActionsPaneControl1"
        Me.Size = New System.Drawing.Size(405, 150)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelEscolaridad As System.Windows.Forms.Label
    Friend WithEvents ListBoxEscolaridad As System.Windows.Forms.ListBox

End Class
