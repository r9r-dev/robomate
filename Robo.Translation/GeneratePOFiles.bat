echo Setting up global variables...
SET path_xgettext=gettext\Gnu.Gettext.Win32\xgettext.exe
SET file_list=..\*.cs
SET path_output=pot

echo Generating strings po file...
CALL gettext\Scripts\ExtractStrings.bat Strings