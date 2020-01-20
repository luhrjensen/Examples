Imports KClmtrBase
Imports KClmtrBase.KClmtrWrapper
Public Class Form1

    Private kClmtr As New KClmtrWrap()
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
        If kClmtr.isPortOpen Then
            ' Grab the xyL and the error if there was one
            Dim xyL As wMeasurement = kClmtr.getNextMeasurement(1)
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
        Else
            MsgBox("Port is not open")
        End If
    End Sub
End Class
