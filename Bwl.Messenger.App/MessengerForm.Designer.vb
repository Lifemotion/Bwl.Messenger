<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessengerForm
    Inherits Bwl.Framework.FormAppBase

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FlpUsers = New System.Windows.Forms.FlowLayoutPanel()
        Me.GbConnect = New System.Windows.Forms.GroupBox()
        Me.FlpContent = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'logWriter
        '
        Me.logWriter.Location = New System.Drawing.Point(2, 528)
        Me.logWriter.Size = New System.Drawing.Size(941, 144)
        '
        'FlpUsers
        '
        Me.FlpUsers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlpUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlpUsers.Location = New System.Drawing.Point(740, 33)
        Me.FlpUsers.Name = "FlpUsers"
        Me.FlpUsers.Size = New System.Drawing.Size(200, 492)
        Me.FlpUsers.TabIndex = 2
        '
        'GbConnect
        '
        Me.GbConnect.Location = New System.Drawing.Point(12, 27)
        Me.GbConnect.Name = "GbConnect"
        Me.GbConnect.Size = New System.Drawing.Size(200, 100)
        Me.GbConnect.TabIndex = 3
        Me.GbConnect.TabStop = False
        Me.GbConnect.Text = "Connection"
        '
        'FlpContent
        '
        Me.FlpContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlpContent.Location = New System.Drawing.Point(218, 33)
        Me.FlpContent.Name = "FlpContent"
        Me.FlpContent.Size = New System.Drawing.Size(516, 492)
        Me.FlpContent.TabIndex = 3
        '
        'MessengerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 673)
        Me.Controls.Add(Me.FlpContent)
        Me.Controls.Add(Me.GbConnect)
        Me.Controls.Add(Me.FlpUsers)
        Me.Name = "MessengerForm"
        Me.Text = "Bwl.Messenger"
        Me.Controls.SetChildIndex(Me.logWriter, 0)
        Me.Controls.SetChildIndex(Me.FlpUsers, 0)
        Me.Controls.SetChildIndex(Me.GbConnect, 0)
        Me.Controls.SetChildIndex(Me.FlpContent, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlpUsers As FlowLayoutPanel
    Friend WithEvents GbConnect As GroupBox
    Friend WithEvents FlpContent As FlowLayoutPanel
End Class
