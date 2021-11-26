<!DOCTYPE html>
<html>
<body>


<%
Response.Write(Request.ServerVariables("REQUEST_METHOD"))
Response.Write(Request.Form)


dim userName
dim userPassword
userName=Request.QueryString("userName")
userPassword=Request.QueryString("userPassword")
If userName<>"" Then
    Response.Write("Hello " & userName & "!<br>")
    Response.Write("How are you today?")
End If

If userPassword<>"" Then
    Response.Write("Your password is  " & userPassword & "!<br>")
    
End If

%>

</body>
</html>