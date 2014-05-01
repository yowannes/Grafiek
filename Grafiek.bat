@set APP=Grafiek
@echo Compile %APP%
csc /nologo /out:%APP%.exe /nologo /r:./ZedGraph.dll %APP%.cs
%APP%.exe grafiek.txt 
pause
