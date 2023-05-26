#define MyAppSetupName "ContactsApp" + GetDateTimeString('yyyy/mm/dd','','')+"_setup"
#define MyAppName "ContactsApp"
#define MyAppVersion "1.0"
#define MyAppPublisher "Tsukanov, TUSUR"
#define MyAppURL "https://github.com/tsukanovsemen"
#define MyAppExeName "ContactsApp.View.exe"
#define MyAppAssocName MyAppName + " File"
#define MyAppAssocExt ".myp"
#define MyAppAssocKey StringChange(MyAppAssocName, " ", "") + MyAppAssocExt

[Setup]
AppId={{20045191-F686-4EF2-877B-F9711C70CEC0}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\Tsukanov\{#MyAppName}
ChangesAssociations=yes
DisableProgramGroupPage=yes
OutputDir="Output"
OutputBaseFilename={#MyAppSetupName}
SetupIconFile="..\src\ContactsApp\ContactsApp.View\ContactsApp_96x96.ico"
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "..\src\ContactsApp\ContactsApp.View\bin\Debug\ContactsApp.View.exe"; DestDir: "{app}"
Source: "..\src\ContactsApp\ContactsApp.View\bin\Debug\ContactsApp.Model.dll"; DestDir: "{app}"
Source: "..\src\ContactsApp\ContactsApp.View\bin\Debug\Newtonsoft.Json.dll"; DestDir: "{app}"

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

