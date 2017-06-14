Imports System.Math
Public Class d_calc
    Dim u, v, s1, s2, g, a, b, Al, Be, ux, c, d, diff, val, root, t1, t2, Time, i, rootve, rooti, alpha, beta As Double


    Private Sub clr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v_ver.Click


        If w.Text = Nothing Or y.Text = Nothing Then

            MessageBox.Show("Dip Lengths cannot be Zero/Negative/ nor should the field be left BLANK!", "ERROR: Positivity", MessageBoxButton.OK, MessageBoxImage.Warning)


        Else


            Try
                'Get the number from the text box
                u = CType(q.Text, Double)
                s1 = CType(w.Text, Double)
                s2 = CType(y.Text, Double)
                a = CType(r.Text, Double)
                b = CType(t.Text, Double)
            Catch
            End Try





            If w.Text <= 0 Or y.Text <= 0 Then
                MessageBox.Show("Dip Lengths cannot be Zero/Negative/ nor should the field be left BLANK!", "ERROR: Positivity", MessageBoxButton.OK, MessageBoxImage.Warning)

            End If


            'Multiply by PI/180 to convert degrees to radians, and then to sin() values

            alpha = (a * PI) / 180
            beta = (b * PI) / 180

            Al = Sin(alpha)
            Be = Sin(beta)



            'CALCULATION!..........................................

            g = 9.80665

            'Mid
            c = Al * s1
            d = Be * s2

            diff = c - d

            val = 2 * g * diff

            ux = u * u

            root = ux + val

            'Final Answer
            v = root ^ (1 / 2)

            '_________________________________________________________________________
            'To calculate the time: 
            't1 = downward speed 
            't2 = upward speed
            'T = Total time [Dip speed]
            '_________________________________________________________________________


            Dim tg As Double
            Dim th As Double

            tg = g * Al
            th = g * Be

            Dim iu As Double
            Dim iv As Double
            Dim sep As Double
            Dim ix As Double

            sep = 2 * g * c
            ix = ux + sep




            Dim i As Double

            If root < 0 Then
                rootve = root * -1
                rooti = rootve ^ (1 / 2)

                'Time.........................
                i = ix ^ (1 / 2)
                iu = i - u
                iv = i - rooti

                t1 = iu / tg
                t2 = iv / th


                Time = t1 + t2

                'Answer..............

                lbl.Visibility = Windows.Visibility.Hidden

                a1.Text = "(ReD) " & rooti & "i m/sec"
                a2.Text = ("t1 = " & t1 & " sec" & vbNewLine & "t2 = " & t2 & " sec" & vbNewLine & "Alpha (Al) = " & Al & vbNewLine & "Beta (Be) = " & Be & vbNewLine & "Total Time Taken = " & Time & " sec" & vbNewLine & "HSP (i) = " & i & " m/sec" & vbNewLine & "acc.(s1) = " & tg & " m/s^2" & vbNewLine & "acc.(s2) = " & th & " m/s^2")

            Else


                'Final speed (v)
                root = ux + val
                v = root ^ (1 / 2)
                '...................

                i = ix ^ (1 / 2)

                iu = i - u
                iv = i - v

                t1 = iu / tg
                t2 = iv / th

                Time = t1 + t2

                'Answer....................
                lbl.Visibility = Windows.Visibility.Hidden
                a1.Text = "v = " & v & " m/sec"
                a2.Text = ("t1 = " & t1 & " sec" & vbNewLine & "t2 = " & t2 & " sec" & vbNewLine & "Alpha (Al) = " & Al & vbNewLine & "Beta (Be) = " & Be & vbNewLine & "Total Time Taken = " & Time & " sec" & vbNewLine & "HSP (i) = " & i & " m/sec" & vbNewLine & "acc.(s1) = " & tg & " m/s^2" & vbNewLine & "acc.(s2) = " & th & " m/s^2")
            End If

            lbl.Visibility = Windows.Visibility.Hidden



            '.
            '.
            '.
            '.
            '.
            '.
            '.

        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clr.Click
        a1.Text = ""
        a2.Text = ""
        lbl.Visibility = Windows.Visibility.Visible
       
    End Sub
  
End Class
