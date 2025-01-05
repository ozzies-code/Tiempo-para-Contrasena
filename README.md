# Tiempo para Contrasena

 Este proyecto hace uso del del objeto Timer para 
 establecer un limite de 15 segundos al usuario 
 de introducir la contrasena correcta y validar 
 su identidad.

# Descripcion

 Este proyecto consiste en una aplicacion que emplea
 un objeto timer para establecer un limite de 15 
 segundos para que el usuario introduzca la contrasena
 que tiene asignada correctamente. Si el tiempo se agota
 o si el usuario no introduce la contrasena correcta, 
 se cierra el programa.
 
 # Actualizacion: 05/01/2025
 # Hora: 16:16

Detalles técnicos del proyecto:
Idioma: Visual Basic.NET
Versión del framework: 4.7.2

# Password Timer

This project makes use of the Timer object to
set a 15 second limit for the user to enter the correct password and
validate their identity.

# Description

This project consists of an application that uses
a timer object to set a 15 second limit for the user to enter the password
assigned to them correctly. If the time runs out
or if the user does not enter the correct password,
the program closes.

# Update: 01/05/2025
# Time: 16:16

Technical details of the project:
Language: Visual Basic.NET
Framework version: 4.7.2

![imagen](https://github.com/user-attachments/assets/fd43fb95-2957-4111-981f-a324ec0f2edf)

Code of the Project:

Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        MsgBox("Lo siento, se acabó su tiempo.")
        End
    End Sub

    Private Sub btnContra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContra.Click
        If txtContra.Text = "secreta" Then
            Timer1.Enabled = False
            MsgBox("¡Bienvenido al sistema!")
            End
        Else
            MsgBox("Lo siento, amigo. No sé quién es usted.")
        End If
    End Sub
End Class
