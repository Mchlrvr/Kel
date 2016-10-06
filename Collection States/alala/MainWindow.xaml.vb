Class MainWindow 

    Dim states As Collection = New Collection()

    Sub Output(ByVal Value As String)
        textOutput1.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        textOutput1.Text = ""
    End Sub


    Sub OutputStates()
        For Each state As String In states
            Output(state)

        Next
    End Sub

    Sub btnAdd_click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnAdd.Click
        Dim inputState As String = textInput1.Text

        If inputState.Contains(",") Then
            Dim stateVal() As String = Split(inputState, ",")
            states.Add(Trim(stateVal(0).ToString), Trim(stateVal(1).ToString))
            Output("You added state: " + stateVal(0) + ", " + stateVal(1))
        End If



    End Sub

    Sub btnShow_click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnShow.Click
        textOutput1.Text = ""
        OutputStates()

    End Sub


    Sub btnGet_click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnGet.Click
        Dim stateID As String = textInput1.Text
        If states.Contains(stateID) Then
            Output("You requested: " + states.Item(stateID))
        Else
            Output("Not Found")
        End If




    End Sub

    Sub btnRemove_click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnRemove.Click
        Dim stateID As String = textInput1.Text
        If states.Contains(stateID) Then
            states.Remove(stateID)
            textOutput1.Text = ""
            Output(stateID + "removed, here's what is left")
            OutputStates()
        Else
            Output("Not Found!")
        End If
    End Sub

    Sub btnClr_click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnClear.Click
        states.Clear()
        textOutput1.Text = ""
    End Sub
End Class

