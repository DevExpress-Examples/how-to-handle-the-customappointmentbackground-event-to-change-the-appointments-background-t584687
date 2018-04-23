﻿#Region "#resource"
Imports DevExpress.Mvvm.POCO

Namespace CustomAppointmentBackground
    Public Class Doctor
        Public Shared Function Create() As Doctor
            Return ViewModelSource.Create(Function() New Doctor())
        End Function
        Public Shared Function Create(ByVal Id As Integer, ByVal Name As String) As Doctor

            Dim doctor_Renamed As Doctor = CustomAppointmentBackground.Doctor.Create()
            doctor_Renamed.Id = Id
            doctor_Renamed.Name = Name
            Return doctor_Renamed
        End Function

        Protected Sub New()
        End Sub

        Public Overridable Property Id() As Integer
        Public Overridable Property Name() As String
    End Class
End Namespace
#End Region ' #resource
