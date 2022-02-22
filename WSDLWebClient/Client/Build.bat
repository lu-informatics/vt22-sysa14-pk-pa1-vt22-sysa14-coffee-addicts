wsdl.exe /out:ServoService.cs http://localhost/ProgrammingAssignment2/Servo.asmx?WSDL

csc.exe /target:library /out:ServoService.dll ServoService.cs

csc.exe /reference:ServoService.dll /out:Test.exe Program.cs

Test.exe