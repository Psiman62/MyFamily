@echo off

::
:: update mfcg4 if required
::

dotnet tool update MetaFac.CG4.CLI --global --ignore-failed-sources

::
:: generate models from schema
::

set schema=MyFamily.Schema
set models=MyFamily.Models

call :a2c Contracts
call :a2c MessagePack

goto :eof

:a2c
    mfcg4 a2c -am ..\%schema%\bin\Debug\net8.0\%schema%.dll -an %schema% -g %1 -o Generated.%1.g.cs -on %models%
    goto :eof
