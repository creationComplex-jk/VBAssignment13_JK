<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnAddPassenger = New System.Windows.Forms.Button()
        Me.btnUpdatePassenger = New System.Windows.Forms.Button()
        Me.btnShowPassenger = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddPassenger
        '
        Me.btnAddPassenger.BackColor = System.Drawing.Color.Gray
        Me.btnAddPassenger.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAddPassenger.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAddPassenger.FlatAppearance.BorderSize = 4
        Me.btnAddPassenger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPassenger.Font = New System.Drawing.Font("Comic Sans MS", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddPassenger.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddPassenger.Location = New System.Drawing.Point(45, 49)
        Me.btnAddPassenger.Name = "btnAddPassenger"
        Me.btnAddPassenger.Size = New System.Drawing.Size(138, 80)
        Me.btnAddPassenger.TabIndex = 0
        Me.btnAddPassenger.Text = "Add Passenger"
        Me.btnAddPassenger.UseVisualStyleBackColor = False
        '
        'btnUpdatePassenger
        '
        Me.btnUpdatePassenger.BackColor = System.Drawing.Color.Gray
        Me.btnUpdatePassenger.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnUpdatePassenger.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnUpdatePassenger.FlatAppearance.BorderSize = 4
        Me.btnUpdatePassenger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdatePassenger.Font = New System.Drawing.Font("Comic Sans MS", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdatePassenger.Location = New System.Drawing.Point(45, 307)
        Me.btnUpdatePassenger.Name = "btnUpdatePassenger"
        Me.btnUpdatePassenger.Size = New System.Drawing.Size(138, 80)
        Me.btnUpdatePassenger.TabIndex = 1
        Me.btnUpdatePassenger.Text = "Update Passenger"
        Me.btnUpdatePassenger.UseVisualStyleBackColor = False
        '
        'btnShowPassenger
        '
        Me.btnShowPassenger.BackColor = System.Drawing.Color.Gray
        Me.btnShowPassenger.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnShowPassenger.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnShowPassenger.FlatAppearance.BorderSize = 4
        Me.btnShowPassenger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowPassenger.Font = New System.Drawing.Font("Comic Sans MS", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnShowPassenger.Location = New System.Drawing.Point(45, 175)
        Me.btnShowPassenger.Name = "btnShowPassenger"
        Me.btnShowPassenger.Size = New System.Drawing.Size(138, 80)
        Me.btnShowPassenger.TabIndex = 2
        Me.btnShowPassenger.Text = "Show Passenger"
        Me.btnShowPassenger.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(233, 449)
        Me.Controls.Add(Me.btnShowPassenger)
        Me.Controls.Add(Me.btnUpdatePassenger)
        Me.Controls.Add(Me.btnAddPassenger)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 13.0!)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddPassenger As Button
    Friend WithEvents btnUpdatePassenger As Button
    Friend WithEvents btnShowPassenger As Button
End Class
