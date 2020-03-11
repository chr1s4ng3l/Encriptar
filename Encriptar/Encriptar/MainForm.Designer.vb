'
' Created by SharpDevelop.
' User: Christopher
' Date: 07/03/2019
' Time: 09:13 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.BEncriptar = New System.Windows.Forms.Button()
		Me.buttonDes = New System.Windows.Forms.Button()
		Me.textBoxPrincipal = New System.Windows.Forms.TextBox()
		Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.buttonS = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'BEncriptar
		'
		Me.BEncriptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.BEncriptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.BEncriptar.Location = New System.Drawing.Point(59, 317)
		Me.BEncriptar.Name = "BEncriptar"
		Me.BEncriptar.Size = New System.Drawing.Size(93, 36)
		Me.BEncriptar.TabIndex = 0
		Me.BEncriptar.Text = "Encriptar"
		Me.BEncriptar.UseVisualStyleBackColor = true
		AddHandler Me.BEncriptar.Click, AddressOf Me.EncriptarClick
		'
		'buttonDes
		'
		Me.buttonDes.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.buttonDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.buttonDes.Location = New System.Drawing.Point(262, 317)
		Me.buttonDes.Name = "buttonDes"
		Me.buttonDes.Size = New System.Drawing.Size(127, 36)
		Me.buttonDes.TabIndex = 2
		Me.buttonDes.Text = "Desencriptar"
		Me.buttonDes.UseVisualStyleBackColor = true
		AddHandler Me.buttonDes.Click, AddressOf Me.Button2Click
		'
		'textBoxPrincipal
		'
		Me.textBoxPrincipal.Font = New System.Drawing.Font("Arial Narrow", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBoxPrincipal.Location = New System.Drawing.Point(4, 12)
		Me.textBoxPrincipal.Multiline = true
		Me.textBoxPrincipal.Name = "textBoxPrincipal"
		Me.textBoxPrincipal.Size = New System.Drawing.Size(622, 299)
		Me.textBoxPrincipal.TabIndex = 7
		Me.textBoxPrincipal.WordWrap = false
		'
		'openFileDialog1
		'
		Me.openFileDialog1.DefaultExt = "txt"
		Me.openFileDialog1.FileName = "openFileDialog1"
		Me.openFileDialog1.Filter = "Archivos de texto|*.txt|Todos los archivos|*.*"
		'
		'saveFileDialog1
		'
		Me.saveFileDialog1.DefaultExt = "txt"
		Me.saveFileDialog1.Filter = "Archivo txt|*.txt"
		'
		'buttonS
		'
		Me.buttonS.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.buttonS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.buttonS.Location = New System.Drawing.Point(523, 317)
		Me.buttonS.Name = "buttonS"
		Me.buttonS.Size = New System.Drawing.Size(93, 36)
		Me.buttonS.TabIndex = 9
		Me.buttonS.Text = "Salir"
		Me.buttonS.UseVisualStyleBackColor = true
		AddHandler Me.buttonS.Click, AddressOf Me.ButtonSClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(628, 356)
		Me.Controls.Add(Me.buttonS)
		Me.Controls.Add(Me.textBoxPrincipal)
		Me.Controls.Add(Me.buttonDes)
		Me.Controls.Add(Me.BEncriptar)
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Encriptar"
		AddHandler FormClosing, AddressOf Me.MainFormFormClosing
		AddHandler Load, AddressOf Me.MainFormLoad
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private buttonS As System.Windows.Forms.Button
	Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
	Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
	Public buttonDes As System.Windows.Forms.Button
	Private textBoxPrincipal As System.Windows.Forms.TextBox
	Private BEncriptar As System.Windows.Forms.Button
End Class
