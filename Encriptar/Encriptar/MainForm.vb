'
' Created by SharpDevelop.
' User: Christopher
' Date: 07/03/2019
' Time: 09:13 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Dim str,llave As String
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub EncriptarClick(sender As Object, e As EventArgs)
		Try
			
			Dim ventana As Confirma
			Dim resultado As DialogResult
			ventana = New Confirma()
			ventana.buttonOK.Visible = False
			If ventana.ShowDialog = DialogResult.OK	then
				
				resultado = saveFileDialog1.ShowDialog
				
				
				If resultado =DialogResult.OK Then
					Dim ruta As String
					
					str = textBoxPrincipal.Text
					llave = ventana.textBoxClave.text
					str = Encriptar(str, llave, False) 'False encriptar
					
					ruta = saveFileDialog1.FileName
					System.IO.File.WriteAllText(ruta,str)
					textBoxPrincipal.Clear
				End if
			End If
			
		Catch ex As Exception
			MsgBox(ex.Message)
		End try
	End Sub
	
	Public Function Encriptar(Texto As String, Llave As String, Mode As Boolean ) As String 'Si Mode es falso, encripta, si es verdadero, desencripta
		Dim p As int32, j As int32, NuChr As int32
		
		Dim letraTexto As String, letraLlave As String, Salida As String = ""
		
		
		For j = 0 To Len(Texto) - 1
			letraTexto = Texto.Chars(j)
			If p = Len(Llave) - 1 Then 
				p = 0
			End If
			letraLlave = Llave.Chars(p)
			p += 1
			If Mode = False Then 'si es falso, encripta, si es verdadero, desencripta
				NuChr = Asc(letraTexto) + Asc(letraLlave)
				If NuChr > 255 Then
					NuChr = NuChr - 255
				End If
			Else
				NuChr = Asc(letraTexto) - Asc(letraLlave)
				If NuChr < 0 Then
					NuChr = NuChr + 255
				End If
			End If
			Salida &= Chr(NuChr)
		Next
		
		Return Salida
	End Function
	
	
	Sub Button2Click(sender As Object, e As EventArgs)
		Try
			Dim ventana As Confirma
			
			Dim Resultado As DialogResult
			
			Resultado = openFileDialog1.ShowDialog
			If Resultado = DialogResult.OK Then
				
				ventana = New Confirma()
				ventana.textBoxConfirmar.Visible = False
				ventana.buttonGuardarContrasena.Visible = False
				
				
				If ventana.ShowDialog = DialogResult.OK Then 
					Dim ruta As String
					
					ruta = openFileDialog1.FileName
					str = System.IO.File.ReadAllText(ruta)
					llave = ventana.textBoxClave.text
					
					str = Encriptar(str, llave, True) 'true Desencriptar
					
					textBoxPrincipal.text = str
					
				End If
			End if
		Catch ex As Exception
			MsgBox(ex.Message)
		End try
	End Sub
	
	
	
	
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub MainFormFormClosing(sender As Object, e As FormClosingEventArgs)
		Dim respuesta As MsgBoxResult
		
		respuesta = MsgBox("Desea cerrar la ventana", MsgBoxStyle.Question or MsgBoxStyle.YesNo, "Confirmar") 
		
		If respuesta = DialogResult.No Then
			
			e.Cancel=true	
		End If
	End Sub
	
	Sub ButtonSClick(sender As Object, e As EventArgs)
		Me.Close		
	End Sub
	
	Sub ButtonGClick(sender As Object, e As EventArgs)
		
		
	End Sub
End Class
