<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.SourcePathBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonSRC = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialogSRC = New System.Windows.Forms.FolderBrowserDialog()
        Me.DSTPathBox = New System.Windows.Forms.TextBox()
        Me.ButtonDST = New System.Windows.Forms.Button()
        Me.FolderBrowserDialogDST = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ExtBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'SourcePathBox1
        '
        Me.SourcePathBox1.Location = New System.Drawing.Point(98, 15)
        Me.SourcePathBox1.Name = "SourcePathBox1"
        Me.SourcePathBox1.Size = New System.Drawing.Size(237, 20)
        Me.SourcePathBox1.TabIndex = 0
        '
        'ButtonSRC
        '
        Me.ButtonSRC.Location = New System.Drawing.Point(340, 12)
        Me.ButtonSRC.Name = "ButtonSRC"
        Me.ButtonSRC.Size = New System.Drawing.Size(56, 23)
        Me.ButtonSRC.TabIndex = 1
        Me.ButtonSRC.Text = "Browse"
        Me.ButtonSRC.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(10, 121)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Create Shortcuts"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Destination Path"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Source Path"
        '
        'DSTPathBox
        '
        Me.DSTPathBox.Location = New System.Drawing.Point(98, 41)
        Me.DSTPathBox.Name = "DSTPathBox"
        Me.DSTPathBox.Size = New System.Drawing.Size(237, 20)
        Me.DSTPathBox.TabIndex = 2
        '
        'ButtonDST
        '
        Me.ButtonDST.Location = New System.Drawing.Point(340, 41)
        Me.ButtonDST.Name = "ButtonDST"
        Me.ButtonDST.Size = New System.Drawing.Size(56, 23)
        Me.ButtonDST.TabIndex = 3
        Me.ButtonDST.Text = "Browse"
        Me.ButtonDST.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Extension"
        '
        'ExtBox
        '
        Me.ExtBox.Location = New System.Drawing.Point(98, 67)
        Me.ExtBox.Name = "ExtBox"
        Me.ExtBox.Size = New System.Drawing.Size(237, 20)
        Me.ExtBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.ExtBox, "Format is *.exe,*.txt,*.extension (no spaces in between).")
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(318, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"This folder only", "This folder and subfolders"})
        Me.ComboBox1.Location = New System.Drawing.Point(98, 94)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(237, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(405, 152)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ExtBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonDST)
        Me.Controls.Add(Me.DSTPathBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonSRC)
        Me.Controls.Add(Me.SourcePathBox1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Bulk Shortcut Creator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SourcePathBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSRC As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialogSRC As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents DSTPathBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonDST As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialogDST As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ExtBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox

End Class
