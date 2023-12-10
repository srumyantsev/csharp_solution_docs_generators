@REM ---
@REM Phase: Create *.plantuml file
@REM Directories paths and variables https://superuser.com/a/1441104
@REM ---
SET TOOL_PATH=".\Appulate.CodeDiagrams.MassTransit.Consumers\bin\Debug\net7.0\"
SET TOOL=Appulate.CodeDiagrams.MassTransit.Consumers.exe
SET TOOL_FULL_PATH="%TOOL_PATH:"=%%TOOL:"=%"
SET TOOL_STORAGE_FILE=consumers.json
SET TOOL_STORAGE_FILE_FULL_PATH="%TOOL_PATH:"=%%TOOL_STORAGE_FILE:"=%"
SET TOOL_EXPORT_FILE=masstransit-events
SET TOOL_EXPORT_FILE_FULL_PATH="%TOOL_PATH:"=%%TOOL_EXPORT_FILE:"=%"

SET SLN_PATH="D:\Projects\appulate\Sources\Appulate.sln"

SET PLANT_UML_FILE_FULL_PATH="%TOOL_EXPORT_FILE_FULL_PATH:"=%.plantuml"

@REM Find
CALL %TOOL_FULL_PATH% find %SLN_PATH% %TOOL_STORAGE_FILE_FULL_PATH%

@REM Export
CALL %TOOL_FULL_PATH% export %TOOL_STORAGE_FILE_FULL_PATH% %TOOL_EXPORT_FILE_FULL_PATH%

@REM ---
@REM Phase: convert result *.plantuml file to SVG
@REM ---
SET PLANT_UML_JAR_PATH="plantuml-1.2023.12.jar"

@REM Convert
CALL java -jar %PLANT_UML_JAR_PATH% %PLANT_UML_FILE_FULL_PATH% -tsvg