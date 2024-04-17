<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonCustomerManager = New System.Windows.Forms.Button()
        Me.ButtonLogOut = New System.Windows.Forms.Button()
        Me.ButtonCarManager = New System.Windows.Forms.Button()
        Me.ButtonInvoiceManager = New System.Windows.Forms.Button()
        Me.ButtonUserManager = New System.Windows.Forms.Button()
        Me.LabelUserName = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelUserName, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 600)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonCustomerManager, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonLogOut, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonCarManager, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonInvoiceManager, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonUserManager, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(200, 150)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(400, 300)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'ButtonCustomerManager
        '
        Me.ButtonCustomerManager.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ButtonCustomerManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonCustomerManager.FlatAppearance.BorderSize = 0
        Me.ButtonCustomerManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCustomerManager.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButtonCustomerManager.Location = New System.Drawing.Point(3, 103)
        Me.ButtonCustomerManager.Name = "ButtonCustomerManager"
        Me.ButtonCustomerManager.Size = New System.Drawing.Size(194, 94)
        Me.ButtonCustomerManager.TabIndex = 1
        Me.ButtonCustomerManager.Text = "Müşteri Yönetimi"
        Me.ButtonCustomerManager.UseVisualStyleBackColor = False
        '
        'ButtonLogOut
        '
        Me.ButtonLogOut.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ButtonLogOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonLogOut.FlatAppearance.BorderSize = 0
        Me.ButtonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButtonLogOut.Location = New System.Drawing.Point(203, 203)
        Me.ButtonLogOut.Name = "ButtonLogOut"
        Me.ButtonLogOut.Size = New System.Drawing.Size(194, 94)
        Me.ButtonLogOut.TabIndex = 1
        Me.ButtonLogOut.Text = "Çıkış Yap"
        Me.ButtonLogOut.UseVisualStyleBackColor = False
        '
        'ButtonCarManager
        '
        Me.ButtonCarManager.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ButtonCarManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonCarManager.FlatAppearance.BorderSize = 0
        Me.ButtonCarManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCarManager.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButtonCarManager.Location = New System.Drawing.Point(203, 103)
        Me.ButtonCarManager.Name = "ButtonCarManager"
        Me.ButtonCarManager.Size = New System.Drawing.Size(194, 94)
        Me.ButtonCarManager.TabIndex = 1
        Me.ButtonCarManager.Text = "Araç Yönetimi"
        Me.ButtonCarManager.UseVisualStyleBackColor = False
        '
        'ButtonInvoiceManager
        '
        Me.ButtonInvoiceManager.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ButtonInvoiceManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonInvoiceManager.FlatAppearance.BorderSize = 0
        Me.ButtonInvoiceManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInvoiceManager.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButtonInvoiceManager.Location = New System.Drawing.Point(3, 203)
        Me.ButtonInvoiceManager.Name = "ButtonInvoiceManager"
        Me.ButtonInvoiceManager.Size = New System.Drawing.Size(194, 94)
        Me.ButtonInvoiceManager.TabIndex = 1
        Me.ButtonInvoiceManager.Text = "Sözleşme Yönetimi"
        Me.ButtonInvoiceManager.UseVisualStyleBackColor = False
        '
        'ButtonUserManager
        '
        Me.ButtonUserManager.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel2.SetColumnSpan(Me.ButtonUserManager, 2)
        Me.ButtonUserManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonUserManager.FlatAppearance.BorderSize = 0
        Me.ButtonUserManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUserManager.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButtonUserManager.Location = New System.Drawing.Point(3, 3)
        Me.ButtonUserManager.Name = "ButtonUserManager"
        Me.ButtonUserManager.Size = New System.Drawing.Size(394, 94)
        Me.ButtonUserManager.TabIndex = 1
        Me.ButtonUserManager.Text = "Kullanıcı Yönetimi"
        Me.ButtonUserManager.UseVisualStyleBackColor = False
        '
        'LabelUserName
        '
        Me.LabelUserName.AutoSize = True
        Me.LabelUserName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelUserName.Location = New System.Drawing.Point(3, 0)
        Me.LabelUserName.Name = "LabelUserName"
        Me.LabelUserName.Size = New System.Drawing.Size(194, 150)
        Me.LabelUserName.TabIndex = 1
        Me.LabelUserName.Text = "KullanıcıAdı"
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DashboardForm"
        Me.ShowInTaskbar = False
        Me.Text = "DashboardForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ButtonCustomerManager As Button
    Friend WithEvents ButtonCarManager As Button
    Friend WithEvents ButtonLogOut As Button
    Friend WithEvents ButtonInvoiceManager As Button
    Friend WithEvents ButtonUserManager As Button
    Friend WithEvents LabelUserName As Label
End Class
