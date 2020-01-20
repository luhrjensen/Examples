Imports KClmtrBase
Imports KClmtrBase.KClmtrWrapper
Public Class Form1
    Private WithEvents kClmtr As New KClmtrWrap()

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Need to set the port number before we can open it
        kClmtr.port = PortNumber.Value
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Connect
        kClmtr.connect()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' Make sure it is connected
        If (kClmtr.isPortOpen) Then
            ' Start the KClmtr measuring
            kClmtr.startMeasuring()
        End If
    End Sub
    Private Sub printMeasurement(ByVal sender As KClmtrWrapper.KClmtrWrap, ByVal e As KClmtrWrapper.MeasureEventArgs) Handles kClmtr.measureEvent
        If TextX.InvokeRequired Then
            ' Form objects can't be updated from a different thread
            ' This calls the function from the form's thread
            Try
                Dim d As New EventHandler(AddressOf printMeasurement)
                Dim objects() As Object = {sender, e}
                Invoke(d, objects)
            Catch ex As Exception
                ' In case you closed the form before it could stop the measuring
            End Try
        Else
            ' If its ready to display it, we can then(but you can display it even if its not ready.
            ' If the code is 0 then there was no error
            ' Grab the xyL and the error if there was one
            Dim xyL As wMeasurement = e.Measurement
            ' If the code is 0 then there was no error
            If KleinsErrorCodes.shouldStopMeasuring(xyL.errorcode) Then
                kClmtr.stopMeasuring()
                MessageBox.Show(KleinsErrorCodes.errorCodesToString(xyL.errorcode))
            Else
                ' Filling in the xyL text boxes with the numbers
                TextX.Text = xyL.CIE1931_x
                TextY.Text = xyL.CIE1931_y
                TextL.Text = xyL.BigY
            End If
        End If
    End Sub

    Private Sub Hold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hold.Click
        ' Stop measuring
        kClmtr.stopMeasuring()
    End Sub
End Class
