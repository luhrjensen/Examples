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
        Hz1Percent.Text = kClmtr.connect()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' Make sure it is connected
        If (kClmtr.isPortOpen) Then
            ' Start the KClmtr measuring
            Hz2Percent.Text = kClmtr.startFlicker()
        End If
    End Sub
    Private Sub printFlicker(ByVal sender As KClmtrWrap, ByVal e As KClmtrWrapper.FlickerEventArgs) Handles kClmtr.flickerEvent
        If Db1.InvokeRequired Then
            ' Form objects can't be updated from a different thread
            ' This calls the function from the form's thread
            Try

                Dim d As New System.EventHandler(AddressOf printFlicker)
                Dim objects() As Object = {sender, e}
                Invoke(d, objects)
            Catch ex As Exception
                ' In case you closed the form before it could stop the measuring
            End Try
        Else
            Dim flicker As wFlicker
            ' flicker = DirectCast(e, KClmtrWrapper.FlickerEventArgs).f
            flicker = e.Flicker
            ' If its ready to display it, we can then(but you can display it even if its not ready.
            ' If the code is 0 then there was no error
            If KleinsErrorCodes.shouldStopMeasuring(flicker.ErrorCode) Then
                kClmtr.stopFlicker()
                MessageBox.Show(KleinsErrorCodes.errorCodesToString(flicker.ErrorCode))
            Else
                ' Displaying the highest peak
                ' The Percent
                Hz1Percent.Text = flicker.PeakFrequencyPercent.v(0, 0).ToString + " Hz"
                percent1.Text = (flicker.PeakFrequencyPercent.v(0, 1)).ToString("F2") + " %"
                ' The Db
                Hz1Db.Text = flicker.PeakFrequencyDB.v(0, 0).ToString + " Hz"
                Db1.Text = flicker.PeakFrequencyDB.v(0, 1).ToString("F2") + " Db"

                ' Displaying the second highest peak
                ' The Percent
                Hz2Percent.Text = flicker.PeakFrequencyPercent.v(1, 0).ToString + " Hz"
                percent2.Text = flicker.PeakFrequencyPercent.v(1, 1).ToString("F2") + " %"
                ' The Db
                Hz2Db.Text = flicker.PeakFrequencyDB.v(1, 0).ToString + " Hz"
                Db2.Text = flicker.PeakFrequencyDB.v(1, 1).ToString("F2") + " Db"

                ' Displaying the third highest peak
                ' The Percent
                Hz3Percent.Text = flicker.PeakFrequencyPercent.v(2, 0).ToString + " Hz"
                percent3.Text = flicker.PeakFrequencyPercent.v(2, 1).ToString("F2") + " %"
                ' The Db
                Hz3Db.Text = flicker.PeakFrequencyDB.v(2, 0).ToString + " Hz"
                Db3.Text = flicker.PeakFrequencyDB.v(2, 1).ToString("F2") + " Db"
            End If
        End If
    End Sub

    Private Sub Hold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hold.Click
        ' Stop measuring
        kClmtr.stopFlicker()
    End Sub
End Class
