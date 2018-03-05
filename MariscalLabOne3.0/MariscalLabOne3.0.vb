Option Strict On

''' <summary>
''' Author: Hector Mariscal
''' Project Name: Lab One - Average Units Shipped
''' Date: 07-feb-2018
''' Description: This application takes and validates units shipped for each day 
''' of the week, and then at the end it caluclates the average units shipped.
''' </summary>

Public Class frmMariscalLabOne
    'Form level declarations
    Const minUnitSize As Integer = 0    'canstant fot the minimum size of units
    Const maxUnitSize As Integer = 1000 'constant for the maximum size of units
    Const dayInWeek As Integer = 7      ' constant for the number of days in a week

    Dim calculatedAverage As Double = 0.0   'variable that holds the average that is calculated after the 7 days have been inputted
    Dim unitSum As Double = 0.0 'variable that holds the sum of all of the units inputted
    Dim userInput As String = String.Empty  'variable for the unvalidated user input
    Dim validatedUserInput As Integer = 0   'variable for the validated user input


    Dim counter As Integer = 0  'variable for the counter used in the if statements
    Dim output As String = String.Empty 'variable that stores what will be outputted


    Private unitArray(7) As Integer 'the array that holds all of the units for each day of the week
    Private Sub frmMariscalLabOne_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    ''' <summary>
    '''/This Is the event wiring for btnEnter it Is the primary function
    '''of this form. The user input Is validated And then used in storing the input into an array and then calculate the average at the end of the 7 days.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        userInput = tbUnitInput.Text
        If (Integer.TryParse(userInput, validatedUserInput) AndAlso 'validates the user input and makes sure its an integer
        validatedUserInput >= minUnitSize And validatedUserInput <= maxUnitSize) Then   'validates user input and makes sure the input is in range

            counter = counter + 1                   'Counter set up to cylce through the array
            unitArray(counter) = validatedUserInput
            tbUnitInput.Text = ""
            tbUnitInput.Focus()
            output += unitArray(counter).ToString & " " & vbCrLf
            lbDays.Text = "Day " & counter + 1 & ":"

            If counter = dayInWeek Then     'When the counter is at 7 (for the days in the week) disables the buttons and text box and then goes to the for loop
                tbUnitInput.Text = ""
                tbUnitInput.Enabled = False
                btnEnter.Enabled = False

                For index As Integer = 0 To unitArray.Length - 1    'for loop to calculate the average of all of the numbers in the array
                    unitSum = (unitSum + unitArray(index))
                    calculatedAverage = Math.Round(unitSum / dayInWeek)

                Next

                If lbDays.Text = "Day " & 8 & ":" Then  'If statement that handles the days label and after the 7th day hides the label and disbles some of the controls as well as outputs the calculated average
                    lbDays.Visible = False
                    'MsgBox("The array is full", MsgBoxStyle.Information)
                    lbAverageDisplay.Text = "Average per day: " & calculatedAverage.ToString
                    'tbUnitInput.Enabled = False

                End If

            End If

        Else
            output += "The input must be a whole number between " & minUnitSize.ToString() & " and " & maxUnitSize.ToString() & " Please enter a whole number." & vbCrLf    'Tells the user of a non valid input and prompts them to enter a whole number
            tbUnitInput.Focus()
            tbUnitInput.Text = ""
        End If
        tbUnitsOutput.Text = output

    End Sub
    ''' <summary>
    ''' This Is an event wiring for btnReset
    '''It resets everything on the form back to the default state.
    '''</summary>
    '''<param name="sender"></param>
    '''<param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        tbUnitsOutput.ResetText()
        lbAverageDisplay.ResetText()
        lbDays.Text = "Day 1:"
        tbUnitInput.Text = ""
        output = ""
        tbUnitInput.Enabled = True
        btnEnter.Enabled = True
        tbUnitInput.Focus()
        lbDays.Visible = True
        Array.Clear(unitArray, 0, unitArray.Length)
        counter = 0
        calculatedAverage = 0
        unitSum = 0
    End Sub
    ''' <summary>
    ''' This Is an event wiring for btnExit
    ''' It closes the form.
    '''</summary>
    '''<param name="sender"></param>
    '''<param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
