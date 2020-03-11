'
' Created by SharpDevelop.
' User: Christopher
' Date: 07/03/2019
' Time: 09:52 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class Confirma
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub ConfirmaLoad(sender As Object, e As EventArgs)
		
	End Sub
	
	
	Public sub confirmar(clave As String, validar As String)
		
		If textBoxClave.Text.Trim.Length > 2 Then
			clave = textBoxClave.Text
			validar = textBoxConfirmar.Text
			If clave = validar Then
				
				
				MsgBox("Se guardo correctamente")
				
				Me.DialogResult = DialogResult.OK
			Else 
				MsgBox("Las contrasenas no coiciden")
			End If		
		Else
			MsgBox("La clave debe tener al menos 3 digitos")
		End If
	end sub
	
	Sub ButtonOKClick(sender As Object, e As EventArgs)
		Me.DialogResult = DialogResult.OK
	End Sub
	
	Sub ButtonGuardarContrasenaClick(sender As Object, e As EventArgs)
		confirmar(textBoxClave.Text,textBoxConfirmar.text)
		
	End Sub
	
	Sub ButtonLimpiarClick(sender As Object, e As EventArgs)
		
	End Sub
End Class
