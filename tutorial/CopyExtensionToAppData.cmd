REM エクステンションのプロジェクトのビルド時にDLLをAppDataにコピーするためのバッチファイル。
REM ビルド後イベントに以下のコマンドを実行することでコピー可能。
REM $(SolutionDir)\CopyExtensionToAppData.cmd  $(TargetDir) $(ProjectName)

setlocal
REM %1 ... コピー元のフォルダ
REM %2 ... プロジェクト名

set DESTINATION_FOLDER=%USERPROFILE%\AppData\Local\DENSO CREATE\Lightning Review\extensions\%2

REM コピー先のファルダ内のファイルを全て削除してからコピーする
rd /s /q "%DESTINATION_FOLDER%"
xcopy /S /I /Q /Y "%1*" "%DESTINATION_FOLDER%"
