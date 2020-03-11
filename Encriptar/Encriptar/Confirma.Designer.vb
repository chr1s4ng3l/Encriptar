'
' Created by SharpDevelop.
' User: Christopher
' Date: 07/03/2019
' Time: 09:52 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class Confirma
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
		Me.textBoxConfirmar = New System.Windows.Forms.TextBox()
		Me.textBoxClave = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.buttonOK = New System.Windows.Forms.Button()
		Me.buttonLimpiar = New System.Windows.Forms.Button()
		Me.buttonGuardarContrasena = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'textBoxConfirmar
		'
		Me.textBoxConfirmar.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.textBoxConfirmar.BackColor = System.Drawing.SystemColors.InfoText
		Me.textBoxConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBoxConfirmar.ForeColor = System.Drawing.Color.Lime
		Me.textBoxConfirmar.Location = New System.Drawing.Point(114, 56)
		Me.textBoxConfirmar.Name = "textBoxConfirmar"
		Me.textBoxConfirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9632)
		Me.textBoxConfirmar.Size = New System.Drawing.Size(141, 22)
		Me.textBoxConfirmar.TabIndex = 13
		'
		'textBoxClave
		'
		Me.textBoxClave.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.textBoxClave.BackColor = System.Drawing.SystemColors.MenuText
		Me.textBoxClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBoxClave.ForeColor = System.Drawing.Color.Lime
		Me.textBoxClave.Location = New System.Drawing.Point(114, 28)
		Me.textBoxClave.Name = "textBoxClave"
		Me.textBoxClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9632)
		Me.textBoxClave.Size = New System.Drawing.Size(141, 22)
		Me.textBoxClave.TabIndex = 12
		'
		'label1
		'
		Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(47, 27)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(61, 23)
		Me.label1.TabIndex = 10
		Me.label1.Text = "Clave:"
		'
		'buttonOK
		'
		Me.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.buttonOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.buttonOK.Location = New System.Drawing.Point(222, 114)
		Me.buttonOK.Name = "buttonOK"
		Me.buttonOK.Size = New System.Drawing.Size(75, 33)
		Me.buttonOK.TabIndex = 8
		Me.buttonOK.Text = "OK"
		Me.buttonOK.UseVisualStyleBackColor = true
		AddHandler Me.buttonOK.Click, AddressOf Me.ButtonOKClick
		'
		'buttonLimpiar
		'
		Me.buttonLimpiar.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.buttonLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.buttonLimpiar.Location = New System.Drawing.Point(35, 114)
		Me.buttonLimpiar.Name = "buttonLimpiar"
		Me.buttonLimpiar.Size = New System.Drawing.Size(92, 34)
		Me.buttonLimpiar.TabIndex = 15
		Me.buttonLimpiar.Text = "Cancelar"
		Me.buttonLimpiar.UseVisualStyleBackColor = true
		AddHandler Me.buttonLimpiar.Click, AddressOf Me.ButtonLimpiarClick
		'
		'buttonGuardarContrasena
		'
		Me.buttonGuardarContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.buttonGuardarContrasena.Location = New System.Drawing.Point(205, 113)
		Me.buttonGuardarContrasena.Name = "buttonGuardarContrasena"
		Me.buttonGuardarContrasena.Size = New System.Drawing.Size(92, 34)
		Me.buttonGuardarContrasena.TabIndex = 14
		Me.buttonGuardarContrasena.Text = "Guardar"
		Me.buttonGuardarContrasena.UseVisualStyleBackColor = true
		AddHandler Me.buttonGuardarContrasena.Click, AddressOf Me.ButtonGuardarContrasenaClick
		'
		'Confirma
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(309, 177)
		Me.Controls.Add(Me.buttonLimpiar)
		Me.Controls.Add(Me.buttonGuardarContrasena)
		Me.Controls.Add(Me.textBoxConfirmar)
		Me.Controls.Add(Me.textBoxClave)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.buttonOK)
		Me.Name = "Confirma"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Confirma"
		AddHandler Load, AddressOf Me.ConfirmaLoad
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Public buttonGuardarContrasena As System.Windows.Forms.Button
	Public buttonLimpiar As System.Windows.Forms.Button
	Public textBoxClave As System.Windows.Forms.TextBox
	Public textBoxConfirmar As System.Windows.Forms.TextBox
	Public buttonOK As System.Windows.Forms.Button
	Private label1 As System.Windows.Forms.Label
End Class
