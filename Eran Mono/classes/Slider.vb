Module Slider
    Private WithEvents SlideTimer As New Timer
    Friend SlideInterval = 1
    Private isSlided As Boolean = False
    Private isAlone As Boolean
    Friend Function Slide(ByVal Control As Control)

        Try
            isAlone = False
            If isSlided = False Then
                slideIn_Control(Control)
                isSlided = True

            Else

                slideOut_Control(Control)

            End If

        Catch ex As Exception
            slideIn_Control(Control)
        End Try


    End Function
    Friend Function slideOut_Control(ByVal Control As Control)

        SlideTimer.Interval = SlideInterval
        SlideIndex = 1
        slideControl2 = Control
        slideControl2.Dock = DockStyle.None
        slideControl2.BringToFront()
        SlideTimer.Enabled = True
    End Function

    Private Function slideIn_Control(ByVal Control As Control)

        SlideTimer.Interval = SlideInterval
        SlideIndex = 0
        slideControl1 = Control
        slideControl2 = Control
        slideControl1.Dock = DockStyle.None
        main_frm.SplitContainer1.Panel2.Controls.Add(Control)
        Control.Show()
        slideControl1.Location = New Point(main_frm.SplitContainer1.Panel2.Width, 0)
        Control.BringToFront()
        SlideTimer.Enabled = True
    End Function
    Private slideControl1 As Control 'Aktuell
    Private slideControl2 As Control 'Neu
    Private SlideIndex As Integer

    Private Sub Slide_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlideTimer.Tick
        Select Case SlideIndex
            Case 0

                If slideControl1.Location.X < 0 Then
                    SlideTimer.Enabled = False
                    slideControl1.Location = New Point(0, 0)
                    slideControl1.Dock = DockStyle.Fill
                Else
                    Select Case slideControl1.Location.X

                    End Select
                    slideControl1.Size = New Size(main_frm.main_panel.Width, main_frm.main_panel.Height)
                    slideControl1.Location = New Point(slideControl1.Location.X - 40, slideControl1.Location.Y)
                End If
                isAlone = True
            Case 1

                slideControl1.Dock = DockStyle.None

                If slideControl1.Location.X < -slideControl1.Size.Width Then

                    SlideTimer.Enabled = False
                    If isAlone = False Then
                        If isSlided = True Then
                            slideIn_Control(slideControl2)
                        End If
                    End If
                    

                Else

                Select Case slideControl1.Location.X

                End Select

                slideControl1.Size = New Size(main_frm.main_panel.Width, main_frm.main_panel.Height)
                    slideControl1.Location = New Point(slideControl1.Location.X - 40, slideControl1.Location.Y)
                End If
        End Select

    End Sub
End Module
