@echo off
SET linea="Exec sp_CNomina_1_parte2 %1,%2,%3,%4,%5,%6"
sqlcmd -S 201.149.34.185,15002 -U IPSNet -P IPSNet2 -Q %linea%
rem echo %1
rem echo %2
rem echo %3
rem echo %4
rem echo %5
rem echo %6
rem echo %linea%