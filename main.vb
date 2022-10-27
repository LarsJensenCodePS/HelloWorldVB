Module HelloWorld
  'Handles greeting an old pal'  
  Public Class Greeter
    Dim _recipient as string = "who"
    Dim _shouldGreet as boolean = true

    'Change the recipient of the greeting'
    Public Sub ChangeRecipient(Byval recipient As String)
      Me._recipient = recipient
      Me._shouldGreet = true
    End Sub
    
    'Greets the name provided to the greeter class'
    Public Sub Greet()
      If _shouldGreet then
        System.Console.WriteLine($"Hello {Me._recipient}!")
      End If
      'Greeting more than once is just sorta wierd'
      _shouldGreet = false
    End Sub
  End Class
  
	Sub Main()
    Dim greeter As Greeter = new Greeter
    'Greet the world'
    greeter.ChangeRecipient("world")
    greeter.Greet
    greeter.Greet
    'Greet Bob'
    greeter.ChangeRecipient("Bob")
    greeter.Greet
	End Sub
End Module